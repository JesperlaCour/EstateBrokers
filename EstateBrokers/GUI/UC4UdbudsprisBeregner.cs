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
    public partial class UC4UdbudsprisBeregner : UserControl
    {
        public UC4UdbudsprisBeregner()
        {
            InitializeComponent();
            UpdateDropdown_HouseTypes();
            //UpdateDropDown_Style();
        }

        private void UpdateDropdown_HouseTypes()
        {
            Cbo_houseType.DataSource = EstateControllerSingleton.Instance().GetHouseTypes();
            Cbo_houseType.DisplayMember = "Type";
            Cbo_houseType.ValueMember = "TypeId";
        }

        private void UpdateDropDown_Style()
        {
            List<Style> styles = new List<Style>();
            foreach (Style style in Enum.GetValues(typeof(Style)))
            {
                styles.Add(style);
            }
            Cbo_Indretning.DataSource = styles;
            Cbo_Indretning.DisplayMember = "Key";
            Cbo_Indretning.ValueMember = "Value";
        }


        private void btn_calculate_Click(object sender, EventArgs e)
        {
            List<Estate> estates = new List<Estate>();
            lbl_listingPrice.Text = ListingCalculatorSingleton.Instance().CalculatedPrice(new CalculationEntities(
                Convert.ToInt32(Cbo_houseType.SelectedValue),
                Convert.ToInt32(Txt_zipCode.Text),
                Convert.ToInt32(Txt_sqm.Text),
                Trackbar_condition.Value,
                //Cbo_Indretning.SelectedValue.,
                Convert.ToInt32(txt_remodelYear.Text),
                Convert.ToInt32(Txt_AntalBade.Text)),ref estates).ToString();
            dataGridView1.DataSource = estates;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            

            //dataGridView1.Columns[""].HeaderText = "";
            //dataGridView1.Columns[""].HeaderText = "";
            //dataGridView1.Columns[""].HeaderText = "";
            //dataGridView1.Columns[""].HeaderText = "";
            //dataGridView1.Columns[""].HeaderText = "";
            //dataGridView1.Columns[""].HeaderText = "";
            //dataGridView1.Columns[""].HeaderText = "";
            //dataGridView1.Columns[""].HeaderText = "";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_priceHistory.DataSource = CaseOrderControllerSingleton.Instance().GetPriceHistory(Convert.ToInt32(dataGridView1.SelectedCells[0].Value));
        }
    }
}
