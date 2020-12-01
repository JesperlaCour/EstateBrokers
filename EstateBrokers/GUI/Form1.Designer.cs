namespace GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.caseManagementcrud1 = new GUI.UC3AdministrereSag();
            this.forside1 = new GUI.Forside();
            this.administrereKunde1 = new GUI.UC1AdministrereKunde();
            this.administrereHus1 = new GUI.UC2AdministrereHus();
            this.udbudsprisBeregner1 = new GUI.UC4UdbudsprisBeregner();
            this.aabentHus1 = new GUI.UC5AabentHus();
            this.uC0AdministrereMægler1 = new GUI.UC0AdministrereMægler();
            this.uC7Salgsstatus1 = new GUI.UC7Salgsstatus();
            this.uC6Salgsstatistik1 = new GUI.UC6Salgsstatistik();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1902, 75);
            this.panel1.TabIndex = 0;
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(940, 1);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(229, 75);
            this.button9.TabIndex = 6;
            this.button9.Text = "Administrere Mægler";
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(0, 0);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(229, 75);
            this.button7.TabIndex = 4;
            this.button7.Text = "Salgsstatus";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(235, -2);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(229, 75);
            this.button6.TabIndex = 3;
            this.button6.Text = "Salgsstatistik";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(470, 0);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(229, 75);
            this.button5.TabIndex = 2;
            this.button5.Text = "Åbent Hus";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(1410, -1);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(229, 75);
            this.button4.TabIndex = 1;
            this.button4.Text = "Administrere Kunde";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(1175, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(229, 75);
            this.button3.TabIndex = 1;
            this.button3.Text = "Administrere Hus";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(705, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(229, 75);
            this.button2.TabIndex = 1;
            this.button2.Text = "Udbudspris Beregner";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1645, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 75);
            this.button1.TabIndex = 1;
            this.button1.Text = "Administrere Sag";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // caseManagementcrud1
            // 
            this.caseManagementcrud1.Location = new System.Drawing.Point(0, 75);
            this.caseManagementcrud1.Margin = new System.Windows.Forms.Padding(5);
            this.caseManagementcrud1.MinimumSize = new System.Drawing.Size(1067, 676);
            this.caseManagementcrud1.Name = "caseManagementcrud1";
            this.caseManagementcrud1.Size = new System.Drawing.Size(1925, 962);
            this.caseManagementcrud1.TabIndex = 1;
            // 
            // forside1
            // 
            this.forside1.Location = new System.Drawing.Point(0, 75);
            this.forside1.MinimumSize = new System.Drawing.Size(1068, 676);
            this.forside1.Name = "forside1";
            this.forside1.Size = new System.Drawing.Size(1925, 962);
            this.forside1.TabIndex = 2;
            // 
            // administrereKunde1
            // 
            this.administrereKunde1.Location = new System.Drawing.Point(0, 75);
            this.administrereKunde1.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.administrereKunde1.Name = "administrereKunde1";
            this.administrereKunde1.Size = new System.Drawing.Size(2400, 1350);
            this.administrereKunde1.TabIndex = 3;
            // 
            // administrereHus1
            // 
            this.administrereHus1.Location = new System.Drawing.Point(0, 75);
            this.administrereHus1.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.administrereHus1.Name = "administrereHus1";
            this.administrereHus1.Size = new System.Drawing.Size(2400, 1350);
            this.administrereHus1.TabIndex = 4;
            // 
            // udbudsprisBeregner1	
            // 	
            this.udbudsprisBeregner1.Location = new System.Drawing.Point(0, 75);
            this.udbudsprisBeregner1.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.udbudsprisBeregner1.Name = "udbudsprisBeregner1";
            this.udbudsprisBeregner1.Size = new System.Drawing.Size(2400, 1350);
            this.udbudsprisBeregner1.TabIndex = 5;
            // 
            // aabentHus1
            // 
            this.aabentHus1.Location = new System.Drawing.Point(0, 75);
            this.aabentHus1.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.aabentHus1.Name = "aabentHus1";
            this.aabentHus1.Size = new System.Drawing.Size(2400, 1350);
            this.aabentHus1.TabIndex = 6;
            // 
            // uC0AdministrereMægler1
            // 
            this.uC0AdministrereMægler1.Location = new System.Drawing.Point(0, 75);
            this.uC0AdministrereMægler1.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.uC0AdministrereMægler1.Name = "uC0AdministrereMægler1";
            this.uC0AdministrereMægler1.Size = new System.Drawing.Size(2400, 1350);
            this.uC0AdministrereMægler1.TabIndex = 7;
            // 
            // uC6Salgsstatistik1
            // 
            this.uC6Salgsstatistik1.Location = new System.Drawing.Point(0, 75);
            this.uC6Salgsstatistik1.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.uC6Salgsstatistik1.Name = "uC6Salgsstatistik1";
            this.uC6Salgsstatistik1.Size = new System.Drawing.Size(2400, 1350);
            this.uC6Salgsstatistik1.TabIndex = 8;
            //
            // uC7Salgsstatus1
            //
            this.uC7Salgsstatus1.Location = new System.Drawing.Point(0, 75);
            this.uC7Salgsstatus1.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.uC7Salgsstatus1.Name = "uC7Salgsstatus1";
            this.uC7Salgsstatus1.Size = new System.Drawing.Size(2400, 1350);
            this.uC7Salgsstatus1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.Controls.Add(this.uC7Salgsstatus1);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.forside1);
            this.Controls.Add(this.caseManagementcrud1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.administrereKunde1);
            this.Controls.Add(this.administrereHus1);
            this.Controls.Add(this.udbudsprisBeregner1);
            this.Controls.Add(this.aabentHus1);
            this.Controls.Add(this.uC0AdministrereMægler1);
            this.Controls.Add(this.uC6Salgsstatistik1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1918, 1028);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private UC3AdministrereSag caseManagementcrud1;
        private Forside forside1;
        private UC1AdministrereKunde administrereKunde1;
        private UC2AdministrereHus administrereHus1;
        private UC4UdbudsprisBeregner udbudsprisBeregner1;
        private UC5AabentHus aabentHus1;
        private System.Windows.Forms.Button button9;
        private UC0AdministrereMægler uC0AdministrereMægler1;
        private UC7Salgsstatus uC7Salgsstatus1;
        private UC6Salgsstatistik uC6Salgsstatistik1;
    }
}

