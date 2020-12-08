
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC6Salgsstatistik));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_Salesstatistics = new System.Windows.Forms.DataGridView();
            this.btn_PrintSalesstatistics = new System.Windows.Forms.Button();
            this.tableLayoutPanel_SetInformation = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePicker_From = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_To = new System.Windows.Forms.DateTimePicker();
            this.lbl_From = new System.Windows.Forms.Label();
            this.lbl_To = new System.Windows.Forms.Label();
            this.lbl_ChooseZipcode = new System.Windows.Forms.Label();
            this.btn_ShowSalesstatistics = new System.Windows.Forms.Button();
            this.txt_zipCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Salesstatistics)).BeginInit();
            this.tableLayoutPanel_SetInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 1080);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView_Salesstatistics
            // 
            this.dataGridView_Salesstatistics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Salesstatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Salesstatistics.Location = new System.Drawing.Point(205, 180);
            this.dataGridView_Salesstatistics.Name = "dataGridView_Salesstatistics";
            this.dataGridView_Salesstatistics.RowHeadersWidth = 51;
            this.dataGridView_Salesstatistics.Size = new System.Drawing.Size(1334, 633);
            this.dataGridView_Salesstatistics.TabIndex = 1;
            // 
            // btn_PrintSalesstatistics
            // 
            this.btn_PrintSalesstatistics.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_PrintSalesstatistics.Location = new System.Drawing.Point(3, 73);
            this.btn_PrintSalesstatistics.Name = "btn_PrintSalesstatistics";
            this.btn_PrintSalesstatistics.Size = new System.Drawing.Size(194, 29);
            this.btn_PrintSalesstatistics.TabIndex = 3;
            this.btn_PrintSalesstatistics.Text = "Print salgsstatistik";
            this.btn_PrintSalesstatistics.UseVisualStyleBackColor = true;
            this.btn_PrintSalesstatistics.Visible = false;
            this.btn_PrintSalesstatistics.Click += new System.EventHandler(this.btn_PrintSalesstatistics_Click);
            // 
            // tableLayoutPanel_SetInformation
            // 
            this.tableLayoutPanel_SetInformation.ColumnCount = 3;
            this.tableLayoutPanel_SetInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_SetInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel_SetInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel_SetInformation.Controls.Add(this.dateTimePicker_From, 0, 1);
            this.tableLayoutPanel_SetInformation.Controls.Add(this.btn_PrintSalesstatistics, 0, 2);
            this.tableLayoutPanel_SetInformation.Controls.Add(this.dateTimePicker_To, 1, 1);
            this.tableLayoutPanel_SetInformation.Controls.Add(this.lbl_From, 0, 0);
            this.tableLayoutPanel_SetInformation.Controls.Add(this.lbl_To, 1, 0);
            this.tableLayoutPanel_SetInformation.Controls.Add(this.lbl_ChooseZipcode, 2, 0);
            this.tableLayoutPanel_SetInformation.Controls.Add(this.btn_ShowSalesstatistics, 2, 2);
            this.tableLayoutPanel_SetInformation.Controls.Add(this.txt_zipCode, 2, 1);
            this.tableLayoutPanel_SetInformation.Location = new System.Drawing.Point(202, 69);
            this.tableLayoutPanel_SetInformation.Name = "tableLayoutPanel_SetInformation";
            this.tableLayoutPanel_SetInformation.RowCount = 3;
            this.tableLayoutPanel_SetInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_SetInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_SetInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_SetInformation.Size = new System.Drawing.Size(607, 105);
            this.tableLayoutPanel_SetInformation.TabIndex = 5;
            // 
            // dateTimePicker_From
            // 
            this.dateTimePicker_From.Location = new System.Drawing.Point(3, 38);
            this.dateTimePicker_From.Name = "dateTimePicker_From";
            this.dateTimePicker_From.Size = new System.Drawing.Size(194, 27);
            this.dateTimePicker_From.TabIndex = 0;
            // 
            // dateTimePicker_To
            // 
            this.dateTimePicker_To.Location = new System.Drawing.Point(205, 38);
            this.dateTimePicker_To.Name = "dateTimePicker_To";
            this.dateTimePicker_To.Size = new System.Drawing.Size(195, 27);
            this.dateTimePicker_To.TabIndex = 1;
            // 
            // lbl_From
            // 
            this.lbl_From.AutoSize = true;
            this.lbl_From.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_From.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_From.Location = new System.Drawing.Point(3, 15);
            this.lbl_From.Name = "lbl_From";
            this.lbl_From.Size = new System.Drawing.Size(196, 20);
            this.lbl_From.TabIndex = 2;
            this.lbl_From.Text = "Fra:";
            // 
            // lbl_To
            // 
            this.lbl_To.AutoSize = true;
            this.lbl_To.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_To.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_To.Location = new System.Drawing.Point(205, 15);
            this.lbl_To.Name = "lbl_To";
            this.lbl_To.Size = new System.Drawing.Size(196, 20);
            this.lbl_To.TabIndex = 3;
            this.lbl_To.Text = "Til:";
            // 
            // lbl_ChooseZipcode
            // 
            this.lbl_ChooseZipcode.AutoSize = true;
            this.lbl_ChooseZipcode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_ChooseZipcode.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ChooseZipcode.Location = new System.Drawing.Point(407, 15);
            this.lbl_ChooseZipcode.Name = "lbl_ChooseZipcode";
            this.lbl_ChooseZipcode.Size = new System.Drawing.Size(197, 20);
            this.lbl_ChooseZipcode.TabIndex = 5;
            this.lbl_ChooseZipcode.Text = "Postnummer:";
            // 
            // btn_ShowSalesstatistics
            // 
            this.btn_ShowSalesstatistics.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ShowSalesstatistics.Location = new System.Drawing.Point(407, 73);
            this.btn_ShowSalesstatistics.Name = "btn_ShowSalesstatistics";
            this.btn_ShowSalesstatistics.Size = new System.Drawing.Size(197, 29);
            this.btn_ShowSalesstatistics.TabIndex = 6;
            this.btn_ShowSalesstatistics.Text = "Vis Salgsstatistik";
            this.btn_ShowSalesstatistics.UseVisualStyleBackColor = true;
            this.btn_ShowSalesstatistics.Click += new System.EventHandler(this.btn_ShowSalesstatistics_Click);
            // 
            // txt_zipCode
            // 
            this.txt_zipCode.Location = new System.Drawing.Point(406, 36);
            this.txt_zipCode.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txt_zipCode.Name = "txt_zipCode";
            this.txt_zipCode.Size = new System.Drawing.Size(198, 27);
            this.txt_zipCode.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(707, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(429, 34);
            this.label5.TabIndex = 6;
            this.label5.Text = "Salgsstatistik oversigt";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UC6Salgsstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tableLayoutPanel_SetInformation);
            this.Controls.Add(this.dataGridView_Salesstatistics);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "UC6Salgsstatistik";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Salesstatistics)).EndInit();
            this.tableLayoutPanel_SetInformation.ResumeLayout(false);
            this.tableLayoutPanel_SetInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_Salesstatistics;
        private System.Windows.Forms.Button btn_PrintSalesstatistics;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_SetInformation;
        private System.Windows.Forms.DateTimePicker dateTimePicker_From;
        private System.Windows.Forms.DateTimePicker dateTimePicker_To;
        private System.Windows.Forms.Label lbl_From;
        private System.Windows.Forms.Label lbl_To;
        private System.Windows.Forms.Label lbl_ChooseZipcode;
        private System.Windows.Forms.Button btn_ShowSalesstatistics;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_zipCode;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
