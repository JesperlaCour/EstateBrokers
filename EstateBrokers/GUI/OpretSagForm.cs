using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class OpretSagForm : Form
    {
        public OpretSagForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpretKundeForms opkf = new OpretKundeForms();
            opkf.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpretHusForm ophf = new OpretHusForm();
            ophf.ShowDialog();
        }
    }
}
