using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Controller;
using Microsoft.EntityFrameworkCore;

namespace GUI
{
    public partial class KundeSøgningsForms : Form
    {
        public KundeSøgningsForms()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpretNyKundeForms opnkf = new OpretNyKundeForms();
            opnkf.ShowDialog();
        }

        private void btn_soeg_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CustomerControllerSingleton.Instance().GetGridCustomerData(tbt_address.Text).Customers.Local.ToBindingList();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Columns["CustomerId"].HeaderText = "Kundenummer";
            dataGridView1.Columns["Name"].HeaderText = "Navn";
            dataGridView1.Columns["Address"].HeaderText = "Adresse";
            dataGridView1.Columns["PhoneNr"].HeaderText = "Tlf. Nr.";
            dataGridView1.Columns["Zipcode"].HeaderText = "Postnummer";
            dataGridView1.Columns["ZipCodeNavigation"].HeaderText = "PostnummerNavigation";
            dataGridView1.Columns["CaseOrderBuyers"].HeaderText = "SagsOrdreKøbere";
            dataGridView1.Columns["CaseOrderSellers"].HeaderText = "SagsOrdreSælgere";


        }

        private void btn_ChooseKunde_Click(object sender, EventArgs e)
        {
            string custID = dataGridView1.SelectedCells[0].Value.ToString();
            MessageBox.Show(custID);
        }
    }
}
