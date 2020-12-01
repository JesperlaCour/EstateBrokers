
namespace GUI
{
    partial class UC6Salgsstatistik
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox_ShowSalesstatistics = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel_ChooseInformation = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_From = new System.Windows.Forms.Label();
            this.lbl_To = new System.Windows.Forms.Label();
            this.lbl_ChooseZipcode = new System.Windows.Forms.Label();
            this.dateTimePicker_From = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_To = new System.Windows.Forms.DateTimePicker();
            this.cbo_Zipcode = new System.Windows.Forms.ComboBox();
            this.btn_ShowSalesstatistics = new System.Windows.Forms.Button();
            this.button_PrintSalesstatistics = new System.Windows.Forms.Button();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.tableLayoutPanel_ChooseInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 1080);
            this.panel1.TabIndex = 0;
            // 
            // richTextBox_ShowSalesstatistics
            // 
            this.richTextBox_ShowSalesstatistics.Location = new System.Drawing.Point(202, 227);
            this.richTextBox_ShowSalesstatistics.Name = "richTextBox_ShowSalesstatistics";
            this.richTextBox_ShowSalesstatistics.Size = new System.Drawing.Size(1480, 725);
            this.richTextBox_ShowSalesstatistics.TabIndex = 1;
            this.richTextBox_ShowSalesstatistics.Text = "";
            // 
            // tableLayoutPanel_ChooseInformation
            // 
            this.tableLayoutPanel_ChooseInformation.ColumnCount = 3;
            this.tableLayoutPanel_ChooseInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_ChooseInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel_ChooseInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel_ChooseInformation.Controls.Add(this.lbl_To, 1, 0);
            this.tableLayoutPanel_ChooseInformation.Controls.Add(this.lbl_ChooseZipcode, 2, 0);
            this.tableLayoutPanel_ChooseInformation.Controls.Add(this.lbl_From, 0, 0);
            this.tableLayoutPanel_ChooseInformation.Controls.Add(this.dateTimePicker_From, 0, 1);
            this.tableLayoutPanel_ChooseInformation.Controls.Add(this.dateTimePicker_To, 1, 1);
            this.tableLayoutPanel_ChooseInformation.Controls.Add(this.cbo_Zipcode, 2, 1);
            this.tableLayoutPanel_ChooseInformation.Controls.Add(this.btn_ShowSalesstatistics, 2, 2);
            this.tableLayoutPanel_ChooseInformation.Controls.Add(this.button_PrintSalesstatistics, 0, 2);
            this.tableLayoutPanel_ChooseInformation.Location = new System.Drawing.Point(202, 99);
            this.tableLayoutPanel_ChooseInformation.Name = "tableLayoutPanel_ChooseInformation";
            this.tableLayoutPanel_ChooseInformation.RowCount = 3;
            this.tableLayoutPanel_ChooseInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_ChooseInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_ChooseInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_ChooseInformation.Size = new System.Drawing.Size(619, 122);
            this.tableLayoutPanel_ChooseInformation.TabIndex = 2;
            // 
            // lbl_From
            // 
            this.lbl_From.AutoSize = true;
            this.lbl_From.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_From.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_From.Location = new System.Drawing.Point(3, 20);
            this.lbl_From.Name = "lbl_From";
            this.lbl_From.Size = new System.Drawing.Size(200, 20);
            this.lbl_From.TabIndex = 0;
            this.lbl_From.Text = "Fra:";
            // 
            // lbl_To
            // 
            this.lbl_To.AutoSize = true;
            this.lbl_To.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_To.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_To.Location = new System.Drawing.Point(209, 20);
            this.lbl_To.Name = "lbl_To";
            this.lbl_To.Size = new System.Drawing.Size(200, 20);
            this.lbl_To.TabIndex = 1;
            this.lbl_To.Text = "Til:";
            // 
            // lbl_ChooseZipcode
            // 
            this.lbl_ChooseZipcode.AutoSize = true;
            this.lbl_ChooseZipcode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_ChooseZipcode.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ChooseZipcode.Location = new System.Drawing.Point(415, 20);
            this.lbl_ChooseZipcode.Name = "lbl_ChooseZipcode";
            this.lbl_ChooseZipcode.Size = new System.Drawing.Size(201, 20);
            this.lbl_ChooseZipcode.TabIndex = 2;
            this.lbl_ChooseZipcode.Text = "Vælg postnummer:";
            // 
            // dateTimePicker_From
            // 
            this.dateTimePicker_From.Location = new System.Drawing.Point(3, 43);
            this.dateTimePicker_From.Name = "dateTimePicker_From";
            this.dateTimePicker_From.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker_From.TabIndex = 3;
            // 
            // dateTimePicker_To
            // 
            this.dateTimePicker_To.Location = new System.Drawing.Point(209, 43);
            this.dateTimePicker_To.Name = "dateTimePicker_To";
            this.dateTimePicker_To.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker_To.TabIndex = 4;
            // 
            // cbo_Zipcode
            // 
            this.cbo_Zipcode.FormattingEnabled = true;
            this.cbo_Zipcode.Location = new System.Drawing.Point(415, 43);
            this.cbo_Zipcode.Name = "cbo_Zipcode";
            this.cbo_Zipcode.Size = new System.Drawing.Size(201, 28);
            this.cbo_Zipcode.TabIndex = 5;
            // 
            // btn_ShowSalesstatistics
            // 
            this.btn_ShowSalesstatistics.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ShowSalesstatistics.Location = new System.Drawing.Point(415, 83);
            this.btn_ShowSalesstatistics.Name = "btn_ShowSalesstatistics";
            this.btn_ShowSalesstatistics.Size = new System.Drawing.Size(201, 36);
            this.btn_ShowSalesstatistics.TabIndex = 6;
            this.btn_ShowSalesstatistics.Text = "Vis salgsstatistik";
            this.btn_ShowSalesstatistics.UseVisualStyleBackColor = true;
            // 
            // button_PrintSalesstatistics
            // 
            this.button_PrintSalesstatistics.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_PrintSalesstatistics.Location = new System.Drawing.Point(3, 83);
            this.button_PrintSalesstatistics.Name = "button_PrintSalesstatistics";
            this.button_PrintSalesstatistics.Size = new System.Drawing.Size(200, 36);
            this.button_PrintSalesstatistics.TabIndex = 7;
            this.button_PrintSalesstatistics.Text = "Print salgsstatisitk";
            this.button_PrintSalesstatistics.UseVisualStyleBackColor = true;
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Courier New", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Header.Location = new System.Drawing.Point(779, 15);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(429, 34);
            this.lbl_Header.TabIndex = 3;
            this.lbl_Header.Text = "Salgsstatistik oversigt";
            // 
            // UC6Salgsstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_Header);
            this.Controls.Add(this.tableLayoutPanel_ChooseInformation);
            this.Controls.Add(this.richTextBox_ShowSalesstatistics);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "UC6Salgsstatistik";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.tableLayoutPanel_ChooseInformation.ResumeLayout(false);
            this.tableLayoutPanel_ChooseInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox_ShowSalesstatistics;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_ChooseInformation;
        private System.Windows.Forms.Label lbl_To;
        private System.Windows.Forms.Label lbl_ChooseZipcode;
        private System.Windows.Forms.Label lbl_From;
        private System.Windows.Forms.DateTimePicker dateTimePicker_From;
        private System.Windows.Forms.DateTimePicker dateTimePicker_To;
        private System.Windows.Forms.ComboBox cbo_Zipcode;
        private System.Windows.Forms.Button btn_ShowSalesstatistics;
        private System.Windows.Forms.Button button_PrintSalesstatistics;
        private System.Windows.Forms.Label lbl_Header;
    }
}
