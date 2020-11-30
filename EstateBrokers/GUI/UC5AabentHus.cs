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

namespace GUI
{
    public partial class UC5AabentHus : UserControl
    {
        public UC5AabentHus()
        {
            InitializeComponent();
            UpdateBrokerCombobox();
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

            //for (int i = 0; i < ActiveCaseOrders.Count; i++)
            //{
            //    if (ActiveCaseOrders[i].CaseStatusId != 1)
            //    {
            //        ActiveCaseOrders.RemoveAt(i);
            //        i--;
            //    }
            //}
            
            dataGridView_AllCaseOrders.DataSource = ActiveCaseOrders;

            dataGridView_AllCaseOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_AllCaseOrders.Columns["CaseOrderID"].HeaderText = "Sagsnummer";
            dataGridView_AllCaseOrders.Columns["CaseStatusID"].HeaderText = "Status";
            dataGridView_AllCaseOrders.Columns["BrokerId"].Visible = false;
            dataGridView_AllCaseOrders.Columns["Broker"].Visible = false;
            dataGridView_AllCaseOrders.Columns["Buyer"].Visible = false;
            dataGridView_AllCaseOrders.Columns["Seller"].Visible = false;
            dataGridView_AllCaseOrders.Columns["OpenHouses"].Visible = false;
        }
        List<CaseOrder> SelectedCaseOrders = new List<CaseOrder>();
        private void btn_ChooseHouse_Click(object sender, EventArgs e)
        {
            dataGridView_selectedCaseOrders.DataSource = null;
            SelectedCaseOrders.Add(CaseOrderControllerSingleton.Instance().GetCaseOrder(Convert.ToInt32(dataGridView_AllCaseOrders.SelectedCells[0].Value)));
            dataGridView_selectedCaseOrders.DataSource = SelectedCaseOrders;

            ActiveCaseOrders.RemoveAt(dataGridView_AllCaseOrders.CurrentCell.RowIndex);
            dataGridView_AllCaseOrders.DataSource = null;
            dataGridView_AllCaseOrders.DataSource = ActiveCaseOrders;

            
            
        }

        private void btn_RemoveHouse_Click(object sender, EventArgs e)
        {
            dataGridView_AllCaseOrders.DataSource = null;
            ActiveCaseOrders.Add(CaseOrderControllerSingleton.Instance().GetCaseOrder(Convert.ToInt32(dataGridView_selectedCaseOrders.SelectedCells[0].Value)));
            dataGridView_AllCaseOrders.DataSource = ActiveCaseOrders;

            
            SelectedCaseOrders.RemoveAt(dataGridView_selectedCaseOrders.CurrentCell.RowIndex);
            dataGridView_selectedCaseOrders.DataSource = null;
            dataGridView_selectedCaseOrders.DataSource = SelectedCaseOrders;
        }

        List<Broker> brokers = new List<Broker>();
        private void cbo_brokers_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            brokers.Add((Broker)cbo_brokers.SelectedItem);
            dataGridView_selectedBrokers.DataSource = null;
            dataGridView_selectedBrokers.DataSource = brokers;
        }

        private void btn_Assigned_Click(object sender, EventArgs e)
        {
            List<OpenHouse> openHouseArrangements = new List<OpenHouse>();

            foreach (var item in SelectedCaseOrders)
            {
                item.lastPrice = Convert.ToDecimal(CaseOrderControllerSingleton.Instance().GetPriceHistory(item.EstateId).Last().Price);
            }

            SelectedCaseOrders = SelectedCaseOrders.OrderByDescending(c => c.lastPrice).ToList();
            //dataGridView_selectedCaseOrders.DataSource = null;
            //dataGridView_selectedCaseOrders.DataSource = SelectedCaseOrders;
            int j = 0;

            for (int i = 0; i <= brokers.Count; i++)
            {
                if (i < brokers.Count)
                {
                    openHouseArrangements.Add(new OpenHouse(Convert.ToDateTime(dateTimePicker1.Value), brokers[i].BrokerId, SelectedCaseOrders[j].CaseOrderId));
                    j++;
                }
                else
                    i = -1;
                if (j >= SelectedCaseOrders.Count())
                {
                    break;
                }
            }


            dataGridView_selectedCaseOrders.DataSource = null;
            dataGridView_selectedCaseOrders.DataSource = openHouseArrangements;

        }
    }
}
