using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Controller;

namespace GUI
{
    public partial class UC1AdministrereKunde : UserControl
    {
        public UC1AdministrereKunde()
        {
            InitializeComponent();
        }

        private void bt_GetAllCustAdmin_Click(object sender, EventArgs e)
        {
            dataGridView_CustAdmin.DataSource = CustomerControllerSingleton.Instance().GetGridCustomerData("").Customers.Local.ToBindingList();


            dataGridView_CustAdmin.Columns["CustomerId"].HeaderText = "Kundenummer";
            dataGridView_CustAdmin.Columns["Name"].HeaderText = "Navn";
            dataGridView_CustAdmin.Columns["Address"].HeaderText = "Adresse";
            dataGridView_CustAdmin.Columns["PhoneNr"].HeaderText = "Telefonnummer";
            dataGridView_CustAdmin.Columns["ZipCode"].HeaderText = "Postnummer";
            dataGridView_CustAdmin.Columns["ZipCodeNavigation"].HeaderText = "PostnummerNavigation";
            dataGridView_CustAdmin.Columns["CaseOrderBuyers"].HeaderText = "SagsOrdreKøbere";
            dataGridView_CustAdmin.Columns["CaseOrderSellers"].HeaderText = "SagsOrdreSælgere";

            this.dataGridView_CustAdmin.Columns["ZipCodeNavigation"].Visible = false;
            this.dataGridView_CustAdmin.Columns["CaseOrderBuyers"].Visible = false;
            this.dataGridView_CustAdmin.Columns["CaseOrderSellers"].Visible = false;

        }


        private void bt_saveCustAdmin_Click(object sender, EventArgs e)
        {
            CustomerControllerSingleton.Instance().SaveDBContext();
        }
    }
}
