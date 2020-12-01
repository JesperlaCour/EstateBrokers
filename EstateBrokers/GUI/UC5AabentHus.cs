using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Controller;
using Model.Models;
using System.Linq;
using System.Threading;

namespace GUI
{
    public partial class UC5AabentHus : UserControl
    {
        public UC5AabentHus()
        {
            InitializeComponent();
            Thread thread = new Thread(new ThreadStart(UpdateBrokerCombobox));
            thread.IsBackground = true;
            thread.Priority = ThreadPriority.Lowest;
            thread.Start();
            //UpdateBrokerCombobox();
        }

        void UpdateBrokerCombobox()
        {
            cbo_brokers.DataSource = Broker_TypeControllerSingleton.Instance().GetListBrokers();
            cbo_brokers.DisplayMember = "Name";
            cbo_brokers.ValueMember = "BrokerId";
        }
        List<CaseOrder> ActiveCaseOrders;
        private void btn_Search_Click(object sender, EventArgs e)
        {
            
            
             ActiveCaseOrders = CaseOrderControllerSingleton.Instance().GetAllCaseOrdrsForSearchByAddress(txt_address.Text).Where(c => c.CaseStatusId == 1).ToList();

            
            dataGridView_AllCaseOrders.DataSource = ActiveCaseOrders;
            dataGridView_AllCaseOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            SetAllCaseColumns();
            
        }
        List<CaseOrder> SelectedCaseOrders = new List<CaseOrder>();
        private void btn_ChooseHouse_Click(object sender, EventArgs e)
        {
            if (dataGridView_AllCaseOrders.SelectedRows.Count != 0)
            {
                dataGridView_selectedCaseOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView_selectedCaseOrders.DataSource = null;
                SelectedCaseOrders.Add(CaseOrderControllerSingleton.Instance().GetCaseOrder(Convert.ToInt32(dataGridView_AllCaseOrders.SelectedCells[0].Value)));
                dataGridView_selectedCaseOrders.DataSource = SelectedCaseOrders;

                ActiveCaseOrders.RemoveAt(dataGridView_AllCaseOrders.SelectedCells[0].RowIndex);
                dataGridView_AllCaseOrders.DataSource = null;
                dataGridView_AllCaseOrders.DataSource = ActiveCaseOrders;

                SetSelectedColumns();
            }
            

            
        }

        private void SetAllCaseColumns()
        {
            dataGridView_AllCaseOrders.Columns.OfType<DataGridViewColumn>().ToList().ForEach(col => col.Visible = false);
            dataGridView_AllCaseOrders.Columns["CaseOrderID"].HeaderText = "Sagsnummer";
            dataGridView_AllCaseOrders.Columns["CaseOrderID"].Visible = true;
            dataGridView_AllCaseOrders.Columns["Estate"].Visible = true;
            dataGridView_AllCaseOrders.Columns["BrokerId"].Visible = true;
            dataGridView_AllCaseOrders.Columns["SellerId"].Visible = true;
            dataGridView_AllCaseOrders.Columns["EstateId"].Visible = true;
        }
        private void SetSelectedColumns() {
            SetAllCaseColumns();
            dataGridView_selectedCaseOrders.Columns.OfType<DataGridViewColumn>().ToList().ForEach(col => col.Visible = false);
            dataGridView_selectedCaseOrders.Columns["CaseOrderID"].HeaderText = "Sagsnummer";
            dataGridView_selectedCaseOrders.Columns["CaseOrderID"].Visible = true;
            dataGridView_selectedCaseOrders.Columns["Estate"].Visible = true;
            dataGridView_selectedCaseOrders.Columns["BrokerId"].Visible = true;
            dataGridView_selectedCaseOrders.Columns["SellerId"].Visible = true;
            dataGridView_selectedCaseOrders.Columns["EstateId"].Visible = true;
        }
        private void btn_RemoveHouse_Click(object sender, EventArgs e)
        {
            if (dataGridView_selectedCaseOrders.SelectedRows.Count != 0)
            {
                dataGridView_AllCaseOrders.DataSource = null;
                ActiveCaseOrders.Add(CaseOrderControllerSingleton.Instance().GetCaseOrder(Convert.ToInt32(dataGridView_selectedCaseOrders.SelectedCells[0].Value)));
                dataGridView_AllCaseOrders.DataSource = ActiveCaseOrders;


                SelectedCaseOrders.RemoveAt(dataGridView_selectedCaseOrders.SelectedCells[0].RowIndex);
                dataGridView_selectedCaseOrders.DataSource = null;
                dataGridView_selectedCaseOrders.DataSource = SelectedCaseOrders;

                SetSelectedColumns();
            }
            
        }

        List<Broker> brokers = new List<Broker>();
        private void cbo_brokers_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            brokers.Add((Broker)cbo_brokers.SelectedItem);
            listBox_selectedBrokers.DataSource = null;
            listBox_selectedBrokers.DataSource = brokers;
            listBox_selectedBrokers.DisplayMember = "Name";
            

            //dataGridView_selectedBrokers.DataSource = null;
            //dataGridView_selectedBrokers.DataSource = brokers;
            //dataGridView_selectedBrokers.ColumnHeadersVisible = false;
            //dataGridView_selectedBrokers.Columns.OfType<DataGridViewColumn>().ToList().ForEach(col => col.Visible = false);
            //dataGridView_selectedBrokers.Columns["Name"].Visible = true;
        }

        private void btn_Assigned_Click(object sender, EventArgs e)
        {

            OpenHouseControllerSingleton.Instance().AssignOpenHouses(SelectedCaseOrders, brokers, dateTimePicker1.Value);

            OpenhouseOverview overview = new OpenhouseOverview(dateTimePicker1.Value);
            overview.ShowDialog();
        }

        private void btn_ShowExisting_Click(object sender, EventArgs e)
        {
            OpenhouseOverview oho = new OpenhouseOverview();
            oho.ShowDialog();
        }

        private void btn_clearBrokerList_Click(object sender, EventArgs e)
        {
            brokers = new List<Broker>();
            listBox_selectedBrokers.DataSource = null;
        }
    }
}
