
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Txt_Kvm = new System.Windows.Forms.TextBox();
            this.Btn_Beregn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cbo_Hustype = new System.Windows.Forms.ComboBox();
            this.Cbo_Indretning = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Tb_Stand = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Btn_OpretHus = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.Txt_RenoveringsÅr = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_udbudspris = new System.Windows.Forms.Label();
            this.Txt_Postnummer = new System.Windows.Forms.TextBox();
            this.Txt_AntalBade = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tb_Stand)).BeginInit();
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
            // Txt_Kvm
            // 
            this.Txt_Kvm.Location = new System.Drawing.Point(764, 205);
            this.Txt_Kvm.Name = "Txt_Kvm";
            this.Txt_Kvm.Size = new System.Drawing.Size(78, 27);
            this.Txt_Kvm.TabIndex = 1;
            // 
            // Btn_Beregn
            // 
            this.Btn_Beregn.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Beregn.Location = new System.Drawing.Point(1521, 201);
            this.Btn_Beregn.Name = "Btn_Beregn";
            this.Btn_Beregn.Size = new System.Drawing.Size(94, 29);
            this.Btn_Beregn.TabIndex = 2;
            this.Btn_Beregn.Text = "Beregn";
            this.Btn_Beregn.UseVisualStyleBackColor = true;
            this.Btn_Beregn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(202, 565);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1718, 309);
            this.dataGridView1.TabIndex = 3;
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1345, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Antal badeværelser";
            // 
            // Cbo_Hustype
            // 
            this.Cbo_Hustype.FormattingEnabled = true;
            this.Cbo_Hustype.Location = new System.Drawing.Point(544, 204);
            this.Cbo_Hustype.Name = "Cbo_Hustype";
            this.Cbo_Hustype.Size = new System.Drawing.Size(121, 28);
            this.Cbo_Hustype.TabIndex = 11;
            // 
            // Cbo_Indretning
            // 
            this.Cbo_Indretning.FormattingEnabled = true;
            this.Cbo_Indretning.Location = new System.Drawing.Point(1107, 204);
            this.Cbo_Indretning.Name = "Cbo_Indretning";
            this.Cbo_Indretning.Size = new System.Drawing.Size(92, 28);
            this.Cbo_Indretning.TabIndex = 12;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(1101, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Indretning";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(1205, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Renoverings år";
            // 
            // Tb_Stand
            // 
            this.Tb_Stand.Location = new System.Drawing.Point(848, 205);
            this.Tb_Stand.Name = "Tb_Stand";
            this.Tb_Stand.Size = new System.Drawing.Size(239, 56);
            this.Tb_Stand.TabIndex = 17;
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
            // Btn_OpretHus
            // 
            this.Btn_OpretHus.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_OpretHus.Location = new System.Drawing.Point(975, 408);
            this.Btn_OpretHus.Name = "Btn_OpretHus";
            this.Btn_OpretHus.Size = new System.Drawing.Size(152, 34);
            this.Btn_OpretHus.TabIndex = 22;
            this.Btn_OpretHus.Text = "Opret hus";
            this.Btn_OpretHus.UseVisualStyleBackColor = true;
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
            // Txt_RenoveringsÅr
            // 
            this.Txt_RenoveringsÅr.Location = new System.Drawing.Point(1205, 203);
            this.Txt_RenoveringsÅr.Name = "Txt_RenoveringsÅr";
            this.Txt_RenoveringsÅr.Size = new System.Drawing.Size(134, 27);
            this.Txt_RenoveringsÅr.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Courier New", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(844, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(415, 53);
            this.label12.TabIndex = 25;
            this.label12.Text = "Husoplysninger";
            // 
            // lbl_udbudspris
            // 
            this.lbl_udbudspris.AutoSize = true;
            this.lbl_udbudspris.Font = new System.Drawing.Font("Courier New", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_udbudspris.Location = new System.Drawing.Point(1182, 317);
            this.lbl_udbudspris.Name = "lbl_udbudspris";
            this.lbl_udbudspris.Size = new System.Drawing.Size(238, 41);
            this.lbl_udbudspris.TabIndex = 26;
            this.lbl_udbudspris.Text = "Udbudspris";
            // 
            // Txt_Postnummer
            // 
            this.Txt_Postnummer.Location = new System.Drawing.Point(671, 205);
            this.Txt_Postnummer.Name = "Txt_Postnummer";
            this.Txt_Postnummer.Size = new System.Drawing.Size(87, 27);
            this.Txt_Postnummer.TabIndex = 27;
            // 
            // Txt_AntalBade
            // 
            this.Txt_AntalBade.Location = new System.Drawing.Point(1345, 203);
            this.Txt_AntalBade.Name = "Txt_AntalBade";
            this.Txt_AntalBade.Size = new System.Drawing.Size(170, 27);
            this.Txt_AntalBade.TabIndex = 28;
            // 
            // UC4UdbudsprisBeregner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Txt_AntalBade);
            this.Controls.Add(this.Txt_Postnummer);
            this.Controls.Add(this.lbl_udbudspris);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Txt_RenoveringsÅr);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Btn_OpretHus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Tb_Stand);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cbo_Indretning);
            this.Controls.Add(this.Cbo_Hustype);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_Beregn);
            this.Controls.Add(this.Txt_Kvm);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "UC4UdbudsprisBeregner";
            this.Size = new System.Drawing.Size(1920, 1080);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tb_Stand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Txt_Kvm;
        private System.Windows.Forms.Button Btn_Beregn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cbo_Hustype;
        private System.Windows.Forms.ComboBox Cbo_Indretning;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar Tb_Stand;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Btn_OpretHus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Txt_RenoveringsÅr;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_udbudspris;
        private System.Windows.Forms.TextBox Txt_Postnummer;
        private System.Windows.Forms.TextBox Txt_AntalBade;
    }
}
