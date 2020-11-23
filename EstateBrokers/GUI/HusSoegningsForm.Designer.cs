
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_soeg = new System.Windows.Forms.Button();
            this.btn_Choose = new System.Windows.Forms.Button();
            this.btn_OpretNytHUs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1019, 475);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adresse:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(428, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "HusSøgning";
            // 
            // btn_soeg
            // 
            this.btn_soeg.Location = new System.Drawing.Point(145, 72);
            this.btn_soeg.Name = "btn_soeg";
            this.btn_soeg.Size = new System.Drawing.Size(94, 29);
            this.btn_soeg.TabIndex = 6;
            this.btn_soeg.Text = "Søg";
            this.btn_soeg.UseVisualStyleBackColor = true;
            this.btn_soeg.Click += new System.EventHandler(this.btn_soeg_Click);
            // 
            // btn_Choose
            // 
            this.btn_Choose.Location = new System.Drawing.Point(923, 74);
            this.btn_Choose.Name = "btn_Choose";
            this.btn_Choose.Size = new System.Drawing.Size(94, 29);
            this.btn_Choose.TabIndex = 7;
            this.btn_Choose.Text = "Vælg";
            this.btn_Choose.UseVisualStyleBackColor = true;
            // 
            // btn_OpretNytHUs
            // 
            this.btn_OpretNytHUs.Location = new System.Drawing.Point(255, 72);
            this.btn_OpretNytHUs.Name = "btn_OpretNytHUs";
            this.btn_OpretNytHUs.Size = new System.Drawing.Size(114, 29);
            this.btn_OpretNytHUs.TabIndex = 8;
            this.btn_OpretNytHUs.Text = "Opret nyt hus";
            this.btn_OpretNytHUs.UseVisualStyleBackColor = true;
            this.btn_OpretNytHUs.Click += new System.EventHandler(this.button3_Click);
            // 
            // HusSoegningsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 597);
            this.Controls.Add(this.btn_OpretNytHUs);
            this.Controls.Add(this.btn_Choose);
            this.Controls.Add(this.btn_soeg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HusSoegningsForm";
            this.Text = "OpretHusForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_soeg;
        private System.Windows.Forms.Button btn_Choose;
        private System.Windows.Forms.Button btn_OpretNytHUs;
    }
}