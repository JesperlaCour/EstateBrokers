using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            forside1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            caseManagementcrud1.BringToFront();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            administrereKunde1.BringToFront();
        }
    }
}
