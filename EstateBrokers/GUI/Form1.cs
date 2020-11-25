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
            caseManagementcrud1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            caseManagementcrud1.BringToFront();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            administrereKunde1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            administrereHus1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            udbudsprisBeregner1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            aabentHus1.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            uC0AdministrereMægler1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            uC7Salgsstatus1.BringToFront();
        }
    }
}
