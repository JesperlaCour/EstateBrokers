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
        }

        private void btn_Gem_Click(object sender, EventArgs e)
        {
            Broker_TypeControllerSingleton.Instance().UpdateBrokers();

        }

        private void btn_TypeHentAlle_Click(object sender, EventArgs e)
        {

            dataGridView2.DataSource = Broker_TypeControllerSingleton.Instance().GetGridType().Local.ToBindingList();

        }

        private void btn_TypeGem_Click(object sender, EventArgs e)
        {
            Broker_TypeControllerSingleton.Instance().UpdateType();

        }
    }
}
