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
        public static string caseId;
        public UC3AdministrereSag()
        {
            InitializeComponent();
        }

        private void btn_newCase_Click(object sender, EventArgs e)
        {
            OpretSagForm opf = new OpretSagForm();
            opf.ShowDialog();
        }

        private void btn_NewCustomer_Click(object sender, EventArgs e)
        {
            OpretNyKundeForms onkf = new OpretNyKundeForms();
            onkf.ShowDialog();
            
        }

        private void btn_NewHouse_Click(object sender, EventArgs e)
        {
            OpretNytHusForms onhf = new OpretNytHusForms();
            onhf.ShowDialog();
        }

        

        private void btn_showCaseOrder_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateAdminCase();
                UpdateBrokerInfo();
                updateNextOpenHouseDate();
            }
            catch (Exception)
            {

                MessageBox.Show("Sag ikke fundet");
            }
        }
        CaseOrder co;
        private void UpdateAdminCase()
        {
            co = CaseOrderControllerSingleton.Instance().GetCaseOrder(Convert.ToInt32(txt_caseOrderID.Text));
            if (co == null)
            {
                throw new Exception();
            }

                Customer seller = CustomerControllerSingleton.Instance().GetCustomer(co.SellerId);

                if (co.CaseStatusId == 3)
                {
                    Customer buyer = CustomerControllerSingleton.Instance().GetCustomer(co.BuyerId);
                    tableLayoutPanel_buyerInfo.Visible = true;
                    lbl_KoeberNavn.Text = buyer.Name;
                    lbl_KoeberKundenummer.Text = buyer.CustomerId.ToString();
                    lbl_KoeberAdresse.Text = buyer.Address;
                    lbl_KoeberTlfNr.Text = buyer.PhoneNr.ToString();
                    lbl_KoeberPostnummer.Text = buyer.ZipCode.ToString();
                    lbl_KoeberBy.Text = CustomerControllerSingleton.Instance().GetCityFromZipCode(buyer.ZipCode).ToString();
                }
                else
                {
                    tableLayoutPanel_buyerInfo.Visible = false;
                }
                lbl_SælgerKundenummer.Text = seller.CustomerId.ToString();
                lbl_SælgerNavn.Text = seller.Name;
                lbl_SælgerAdresse.Text = seller.Address;
                lbl_SælgerPostnummer.Text = seller.ZipCode.ToString();
                lbl_SælgerTlfNr.Text = seller.PhoneNr.ToString();
                lbl_SælgerBy.Text = CustomerControllerSingleton.Instance().GetCityFromZipCode(seller.ZipCode).ToString();

                dataGridView_HouseInformation.DataSource = EstateControllerSingleton.Instance().GetEstate(co.EstateId);
                dataGridView_PriceHistory.DataSource = CaseOrderControllerSingleton.Instance().GetPriceHistory(co.EstateId);


                dataGridView_HouseInformation.Columns["EstateId"].HeaderText = "EjendomsId";
                dataGridView_HouseInformation.Columns["Address"].HeaderText = "Adresse";
                dataGridView_HouseInformation.Columns["BuildYear"].HeaderText = "HusetsByggelsesår";
                dataGridView_HouseInformation.Columns["RemodelYear"].HeaderText = "RenoveringsÅr";
                dataGridView_HouseInformation.Columns["Condition"].HeaderText = "Stand";
                dataGridView_HouseInformation.Columns["Areal"].HeaderText = "Areal";
                dataGridView_HouseInformation.Columns["Rooms"].HeaderText = "Rum";
                dataGridView_HouseInformation.Columns["Floors"].HeaderText = "Etager";
                dataGridView_HouseInformation.Columns["Garden"].HeaderText = "Have";
                dataGridView_HouseInformation.Columns["ZipCode"].HeaderText = "Postnummer";
                dataGridView_HouseInformation.Columns["TypeId"].HeaderText = "TypeId";
                dataGridView_HouseInformation.Columns["Type"].HeaderText = "Type";
                dataGridView_HouseInformation.Columns["ZipCodeNavigation"].HeaderText = "PostnummerNavigation";
                dataGridView_HouseInformation.Columns["CaseOrders"].HeaderText = "SagsOrdre";
                dataGridView_HouseInformation.Columns["PriceHistories"].HeaderText = "PrisHistorik";


                this.dataGridView_HouseInformation.Columns["ZipCodeNavigation"].Visible = false;
                this.dataGridView_HouseInformation.Columns["Type"].Visible = false;
                this.dataGridView_HouseInformation.Columns["CaseOrders"].Visible = false;
                this.dataGridView_HouseInformation.Columns["PriceHistories"].Visible = false;


                dataGridView_PriceHistory.Columns["PriceHistoryId"].HeaderText = "PrisHistorik";
                dataGridView_PriceHistory.Columns["Price"].HeaderText = "Pris";
                dataGridView_PriceHistory.Columns["Date"].HeaderText = "Dato";
                dataGridView_PriceHistory.Columns["PriceType"].HeaderText = "PrisType";
                dataGridView_PriceHistory.Columns["EstateId"].HeaderText = "EjendomsId";
                dataGridView_PriceHistory.Columns["Estate"].HeaderText = "Ejendom";

                this.dataGridView_PriceHistory.Columns["Estate"].Visible = false;
            
        }

        private void UpdateBrokerInfo()
        {
            if (co != null)
            {
                Broker broker = Broker_TypeControllerSingleton.Instance().GetBroker(Convert.ToInt32(co.BrokerId));
                lbl_brokerID.Text = broker.BrokerId.ToString();
                lbl_BrokerName.Text = broker.Name.ToString();
                lbl_DepartmentId.Text = broker.DepartmentId.ToString();
                lbl_department.Text = Broker_TypeControllerSingleton.Instance().GetDepartment(broker.DepartmentId).DepartmentName.ToString();

            }
        }
        private void updateNextOpenHouseDate()
        {
            if (co != null)
            {
                OpenHouse oh = OpenHouseControllerSingleton.Instance().GetNextOpenHouse(co.CaseOrderId);
                if (oh != null)
                {
                    lbl_nextOpenHouse.Text = Convert.ToDateTime(oh.Date).ToShortDateString();
                }
                else
                    lbl_nextOpenHouse.Text = "Ingen planlagte";
            }
        }

        private void btn_SearchCase_Click(object sender, EventArgs e)
        {

            SagsSøgningsForm ssf = new SagsSøgningsForm();
            if (ssf.ShowDialog() == DialogResult.OK)
            {
                txt_caseOrderID.Text = caseId;
                UpdateAdminCase();
                UpdateBrokerInfo();
                updateNextOpenHouseDate();
            }
        }


        private void btn_ChangeSalesPrice_Click(object sender, EventArgs e)
        {
            if (co != null)
            {
                TilpasSlagsprisForm tsf = new TilpasSlagsprisForm(co.EstateId, 1);
                if (tsf.ShowDialog() == DialogResult.OK)
                {
                    dataGridView_PriceHistory.DataSource = CaseOrderControllerSingleton.Instance().GetPriceHistory(co.EstateId);
                }
            }
            
            
        }

    }
}
