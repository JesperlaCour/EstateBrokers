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
        public OpretSagForm()
        {
            InitializeComponent();
            Update_ChooseBrokerDropdown();
            //Thread BrokerDropdown = new Thread(new ThreadStart(Update_ChooseBrokerDropdown));
            //BrokerDropdown.IsBackground = true;
            //BrokerDropdown.Start();
        }
        private void Update_ChooseBrokerDropdown()
        {

            cbo_ChooseBroker.DataSource = Broker_TypeControllerSingleton.Instance().GetListBrokers();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KundeSøgningsForms opkf = new KundeSøgningsForms();
            opkf.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HusSoegningsForm ophf = new HusSoegningsForm();
            ophf.ShowDialog();
        }

        private void bt_CreateNewCase_Click(object sender, EventArgs e)
        {
            CaseOrderControllerSingleton.Instance().CreateCaseOrder(new CaseOrder(
                "Active",
                Convert.ToInt32(tbt_sellerID.Text),
                1,
                Convert.ToInt32(tbt_estateID.Text)),
                Convert.ToInt32(tbt_ListingPrice.Text));
        }
       
    }
}
