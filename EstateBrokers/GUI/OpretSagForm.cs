﻿using System;
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
            KundeSøgningsForms opkf = new KundeSøgningsForms();
            opkf.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HusSoegningsForm ophf = new HusSoegningsForm();
            ophf.ShowDialog();
        }
    }
}
