
namespace GUI
{
    partial class KundeSøgningsForms
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
            this.btn_soeg = new System.Windows.Forms.Button();
            this.btn_ChooseKunde = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_OpretNyKunde = new System.Windows.Forms.Button();
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
            this.dataGridView1.Size = new System.Drawing.Size(1005, 475);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_soeg
            // 
            this.btn_soeg.Location = new System.Drawing.Point(144, 72);
            this.btn_soeg.Name = "btn_soeg";
            this.btn_soeg.Size = new System.Drawing.Size(94, 29);
            this.btn_soeg.TabIndex = 1;
            this.btn_soeg.Text = "Søg";
            this.btn_soeg.UseVisualStyleBackColor = true;
            this.btn_soeg.Click += new System.EventHandler(this.btn_soeg_Click);
            // 
            // btn_ChooseKunde
            // 
            this.btn_ChooseKunde.Location = new System.Drawing.Point(923, 74);
            this.btn_ChooseKunde.Name = "btn_ChooseKunde";
            this.btn_ChooseKunde.Size = new System.Drawing.Size(94, 29);
            this.btn_ChooseKunde.TabIndex = 2;
            this.btn_ChooseKunde.Text = "Vælg kunde";
            this.btn_ChooseKunde.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Adresse:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(428, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kundesøgning";
            // 
            // btn_OpretNyKunde
            // 
            this.btn_OpretNyKunde.Location = new System.Drawing.Point(257, 72);
            this.btn_OpretNyKunde.Name = "btn_OpretNyKunde";
            this.btn_OpretNyKunde.Size = new System.Drawing.Size(127, 29);
            this.btn_OpretNyKunde.TabIndex = 8;
            this.btn_OpretNyKunde.Text = "Opret ny kunde";
            this.btn_OpretNyKunde.UseVisualStyleBackColor = true;
            this.btn_OpretNyKunde.Click += new System.EventHandler(this.button3_Click);
            // 
            // KundeSøgningsForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 597);
            this.Controls.Add(this.btn_OpretNyKunde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_ChooseKunde);
            this.Controls.Add(this.btn_soeg);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KundeSøgningsForms";
            this.Text = "OpretKundeForms";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_soeg;
        private System.Windows.Forms.Button btn_ChooseKunde;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_OpretNyKunde;
    }
}