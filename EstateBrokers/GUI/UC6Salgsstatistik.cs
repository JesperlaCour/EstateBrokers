using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Controller;
using System.IO;

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

        }

        private void btn_PrintSalesstatistics_Click(object sender, EventArgs e)
        {

            TextWriter writer = new StreamWriter(@"C:\Users\Andreas Brosbøl\Documents\tekst.txt");

            for (int i = 0; i < dataGridView_Salesstatistics.Rows.Count-1; i++)
            {

                for (int j = 0; j < dataGridView_Salesstatistics.Columns.Count; j++)
                {

                    writer.Write("\t" + dataGridView_Salesstatistics.Rows[i].Cells[j].Value?.ToString() + "\t" + "|");

                }
                writer.WriteLine("");
                writer.WriteLine("------------------------------------------");

            }
            writer.Close();
            MessageBox.Show("Salgsstatistik gemt");




        }
    }
}
