using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Controller;
using Model.Models;
    

namespace GUI
{
    public partial class UC4UdbudsprisBeregner : UserControl
    {
        public UC4UdbudsprisBeregner()
        {
            InitializeComponent();
            Thread thread = new Thread(new ThreadStart(UpdateDropdown_HouseTypes));
            thread.IsBackground = true;
            thread.Priority = ThreadPriority.Lowest;
            thread.Start();
            //UpdateDropdown_HouseTypes();
            //UpdateDropDown_Style();
        }

        private void UpdateDropdown_HouseTypes()
        {
            Cbo_houseType.DataSource = EstateControllerSingleton.Instance().GetHouseTypes();
            Cbo_houseType.DisplayMember = "Type";
            Cbo_houseType.ValueMember = "TypeId";
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            try
            {
                List<Estate> estates = new List<Estate>();
                lbl_listingPrice.Text = ListingCalculatorSingleton.Instance().CalculatedPrice(new CalculationEntities(
                    Convert.ToInt32(Cbo_houseType.SelectedValue),
                    Convert.ToInt32(Txt_zipCode.Text),
                    Convert.ToInt32(Txt_sqm.Text),
                    Trackbar_condition.Value,
                    //Cbo_Indretning.SelectedValue.,
                    Convert.ToInt32(txt_remodelYear.Text),
                    Convert.ToInt32(Txt_AntalBade.Text)), ref estates).ToString();
                dataGridView1.DataSource = estates;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


                dataGridView1.Columns["EstateId"].HeaderText = "EjendomsId";
                dataGridView1.Columns["Address"].HeaderText = "Adresse";
                dataGridView1.Columns["BuildYear"].HeaderText = "HusetsByggelsesår";
                dataGridView1.Columns["RemodelYear"].HeaderText = "RenoveringsÅr";
                dataGridView1.Columns["Condition"].HeaderText = "Stand";
                dataGridView1.Columns["Areal"].HeaderText = "Areal";
                dataGridView1.Columns["Rooms"].HeaderText = "Rum";
                dataGridView1.Columns["Floors"].HeaderText = "Etager";
                dataGridView1.Columns["Garden"].HeaderText = "Have";
                dataGridView1.Columns["ZipCode"].HeaderText = "Postnummer";
                dataGridView1.Columns["TypeId"].HeaderText = "TypeId";
                dataGridView1.Columns["Type"].HeaderText = "Type";
                dataGridView1.Columns["ZipCodeNavigation"].HeaderText = "PostnummerNavigation";
                dataGridView1.Columns["CaseOrders"].HeaderText = "SagsOrdre";
                dataGridView1.Columns["PriceHistories"].HeaderText = "PrisHistorik";


                this.dataGridView1.Columns["ZipCodeNavigation"].Visible = false;
                this.dataGridView1.Columns["Type"].Visible = false;
                this.dataGridView1.Columns["CaseOrders"].Visible = false;
                this.dataGridView1.Columns["PriceHistories"].Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Fejl: Udfyldt venligst alle felter");
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_priceHistory.DataSource = CaseOrderControllerSingleton.Instance().GetPriceHistory(Convert.ToInt32(dataGridView1.SelectedCells[0].Value));

            dataGridView_priceHistory.Columns["PriceHistoryId"].HeaderText = "PrisHistorikId";
            dataGridView_priceHistory.Columns["Price"].HeaderText = "PrisHistorikId";
            dataGridView_priceHistory.Columns["Date"].HeaderText = "PrisHistorikId";
            dataGridView_priceHistory.Columns["PriceType"].HeaderText = "PrisType";
            dataGridView_priceHistory.Columns["EstateId"].HeaderText = "EjendomsId";
            dataGridView_priceHistory.Columns["Estate"].HeaderText = "Ejendom";

            this.dataGridView_priceHistory.Columns["Estate"].Visible = false;

        }

        private void Btn_CreateNewCase_Click(object sender, EventArgs e)
        {
            try
            {
                OpretSagForm osf = new OpretSagForm(Convert.ToDecimal(lbl_listingPrice.Text));
                osf.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Fejl: Vælg hus der skal oprettes sag på");
            }


         
        }
    }
}
