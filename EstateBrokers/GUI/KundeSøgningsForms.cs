using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class KundeSøgningsForms : Form
    {
        public KundeSøgningsForms()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpretNyKundeForms opnkf = new OpretNyKundeForms();
            opnkf.ShowDialog();
        }
    }
}
