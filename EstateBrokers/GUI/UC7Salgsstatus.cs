using Controller;
using Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
            UpdateDropdown_CaseStatus();
        }

        private void btn_ChooseCustomer_Click(object sender, EventArgs e)
        {
            KundeSøgningsForms opkf = new KundeSøgningsForms();
            if (opkf.ShowDialog() == DialogResult.OK)
            {
                lbl_BuyerId.Text = buyerID;
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
            co.CaseStatusId = Convert.ToInt32(Cbo_CaseStatus.SelectedValue);
            if (Convert.ToInt32(Cbo_CaseStatus.SelectedValue) == 3)
            {
                co.BuyerId = Convert.ToInt32(lbl_BuyerId.Text);
            }

            CaseOrderControllerSingleton.Instance().UpdateCaseOrderStatus(co);
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
            co = CaseOrderControllerSingleton.Instance().GetCaseOrder(Convert.ToInt32(txt_CaseOrderId.Text));

            lbl_CaseOrderId.Text = co.CaseOrderId.ToString();
            Cbo_CaseStatus.SelectedValue = co.CaseStatusId;
            lbl_SellerId.Text = co.SellerId.ToString();
            lbl_BrokerId.Text = co.BrokerId.ToString();
            lbl_EstateId.Text = co.EstateId.ToString();
            lbl_BuyerId.Text = co.BuyerId.ToString();
        }
    }
}
