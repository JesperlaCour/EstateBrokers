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

        

        private void bt_SaveEstates_Click(object sender, EventArgs e)
        {
            EstateControllerSingleton.Instance().SaveDBContext();

        }

        private void bt_GetAllEstates_Click(object sender, EventArgs e)
        {
            dataGridView_AllEstates.DataSource = EstateControllerSingleton.Instance().GetGridEstateData("").Estates.Local.ToBindingList();

            dataGridView_AllEstates.Columns["EstateId"].HeaderText = "EjendomsId";
            dataGridView_AllEstates.Columns["Address"].HeaderText = "Adresse";
            dataGridView_AllEstates.Columns["BuildYear"].HeaderText = "HusetsByggelsesår";
            dataGridView_AllEstates.Columns["RemodelYear"].HeaderText = "RenoveringsÅr";
            dataGridView_AllEstates.Columns["Condition"].HeaderText = "Stand";
            dataGridView_AllEstates.Columns["Areal"].HeaderText = "Areal";
            dataGridView_AllEstates.Columns["Rooms"].HeaderText = "Rum";
            dataGridView_AllEstates.Columns["Floors"].HeaderText = "Etager";
            dataGridView_AllEstates.Columns["Garden"].HeaderText = "Have";
            dataGridView_AllEstates.Columns["ZipCode"].HeaderText = "Postnummer";
            dataGridView_AllEstates.Columns["TypeId"].HeaderText = "TypeId";
            dataGridView_AllEstates.Columns["Type"].HeaderText = "Type";
            dataGridView_AllEstates.Columns["ZipCodeNavigation"].HeaderText = "PostnummerNavigation";
            dataGridView_AllEstates.Columns["CaseOrders"].HeaderText = "SagsOrdre";
            dataGridView_AllEstates.Columns["PriceHistories"].HeaderText = "PrisHistorik";


            


        }

        
    }
}
