using Controller;
using Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GUI
{
    public partial class UC7Salgsstatus : UserControl
    {
        public static string CaseId;
        private CaseOrder co;
        public static string buyerID{ get; set; }
        public UC7Salgsstatus()
        {
            InitializeComponent();
            Thread thread = new Thread(new ThreadStart(UpdateDropdown_CaseStatus));
            thread.IsBackground = true;
            thread.Priority = ThreadPriority.Lowest;
            thread.Start();
            //UpdateDropdown_CaseStatus();
        }

        private void btn_ChooseCustomer_Click(object sender, EventArgs e)
        {
            KundeSøgningsForms opkf = new KundeSøgningsForms();
            if (opkf.ShowDialog() == DialogResult.OK)
            {
                lbl_BuyerId.Text = buyerID;
                btn_Save.Visible = true;
            }
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {

                UpdateCaseStatus();
        }

        private void UpdateDropdown_CaseStatus()
        {
            Cbo_CaseStatus.DataSource = CaseOrderControllerSingleton.Instance().GetCaseStatuses();
            Cbo_CaseStatus.DisplayMember = "Status";
            Cbo_CaseStatus.ValueMember = "CaseStatusId";
        }


        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (co != null)
            {
                co.CaseStatusId = Convert.ToInt32(Cbo_CaseStatus.SelectedValue);
                if (Convert.ToInt32(Cbo_CaseStatus.SelectedValue) == 3)
                {
                    co.BuyerId = Convert.ToInt32(lbl_BuyerId.Text);
                    TilpasSlagsprisForm tsf = new TilpasSlagsprisForm(co.EstateId, 2);
                    tsf.ShowDialog();
                }

                CaseOrderControllerSingleton.Instance().UpdateCaseOrderStatus(co);

                MessageBox.Show("Ændringer gemt");

            }
            else
            {
                MessageBox.Show("Fejl: Der er ikke valgt en sag");
            }
        }

        private void btn_FindCaseOrder_Click(object sender, EventArgs e)
        {
            SagsSøgningsForm ssf = new SagsSøgningsForm();
            if (ssf.ShowDialog() == DialogResult.OK)
            {
                txt_CaseOrderId.Text = CaseId;
                UpdateCaseStatus();
            }

            
        }

        private void UpdateCaseStatus()
        {
            try
            {
                co = CaseOrderControllerSingleton.Instance().GetCaseOrder(Convert.ToInt32(txt_CaseOrderId.Text));
                if (co != null)
                {
                    lbl_CaseOrderId.Text = co.CaseOrderId.ToString();
                    Cbo_CaseStatus.SelectedValue = co.CaseStatusId;
                    lbl_SellerId.Text = co.SellerId.ToString();
                    lbl_BrokerId.Text = co.BrokerId.ToString();
                    lbl_EstateId.Text = co.EstateId.ToString();
                    lbl_BuyerId.Text = co.BuyerId.ToString();
                }

                else
                {
                    MessageBox.Show("Der findes ingen gyldige sager med det søgte id");
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Fejl: Indtast et sagsnummer");
            }



        }

        private void Cbo_CaseStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_CaseStatus.Text == "")
            {
                btn_Save.Visible = true;
            }
            else if (Cbo_CaseStatus.SelectedIndex == 2)
            {
                btn_Save.Visible = false;
            }
            else
            {
                btn_Save.Visible = true;
            }
        }
    }
} 
