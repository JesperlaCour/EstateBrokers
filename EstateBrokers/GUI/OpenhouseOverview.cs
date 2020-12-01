using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Controller;
using Model.Models;


namespace GUI
{
    public partial class OpenhouseOverview : Form
    {   
        public OpenhouseOverview()
        {
            InitializeComponent();
            //UpdateDateBox();

            Thread thread = new Thread(new ThreadStart(UpdateDateBox));
            thread.IsBackground = true;
            thread.Priority = ThreadPriority.Lowest;
            thread.Start();

        }
        public OpenhouseOverview(DateTime date)
        {
            InitializeComponent();
            UpdateDateBox();
            cbo_PickDate.SelectedIndex = cbo_PickDate.Items.Count - 1;
        }

        private void UpdateDateBox()
        {
            List<DateTime> dates = new List<DateTime>();
            foreach (var item in OpenHouseControllerSingleton.Instance().GetDatesForOpenHouses())
            {
                dates.Add(Convert.ToDateTime(item.Value));
            }
            cbo_PickDate.DataSource = SortDescending(dates);

        }
        private List<DateTime> SortDescending(List<DateTime> list)
        {
            list.Sort((a, b) => b.CompareTo(a));
            return list;
        }

        private void cbo_PickDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            dataGridView_ShowDistribution.DataSource = OpenHouseControllerSingleton.Instance().GetOpenHouses((DateTime)cbo_PickDate.SelectedItem);
            dataGridView_ShowDistribution.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void dataGridView_ShowDistribution_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Estate estate = EstateControllerSingleton.Instance().GetEstate(
                CaseOrderControllerSingleton.Instance().GetCaseOrder(
                    Convert.ToInt32(dataGridView_ShowDistribution.SelectedCells[3].Value))
                .EstateId)[0];

            lbl_address.Text = estate.Address;
            lbl_price.Text = CaseOrderControllerSingleton.Instance().GetPriceHistory(estate.EstateId).Last().Price.ToString();

            tableLayoutPanel1.Visible = true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            OpenHouseControllerSingleton.Instance().SaveDBContext();
            MessageBox.Show("Ændringer er gemt");
            this.Controls.Clear();

            this.InitializeComponent();
            UpdateDateBox();

        }
    }
}
