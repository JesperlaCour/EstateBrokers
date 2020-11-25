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
    public partial class OpretSagForm : Form
    {
        public static string sellerID { get; set; }
        public static string estateID { get; set; }

        public OpretSagForm()
        {
            InitializeComponent();
            Update_ChooseBrokerDropdown();
            //Thread BrokerDropdown = new Thread(new ThreadStart(Update_ChooseBrokerDropdown));
            //BrokerDropdown.IsBackground = true;
            //BrokerDropdown.Start();
        }

        public OpretSagForm(decimal v)
        {
            InitializeComponent();
            Update_ChooseBrokerDropdown();
            tbt_ListingPrice.Text = v.ToString();

        }

        private void Update_ChooseBrokerDropdown()
        {
            cbo_ChooseBroker.DataSource = Broker_TypeControllerSingleton.Instance().GetListBrokers();
            cbo_ChooseBroker.DisplayMember = "Name";
            cbo_ChooseBroker.ValueMember = "BrokerId";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KundeSøgningsForms opkf = new KundeSøgningsForms();
            if (opkf.ShowDialog() == DialogResult.OK)
            {
                tbt_sellerID.Text = sellerID;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HusSoegningsForm ophf = new HusSoegningsForm();
            if (ophf.ShowDialog() == DialogResult.OK)
            {
                tbt_estateID.Text = estateID;
            }
        }

        private void bt_CreateNewCase_Click(object sender, EventArgs e)
        {
            try
            {
                CaseOrderControllerSingleton.Instance().CreateCaseOrder(new CaseOrder(
                1,
                Convert.ToInt32(tbt_sellerID.Text),
                Convert.ToInt32(cbo_ChooseBroker.SelectedValue),
                Convert.ToInt32(tbt_estateID.Text)),1,Convert.ToInt32(tbt_ListingPrice.Text));
                MessageBox.Show("Ny sag oprettet");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Fejl i oprettelse");
            }
            
        }
       
    }
}
