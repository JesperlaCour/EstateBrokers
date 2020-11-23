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
    public partial class UC1AdministrereKunde : UserControl
    {
        public UC1AdministrereKunde()
        {
            InitializeComponent();
        }

        private void bt_GetAllCustAdmin_Click(object sender, EventArgs e)
        {
            dataGridView_CustAdmin.DataSource = CustomerControllerSingleton.Instance().GetGridCustomerData().Customers.Local.ToBindingList();
        }

        private void bt_saveCustAdmin_Click(object sender, EventArgs e)
        {
            CustomerControllerSingleton.Instance().SaveDBContext();
        }
    }
}
