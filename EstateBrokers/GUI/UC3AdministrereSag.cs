using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Model;
using Model.Models;
using System.Linq;
using Controller;
using Microsoft.EntityFrameworkCore;

namespace GUI
{
    public partial class UC3AdministrereSag : UserControl
    {
        
        public UC3AdministrereSag()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpretSagForm opf = new OpretSagForm();
            opf.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpretNyKundeForms onkf = new OpretNyKundeForms();
            onkf.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpretNytHusForms onhf = new OpretNytHusForms();
            onhf.ShowDialog();
        }

        

        private void btn_showCaseOrder_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateAdminCase();
            }
            catch (Exception)
            {

                MessageBox.Show("Sag ikke fundet");
            }
        }
        private void UpdateAdminCase()
        {
            CaseOrder co = CaseOrderControllerSingleton.Instance().GetCaseOrder(Convert.ToInt32(tbt_caseOrderID.Text));
            Customer seller = CustomerControllerSingleton.Instance().GetCustomer(co.SellerId);
            if (co.CaseStatus == "Sold")
            {
                Customer buyer = CustomerControllerSingleton.Instance().GetCustomer(co.BuyerId);
                lbl_KoeberNavn.Text = buyer.Name;
                lbl_KoeberKundenummer.Text = buyer.CustomerId.ToString();
                lbl_KoeberAdresse.Text = buyer.Address;
                lbl_KoeberTlfNr.Text = buyer.PhoneNr.ToString();
                lbl_KoeberPostnummer.Text = buyer.ZipCode.ToString();
                lbl_KoeberBy.Text = CustomerControllerSingleton.Instance().GetCityFromZipCode(buyer.ZipCode).ToString();
            }
            lbl_SælgerKundenummer.Text = seller.CustomerId.ToString();
            lbl_SælgerNavn.Text = seller.Name;
            lbl_SælgerAdresse.Text = seller.Address;
            lbl_SælgerPostnummer.Text = seller.ZipCode.ToString();
            lbl_SælgerTlfNr.Text = seller.PhoneNr.ToString();
            lbl_SælgerBy.Text = CustomerControllerSingleton.Instance().GetCityFromZipCode(seller.ZipCode).ToString();

            dataGridView_HouseInformation.DataSource = EstateControllerSingleton.Instance().GetEstate(co.EstateId);
            dataGridView_PriceHistory.DataSource = CaseOrderControllerSingleton.Instance().GetPriceHistory(co.EstateId);

        }

        private void button5_Click(object sender, EventArgs e)
        {

            SagsSøgningsForm ssf = new SagsSøgningsForm();
            ssf.ShowDialog();


        }
    }
}
