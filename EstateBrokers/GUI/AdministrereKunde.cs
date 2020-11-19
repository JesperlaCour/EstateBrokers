﻿using Microsoft.EntityFrameworkCore;
using Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model.Models;
using Controller;

namespace GUI
{
    public partial class AdministrereKunde : UserControl
    {
        public AdministrereKunde()
        {
            InitializeComponent();
        }

        private void bt_GetAllCustAdmin_Click(object sender, EventArgs e)
        {
            dataGridView_CustAdmin.DataSource = ControllerSingleton.Instance().GetGridCustomerData().Customers.Local.ToBindingList();
        }

        private void bt_saveCustAdmin_Click(object sender, EventArgs e)
        {
            ControllerSingleton.Instance().UpdateGridCustomerData();
        }
    }
}
