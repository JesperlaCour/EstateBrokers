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
    public partial class OpretNyKundeForms : Form
    {
        public OpretNyKundeForms()
        {
            InitializeComponent();
        }

        private void btn_opret_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerControllerSingleton.Instance().CreateCustomer(new Customer(txt_Navn.Text,
                txt_Adresse.Text,
                Convert.ToInt32(txt_TlfNr.Text),
                Convert.ToInt32(txt_Postnummer.Text)
                ));
                MessageBox.Show("Kunde oprettet");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Fejl i kundeoprettelse. Prøv igen.");
            }
            

        }
    }
}
