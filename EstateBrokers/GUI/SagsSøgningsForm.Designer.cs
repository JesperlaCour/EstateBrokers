
namespace GUI
{
    partial class SagsSøgningsForm
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
            this.btn_Søg = new System.Windows.Forms.Button();
            this.btn_OpretNySag = new System.Windows.Forms.Button();
            this.btn_Luk = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1005, 475);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_Søg
            // 
            this.btn_Søg.Location = new System.Drawing.Point(144, 72);
            this.btn_Søg.Name = "btn_Søg";
            this.btn_Søg.Size = new System.Drawing.Size(94, 29);
            this.btn_Søg.TabIndex = 1;
            this.btn_Søg.Text = "Søg";
            this.btn_Søg.UseVisualStyleBackColor = true;
            // 
            // btn_OpretNySag
            // 
            this.btn_OpretNySag.Location = new System.Drawing.Point(257, 72);
            this.btn_OpretNySag.Name = "btn_OpretNySag";
            this.btn_OpretNySag.Size = new System.Drawing.Size(94, 29);
            this.btn_OpretNySag.TabIndex = 2;
            this.btn_OpretNySag.Text = "Opret ny sag";
            this.btn_OpretNySag.UseVisualStyleBackColor = true;
            // 
            // btn_Luk
            // 
            this.btn_Luk.Location = new System.Drawing.Point(923, 74);
            this.btn_Luk.Name = "btn_Luk";
            this.btn_Luk.Size = new System.Drawing.Size(94, 29);
            this.btn_Luk.TabIndex = 3;
            this.btn_Luk.Text = "Luk";
            this.btn_Luk.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(428, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sags søgning";
            // 
            // SagsSøgningsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 597);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Luk);
            this.Controls.Add(this.btn_OpretNySag);
            this.Controls.Add(this.btn_Søg);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SagsSøgningsForm";
            this.Text = "SagsSøgningsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Søg;
        private System.Windows.Forms.Button btn_OpretNySag;
        private System.Windows.Forms.Button btn_Luk;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}