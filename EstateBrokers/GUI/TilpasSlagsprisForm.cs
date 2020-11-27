using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using Controller;
using Model.Models;

namespace GUI
{
    public partial class TilpasSlagsprisForm : Form
    {
        public int? EstateId { get; set; }
        public int PriceTypeId { get; set; }

        public TilpasSlagsprisForm(int? estateId, int priceTypeId)
        {
            InitializeComponent();
            this.EstateId = estateId;
            this.PriceTypeId = priceTypeId;
        }

        public TilpasSlagsprisForm()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            CaseOrderControllerSingleton.Instance().CreateNewPriceHistory(new PriceHistory(Convert.ToDecimal(txt_Price.Text), EstateId, PriceTypeId));
            DialogResult = DialogResult.OK;
            MessageBox.Show("Prisændring gemt");
            Close();
        }
    }
}
