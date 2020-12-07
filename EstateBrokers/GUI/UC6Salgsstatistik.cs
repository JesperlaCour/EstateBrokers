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

        private void btn_ShowSalesstatistics_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView_Salesstatistics.DataSource = SalesStatisticControllerSingleton.Instance()
                .GetSoldHouses(Convert.ToInt32(txt_zipCode.Text), dateTimePicker_From.Value, dateTimePicker_To.Value);

            }
            catch (Exception)
            {
                dataGridView_Salesstatistics.DataSource = SalesStatisticControllerSingleton.Instance()
               .GetSoldHouses(-1, dateTimePicker_From.Value, dateTimePicker_To.Value);

            }

            btn_PrintSalesstatistics.Visible = true;


        }

        private void btn_PrintSalesstatistics_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Gem salgsstatistik";
            saveDialog.InitialDirectory = @"C:\";
            saveDialog.FileName = "SalesStatistic " + DateTime.Now.ToShortDateString();
            saveDialog.CheckFileExists = false;
            saveDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveDialog.CheckPathExists = true;
            saveDialog.OverwritePrompt = true;
            saveDialog.RestoreDirectory = true;
            saveDialog.DefaultExt = "txt";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                SalesStatisticControllerSingleton.Instance().PrintSalesStatistic(saveDialog.FileName);
                MessageBox.Show("Salgsstatistik gemt");
            }
            else
            {
                MessageBox.Show("Annulleret - ikke gemt");





            }

        }
    }
}
