
namespace GUI
{
    partial class UC0AdministrereMægler
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
            this.btn_HentAlle = new System.Windows.Forms.Button();
            this.btn_Gem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_TypeHentAlle = new System.Windows.Forms.Button();
            this.btn_TypeGem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            // btn_HentAlle
            // 
            this.btn_HentAlle.Location = new System.Drawing.Point(202, 92);
            this.btn_HentAlle.Name = "btn_HentAlle";
            this.btn_HentAlle.Size = new System.Drawing.Size(108, 43);
            this.btn_HentAlle.TabIndex = 1;
            this.btn_HentAlle.Text = "Hent alle";
            this.btn_HentAlle.UseVisualStyleBackColor = true;
            // 
            // btn_Gem
            // 
            this.btn_Gem.Location = new System.Drawing.Point(316, 92);
            this.btn_Gem.Name = "btn_Gem";
            this.btn_Gem.Size = new System.Drawing.Size(108, 43);
            this.btn_Gem.TabIndex = 2;
            this.btn_Gem.Text = "Gem";
            this.btn_Gem.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(202, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(565, 716);
            this.dataGridView1.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(1040, 141);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(565, 716);
            this.dataGridView2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(419, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mæglere";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1273, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Type";
            // 
            // btn_TypeHentAlle
            // 
            this.btn_TypeHentAlle.Location = new System.Drawing.Point(1040, 92);
            this.btn_TypeHentAlle.Name = "btn_TypeHentAlle";
            this.btn_TypeHentAlle.Size = new System.Drawing.Size(108, 43);
            this.btn_TypeHentAlle.TabIndex = 7;
            this.btn_TypeHentAlle.Text = "Hent alle";
            this.btn_TypeHentAlle.UseVisualStyleBackColor = true;
            // 
            // btn_TypeGem
            // 
            this.btn_TypeGem.Location = new System.Drawing.Point(1154, 92);
            this.btn_TypeGem.Name = "btn_TypeGem";
            this.btn_TypeGem.Size = new System.Drawing.Size(108, 43);
            this.btn_TypeGem.TabIndex = 8;
            this.btn_TypeGem.Text = "Gem";
            this.btn_TypeGem.UseVisualStyleBackColor = true;
            // 
            // UC0AdministrereMægler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_TypeGem);
            this.Controls.Add(this.btn_TypeHentAlle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Gem);
            this.Controls.Add(this.btn_HentAlle);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "UC0AdministrereMægler";
            this.Size = new System.Drawing.Size(1920, 1080);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_HentAlle;
        private System.Windows.Forms.Button btn_Gem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_TypeHentAlle;
        private System.Windows.Forms.Button btn_TypeGem;
    }
}
