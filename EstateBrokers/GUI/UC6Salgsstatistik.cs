using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Controller;

namespace GUI
{
    public partial class UC6Salgsstatistik : UserControl
    {
        public UC6Salgsstatistik()
        {
            InitializeComponent();
        }

        private void bt_GetAllEstates_Click(object sender, EventArgs e)
        {
            
            //dataGridView_AllEstates.DataSource = DataGrid_EstateConSingleton.Instance().GetGridEstateData().Estates.Local.ToBindingList();
            //dataGridView_AllEstates.Columns[0].ReadOnly = true;
        }

        private void bt_SaveEstates_Click(object sender, EventArgs e)
        {
            //DataGrid_EstateConSingleton.Instance().UpdateGridEstateData();
        }
    }
}
