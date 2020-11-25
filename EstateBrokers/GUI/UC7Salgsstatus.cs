using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class UC7Salgsstatus : UserControl
    {
        public UC7Salgsstatus()
        {
            InitializeComponent();
        }

        private void btn_ChooseCustomer_Click(object sender, EventArgs e)
        {
            KundeSøgningsForms ksf = new KundeSøgningsForms();
            ksf.ShowDialog();
        }
    }
}
