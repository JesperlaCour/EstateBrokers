using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Controller;
using Model.Models;

namespace GUI
{
    public partial class SagsSøgningsForm : Form
    {
        public SagsSøgningsForm()
        {
            InitializeComponent();
        }

        private void btn_CreateNewCase_Click(object sender, EventArgs e)
        {
            OpretSagForm osf = new OpretSagForm();
            osf.ShowDialog();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            dataGridView_caseOrder.DataSource = CaseOrderControllerSingleton.Instance().GetAllCaseOrdrsForSearchByAddress(txt_address.Text);
            dataGridView_caseOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_caseOrder.Columns["CaseOrderID"].HeaderText = "Kundenummer";
            dataGridView_caseOrder.Columns["CaseStatus"].HeaderText = "Status";

            dataGridView_caseOrder.Columns["Broker"].Visible = false;
            dataGridView_caseOrder.Columns["Buyer"].Visible = false;
            dataGridView_caseOrder.Columns["Seller"].Visible = false;
            dataGridView_caseOrder.Columns["OpenHouses"].Visible = false;
        }

        private void btn_choose_Click(object sender, EventArgs e)
        {
            if (dataGridView_caseOrder.SelectedRows.Count > 0)
            {
                UC3AdministrereSag.caseId = dataGridView_caseOrder.SelectedCells[0].Value.ToString();
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Ingen sag valgt");
            
        }
    }
}
