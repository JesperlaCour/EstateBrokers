using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Controller;
using System.Linq;

namespace GUI
{
    public partial class UC0AdministrereMægler : UserControl
    {
        public UC0AdministrereMægler()
        {
            InitializeComponent();
        }

        private void btn_HentAlle_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Broker_TypeControllerSingleton.Instance().GetGridBrokers().Local.ToBindingList();

            dataGridView1.Columns["BrokerId"].HeaderText = "MæglerId";
            dataGridView1.Columns["Name"].HeaderText = "Navn";
            dataGridView1.Columns["DepartmentId"].HeaderText = "AfdelingId";
            dataGridView1.Columns["Department"].HeaderText = "Afdeling";
            dataGridView1.Columns["CaseOrders"].HeaderText = "SagsOrdre";
            dataGridView1.Columns["OpenHouses"].HeaderText = "ÅbenthusDage";

            this.dataGridView1.Columns["CaseOrders"].Visible = false;
            this.dataGridView1.Columns["OpenHouses"].Visible = false;

        }

        private void btn_Gem_Click(object sender, EventArgs e)
        {
            Broker_TypeControllerSingleton.Instance().UpdateBrokers();

        }

        private void btn_TypeHentAlle_Click(object sender, EventArgs e)
        {

            dataGridView2.DataSource = Broker_TypeControllerSingleton.Instance().GetGridType().Local.ToBindingList();


            dataGridView2.Columns["TypeId"].HeaderText = "TypeId";
            dataGridView2.Columns["Type"].HeaderText = "Type";
            dataGridView2.Columns["Estates"].HeaderText = "Ejendom";

            this.dataGridView2.Columns["Estates"].Visible = false;

        }

        private void btn_TypeGem_Click(object sender, EventArgs e)
        {
            Broker_TypeControllerSingleton.Instance().UpdateType();

        }
    }
}
