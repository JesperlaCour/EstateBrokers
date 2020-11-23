using Microsoft.EntityFrameworkCore;
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
    public partial class UC2AdministrereHus : UserControl
    {
        public UC2AdministrereHus()
        {
            InitializeComponent();
        }

        private void bt_GetAllEstates_Click(object sender, EventArgs e)
        {
            dataGridView_AllEstates.DataSource = EstateControllerSingleton.Instance().GetGridEstateData().Estates.Local.ToBindingList();
        }

        private void bt_SaveEstates_Click(object sender, EventArgs e)
        {
            EstateControllerSingleton.Instance().UpdateGridEstateData();

        }

        private void bt_GetAllEstates_Click_1(object sender, EventArgs e)
        {
            dataGridView_AllEstates.DataSource = EstateControllerSingleton.Instance().GetGridEstateData().Estates.Local.ToBindingList();


        }
    }
}
