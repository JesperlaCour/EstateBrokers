using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Model;
using Model.Models;
using System.Linq;
using Controller;

namespace GUI
{
    public partial class UC3AdministrereSag : UserControl
    {
        
        public UC3AdministrereSag()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            
            //listBox1.DataSource = ControllerSingleton.Instance().();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            //ControllerSingleton.Instance().CreateCustomer(new Customer
            //(textBox1.Text,textBox2.Text,Convert.ToInt32(textBox3.Text),Convert.ToInt32(textBox4.Text)
            //));

        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpretSagForm opf = new OpretSagForm();
            opf.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpretKundeForms okf = new OpretKundeForms();
            okf.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpretHusForm ohf = new OpretHusForm();
            ohf.ShowDialog();
        }
    }
}
