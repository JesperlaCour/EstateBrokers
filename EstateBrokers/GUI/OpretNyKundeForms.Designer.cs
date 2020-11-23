
namespace GUI
{
    partial class OpretNyKundeForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Navn = new System.Windows.Forms.TextBox();
            this.txt_Adresse = new System.Windows.Forms.TextBox();
            this.txt_TlfNr = new System.Windows.Forms.TextBox();
            this.txt_Postnummer = new System.Windows.Forms.TextBox();
            this.btn_opret = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opret ny kunde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Navn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adresse:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tlf. Nr.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Postnummer:";
            // 
            // txt_Navn
            // 
            this.txt_Navn.Location = new System.Drawing.Point(12, 86);
            this.txt_Navn.Name = "txt_Navn";
            this.txt_Navn.Size = new System.Drawing.Size(125, 27);
            this.txt_Navn.TabIndex = 7;
            // 
            // txt_Adresse
            // 
            this.txt_Adresse.Location = new System.Drawing.Point(12, 149);
            this.txt_Adresse.Name = "txt_Adresse";
            this.txt_Adresse.Size = new System.Drawing.Size(125, 27);
            this.txt_Adresse.TabIndex = 8;
            // 
            // txt_TlfNr
            // 
            this.txt_TlfNr.Location = new System.Drawing.Point(12, 214);
            this.txt_TlfNr.Name = "txt_TlfNr";
            this.txt_TlfNr.Size = new System.Drawing.Size(125, 27);
            this.txt_TlfNr.TabIndex = 9;
            // 
            // txt_Postnummer
            // 
            this.txt_Postnummer.Location = new System.Drawing.Point(12, 276);
            this.txt_Postnummer.Name = "txt_Postnummer";
            this.txt_Postnummer.Size = new System.Drawing.Size(125, 27);
            this.txt_Postnummer.TabIndex = 10;
            // 
            // btn_opret
            // 
            this.btn_opret.Location = new System.Drawing.Point(13, 310);
            this.btn_opret.Name = "btn_opret";
            this.btn_opret.Size = new System.Drawing.Size(94, 29);
            this.btn_opret.TabIndex = 11;
            this.btn_opret.Text = "Opret";
            this.btn_opret.UseVisualStyleBackColor = true;
            // 
            // OpretNyKundeForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 357);
            this.Controls.Add(this.btn_opret);
            this.Controls.Add(this.txt_Postnummer);
            this.Controls.Add(this.txt_TlfNr);
            this.Controls.Add(this.txt_Adresse);
            this.Controls.Add(this.txt_Navn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OpretNyKundeForms";
            this.Text = "OpretNyKundeForms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Navn;
        private System.Windows.Forms.TextBox txt_Adresse;
        private System.Windows.Forms.TextBox txt_TlfNr;
        private System.Windows.Forms.TextBox txt_Postnummer;
        private System.Windows.Forms.Button btn_opret;
    }
}