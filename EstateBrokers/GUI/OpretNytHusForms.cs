using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Controller;
using Model.Models;

namespace GUI
{
    public partial class OpretNytHusForms : Form
    {
        public OpretNytHusForms()
        {
            InitializeComponent();
            UpdateDropdown_HouseTypes();
        }

       
        private void UpdateDropdown_HouseTypes()
        {
            cbo_HouseType.DataSource = EstateControllerSingleton.Instance().GetHouseTypes();
            cbo_HouseType.DisplayMember = "Type";
            cbo_HouseType.ValueMember = "TypeId";
        }

        private void btn_CreateNewHouse_Click(object sender, EventArgs e)
        {
            try
            {
                EstateControllerSingleton.Instance().CreateEstate(new Estate(
                    txt_Adresse.Text,
                    Convert.ToInt32(txt_Byggelseaar.Text),
                    Convert.ToInt32(txt_renoveringsaar.Text),
                    trackBar1.Value,
                    Convert.ToInt32(txt_Areal.Text),
                    Convert.ToInt32(txt_AntalRooms.Text),
                    Convert.ToInt32(txt_floors.Text),
                    Convert.ToBoolean(cbo_Have.Text),
                    Convert.ToInt32(txt_zipCode.Text),
                    Convert.ToInt32(cbo_HouseType.SelectedValue)
                    ));
                MessageBox.Show("Hus er nu oprettet i systemet");
            }
            catch (Exception)
            {
                MessageBox.Show("Fejl i oprettelse af hus. Prøv igen");
            }
            

        }
    }
}
