
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ShowDistribution)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_PickDate
            // 
            this.cbo_PickDate.FormattingEnabled = true;
            this.cbo_PickDate.Location = new System.Drawing.Point(26, 75);
            this.cbo_PickDate.Name = "cbo_PickDate";
            this.cbo_PickDate.Size = new System.Drawing.Size(151, 28);
            this.cbo_PickDate.TabIndex = 0;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Date.Location = new System.Drawing.Point(26, 46);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(47, 16);
            this.lbl_Date.TabIndex = 1;
            this.lbl_Date.Text = "Dato:";
            // 
            // dataGridView_ShowDistribution
            // 
            this.dataGridView_ShowDistribution.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ShowDistribution.Location = new System.Drawing.Point(26, 119);
            this.dataGridView_ShowDistribution.Name = "dataGridView_ShowDistribution";
            this.dataGridView_ShowDistribution.RowHeadersWidth = 51;
            this.dataGridView_ShowDistribution.RowTemplate.Height = 29;
            this.dataGridView_ShowDistribution.Size = new System.Drawing.Size(994, 483);
            this.dataGridView_ShowDistribution.TabIndex = 2;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(926, 84);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(94, 29);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Gem";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // lbl_Heading
            // 
            this.lbl_Heading.AutoSize = true;
            this.lbl_Heading.Font = new System.Drawing.Font("Courier New", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Heading.Location = new System.Drawing.Point(292, 9);
            this.lbl_Heading.Name = "lbl_Heading";
            this.lbl_Heading.Size = new System.Drawing.Size(501, 34);
            this.lbl_Heading.TabIndex = 4;
            this.lbl_Heading.Text = "Overblik over åbenthus dage";
            // 
            // OpenhouseOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 614);
            this.Controls.Add(this.lbl_Heading);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.dataGridView_ShowDistribution);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.cbo_PickDate);
            this.Name = "OpenhouseOverview";
            this.Text = "OpenhouseOverview";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ShowDistribution)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_PickDate;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.DataGridView dataGridView_ShowDistribution;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lbl_Heading;
    }
}