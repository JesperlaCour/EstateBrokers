﻿
namespace GUI
{
    partial class UC4UdbudsprisBeregner
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC4UdbudsprisBeregner));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Txt_sqm = new System.Windows.Forms.TextBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cbo_houseType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Trackbar_condition = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Btn_CreateNewCase = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_remodelYear = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_listingPrice = new System.Windows.Forms.Label();
            this.Txt_zipCode = new System.Windows.Forms.TextBox();
            this.Txt_AntalBade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView_priceHistory = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trackbar_condition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_priceHistory)).BeginInit();
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
            // Txt_sqm
            // 
            this.Txt_sqm.Location = new System.Drawing.Point(765, 205);
            this.Txt_sqm.Name = "Txt_sqm";
            this.Txt_sqm.Size = new System.Drawing.Size(78, 27);
            this.Txt_sqm.TabIndex = 1;
            // 
            // btn_calculate
            // 
            this.btn_calculate.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_calculate.Location = new System.Drawing.Point(1418, 207);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(94, 29);
            this.btn_calculate.TabIndex = 2;
            this.btn_calculate.Text = "Beregn";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(202, 565);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(829, 309);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(779, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kvm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(671, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Postnummer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1241, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Antal badeværelser";
            // 
            // Cbo_houseType
            // 
            this.Cbo_houseType.FormattingEnabled = true;
            this.Cbo_houseType.Location = new System.Drawing.Point(544, 204);
            this.Cbo_houseType.Name = "Cbo_houseType";
            this.Cbo_houseType.Size = new System.Drawing.Size(121, 28);
            this.Cbo_houseType.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(571, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "HusType";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(1099, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Renoverings år";
            // 
            // Trackbar_condition
            // 
            this.Trackbar_condition.LargeChange = 1;
            this.Trackbar_condition.Location = new System.Drawing.Point(848, 205);
            this.Trackbar_condition.Maximum = 5;
            this.Trackbar_condition.Minimum = -5;
            this.Trackbar_condition.Name = "Trackbar_condition";
            this.Trackbar_condition.Size = new System.Drawing.Size(239, 56);
            this.Trackbar_condition.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(942, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Stand";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(681, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(471, 53);
            this.label9.TabIndex = 19;
            this.label9.Text = "Udbudspris i kr.";
            // 
            // Btn_CreateNewCase
            // 
            this.Btn_CreateNewCase.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_CreateNewCase.Location = new System.Drawing.Point(942, 411);
            this.Btn_CreateNewCase.Name = "Btn_CreateNewCase";
            this.Btn_CreateNewCase.Size = new System.Drawing.Size(197, 33);
            this.Btn_CreateNewCase.TabIndex = 22;
            this.Btn_CreateNewCase.Text = "Opret ny sag";
            this.Btn_CreateNewCase.UseVisualStyleBackColor = true;
            this.Btn_CreateNewCase.Click += new System.EventHandler(this.Btn_CreateNewCase_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Courier New", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(736, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(641, 68);
            this.label11.TabIndex = 23;
            this.label11.Text = "Beregn udbudspris";
            // 
            // txt_remodelYear
            // 
            this.txt_remodelYear.Location = new System.Drawing.Point(1099, 205);
            this.txt_remodelYear.Name = "txt_remodelYear";
            this.txt_remodelYear.Size = new System.Drawing.Size(134, 27);
            this.txt_remodelYear.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Courier New", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(845, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(415, 53);
            this.label12.TabIndex = 25;
            this.label12.Text = "Husoplysninger";
            // 
            // lbl_listingPrice
            // 
            this.lbl_listingPrice.AutoSize = true;
            this.lbl_listingPrice.Font = new System.Drawing.Font("Courier New", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_listingPrice.Location = new System.Drawing.Point(1182, 317);
            this.lbl_listingPrice.Name = "lbl_listingPrice";
            this.lbl_listingPrice.Size = new System.Drawing.Size(238, 41);
            this.lbl_listingPrice.TabIndex = 26;
            this.lbl_listingPrice.Text = "Udbudspris";
            // 
            // Txt_zipCode
            // 
            this.Txt_zipCode.Location = new System.Drawing.Point(671, 205);
            this.Txt_zipCode.Name = "Txt_zipCode";
            this.Txt_zipCode.Size = new System.Drawing.Size(87, 27);
            this.Txt_zipCode.TabIndex = 27;
            this.toolTip1.SetToolTip(this.Txt_zipCode, "Indtast postnummer for huset \r\nder skal beregnes udbudspris på");
            // 
            // Txt_AntalBade
            // 
            this.Txt_AntalBade.Location = new System.Drawing.Point(1241, 205);
            this.Txt_AntalBade.Name = "Txt_AntalBade";
            this.Txt_AntalBade.Size = new System.Drawing.Size(170, 27);
            this.Txt_AntalBade.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 527);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Huse i området";
            // 
            // dataGridView_priceHistory
            // 
            this.dataGridView_priceHistory.AllowUserToAddRows = false;
            this.dataGridView_priceHistory.AllowUserToDeleteRows = false;
            this.dataGridView_priceHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_priceHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_priceHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_priceHistory.Location = new System.Drawing.Point(1075, 565);
            this.dataGridView_priceHistory.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dataGridView_priceHistory.Name = "dataGridView_priceHistory";
            this.dataGridView_priceHistory.ReadOnly = true;
            this.dataGridView_priceHistory.RowHeadersWidth = 82;
            this.dataGridView_priceHistory.Size = new System.Drawing.Size(775, 309);
            this.dataGridView_priceHistory.TabIndex = 30;
            this.dataGridView_priceHistory.Text = "dataGridView2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1075, 527);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 20);
            this.label10.TabIndex = 31;
            this.label10.Text = "Prishistorik";
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
            // UC4UdbudsprisBeregner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView_priceHistory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_AntalBade);
            this.Controls.Add(this.Txt_zipCode);
            this.Controls.Add(this.lbl_listingPrice);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_remodelYear);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Btn_CreateNewCase);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Trackbar_condition);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cbo_houseType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.Txt_sqm);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "UC4UdbudsprisBeregner";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trackbar_condition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_priceHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Txt_sqm;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cbo_houseType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar Trackbar_condition;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Btn_CreateNewCase;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_remodelYear;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_listingPrice;
        private System.Windows.Forms.TextBox Txt_zipCode;
        private System.Windows.Forms.TextBox Txt_AntalBade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView_priceHistory;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
