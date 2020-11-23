using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Controller;
using Microsoft.EntityFrameworkCore;
namespace GUI
{
    public partial class HusSoegningsForm : Form
    {
        public HusSoegningsForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpretNytHusForms opnhf = new OpretNytHusForms();
            opnhf.ShowDialog();
        }

        private void btn_soeg_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = EstateControllerSingleton.Instance().GetGridEstateData(tbt_address.Text).Estates.Local.ToBindingList();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
