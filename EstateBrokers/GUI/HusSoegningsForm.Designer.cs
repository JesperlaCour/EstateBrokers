
namespace GUI
{
    partial class HusSoegningsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbt_address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_soeg = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_OpretNytHUs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 176);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1656, 760);
            this.dataGridView1.TabIndex = 0;
            // 
            // tbt_address
            // 
            this.tbt_address.Location = new System.Drawing.Point(21, 118);
            this.tbt_address.Margin = new System.Windows.Forms.Padding(5);
            this.tbt_address.Name = "tbt_address";
            this.tbt_address.Size = new System.Drawing.Size(201, 39);
            this.tbt_address.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adresse:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(696, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 51);
            this.label3.TabIndex = 5;
            this.label3.Text = "HusSøgning";
            // 
            // btn_soeg
            // 
            this.btn_soeg.Location = new System.Drawing.Point(236, 115);
            this.btn_soeg.Margin = new System.Windows.Forms.Padding(5);
            this.btn_soeg.Name = "btn_soeg";
            this.btn_soeg.Size = new System.Drawing.Size(153, 46);
            this.btn_soeg.TabIndex = 6;
            this.btn_soeg.Text = "Søg";
            this.btn_soeg.UseVisualStyleBackColor = true;
            this.btn_soeg.Click += new System.EventHandler(this.btn_soeg_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(1523, 114);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(153, 46);
            this.btn_Close.TabIndex = 7;
            this.btn_Close.Text = "Luk";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_OpretNytHUs
            // 
            this.btn_OpretNytHUs.Location = new System.Drawing.Point(414, 115);
            this.btn_OpretNytHUs.Margin = new System.Windows.Forms.Padding(5);
            this.btn_OpretNytHUs.Name = "btn_OpretNytHUs";
            this.btn_OpretNytHUs.Size = new System.Drawing.Size(185, 46);
            this.btn_OpretNytHUs.TabIndex = 8;
            this.btn_OpretNytHUs.Text = "Opret nyt hus";
            this.btn_OpretNytHUs.UseVisualStyleBackColor = true;
            this.btn_OpretNytHUs.Click += new System.EventHandler(this.button3_Click);
            // 
            // HusSoegningsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1710, 955);
            this.Controls.Add(this.btn_OpretNytHUs);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_soeg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbt_address);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "HusSoegningsForm";
            this.Text = "OpretHusForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbt_address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_soeg;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_OpretNytHUs;
    }
}