
namespace GUI
{
    partial class OpenhouseOverview
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbo_PickDate = new System.Windows.Forms.ComboBox();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.dataGridView_ShowDistribution = new System.Windows.Forms.DataGridView();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lbl_Heading = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ShowDistribution)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbo_PickDate
            // 
            this.cbo_PickDate.FormatString = "d";
            this.cbo_PickDate.FormattingEnabled = true;
            this.cbo_PickDate.Location = new System.Drawing.Point(42, 120);
            this.cbo_PickDate.Margin = new System.Windows.Forms.Padding(5);
            this.cbo_PickDate.Name = "cbo_PickDate";
            this.cbo_PickDate.Size = new System.Drawing.Size(243, 40);
            this.cbo_PickDate.TabIndex = 0;
            this.cbo_PickDate.SelectedIndexChanged += new System.EventHandler(this.cbo_PickDate_SelectedIndexChanged);
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Date.Location = new System.Drawing.Point(42, 74);
            this.lbl_Date.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(75, 23);
            this.lbl_Date.TabIndex = 1;
            this.lbl_Date.Text = "Dato:";
            // 
            // dataGridView_ShowDistribution
            // 
            this.dataGridView_ShowDistribution.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ShowDistribution.Location = new System.Drawing.Point(42, 190);
            this.dataGridView_ShowDistribution.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView_ShowDistribution.Name = "dataGridView_ShowDistribution";
            this.dataGridView_ShowDistribution.RowHeadersWidth = 51;
            this.dataGridView_ShowDistribution.Size = new System.Drawing.Size(1613, 614);
            this.dataGridView_ShowDistribution.TabIndex = 2;
            this.dataGridView_ShowDistribution.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ShowDistribution_CellContentClick);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(1392, 134);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(266, 46);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Gem ændringer";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_Heading
            // 
            this.lbl_Heading.AutoSize = true;
            this.lbl_Heading.Font = new System.Drawing.Font("Courier New", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Heading.Location = new System.Drawing.Point(474, 14);
            this.lbl_Heading.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Heading.Name = "lbl_Heading";
            this.lbl_Heading.Size = new System.Drawing.Size(807, 55);
            this.lbl_Heading.TabIndex = 4;
            this.lbl_Heading.Text = "Overblik over åbenthus dage";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_address, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_price, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(42, 853);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1613, 112);
            this.tableLayoutPanel1.TabIndex = 5;
            this.tableLayoutPanel1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adresse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pris";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(3, 56);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(78, 32);
            this.lbl_address.TabIndex = 2;
            this.lbl_address.Text = "label3";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(406, 56);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(78, 32);
            this.lbl_price.TabIndex = 3;
            this.lbl_price.Text = "label3";
            // 
            // OpenhouseOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1677, 986);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lbl_Heading);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.dataGridView_ShowDistribution);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.cbo_PickDate);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "OpenhouseOverview";
            this.Text = "OpenhouseOverview";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ShowDistribution)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_PickDate;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.DataGridView dataGridView_ShowDistribution;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lbl_Heading;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_price;
    }
}