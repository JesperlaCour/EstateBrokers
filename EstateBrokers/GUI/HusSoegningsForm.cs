using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Controller;
using Microsoft.EntityFrameworkCore;
namespace GUI
{
    public partial class HusSoegningsForm : Form
    {
        public HusSoegningsForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpretNytHusForms opnhf = new OpretNytHusForms();
            opnhf.ShowDialog();
        }

        private void btn_soeg_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = EstateControllerSingleton.Instance().GetGridEstateData(tbt_address.Text).Estates.Local.ToBindingList();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Columns["EstateId"].HeaderText = "EjendomsId";
            dataGridView1.Columns["Address"].HeaderText = "Adresse";
            dataGridView1.Columns["BuildYear"].HeaderText = "HusetsByggelsesår";
            dataGridView1.Columns["RemodelYear"].HeaderText = "RenoveringsÅr";
            dataGridView1.Columns["Condition"].HeaderText = "Stand";
            dataGridView1.Columns["Areal"].HeaderText = "Areal";
            dataGridView1.Columns["Rooms"].HeaderText = "Rum";
            dataGridView1.Columns["Floors"].HeaderText = "Etager";
            dataGridView1.Columns["Garden"].HeaderText = "Have";
            dataGridView1.Columns["ZipCode"].HeaderText = "Postnummer";
            dataGridView1.Columns["TypeId"].HeaderText = "TypeId";
            dataGridView1.Columns["Type"].HeaderText = "Type";
            dataGridView1.Columns["ZipCodeNavigation"].HeaderText = "PostnummerNavigation";
            dataGridView1.Columns["CaseOrders"].HeaderText = "SagsOrdre";
            dataGridView1.Columns["PriceHistories"].HeaderText = "PrisHistorik";


            this.dataGridView1.Columns["ZipCodeNavigation"].Visible = false;

        }

        private void btn_chooseHouse_Click(object sender, EventArgs e)
        {
            OpretSagForm.estateID = dataGridView1.SelectedCells[0].Value.ToString();
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
