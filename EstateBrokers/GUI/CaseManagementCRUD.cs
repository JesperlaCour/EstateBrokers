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

namespace GUI
{
    public partial class CaseManagementCRUD : UserControl
    {
        EstateBrokersContext dbcontext = new EstateBrokersContext();
        public CaseManagementCRUD()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            var zipCodeList = dbcontext.ZipCodes.ToList();
            listBox1.DataSource = zipCodeList ;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            dbcontext.ZipCodes.Add(new ZipCode { ZipCode1 = Convert.ToInt32(textBox1.Text), City = textBox2.Text });
            dbcontext.SaveChanges();
        
        }
    }
}
