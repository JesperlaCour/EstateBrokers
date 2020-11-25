
namespace GUI
{
    partial class UC7Salgsstatus
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_GetAll = new System.Windows.Forms.Button();
            this.btn_Choose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_CaseOrderId = new System.Windows.Forms.Label();
            this.lbl_SellerId = new System.Windows.Forms.Label();
            this.lbl_BrokerId = new System.Windows.Forms.Label();
            this.lbl_EstateId = new System.Windows.Forms.Label();
            this.Cbo_CaseStatus = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lbl_BuyerId = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_ChooseCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 1080);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(235, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1001, 188);
            this.dataGridView1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(235, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(673, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ændre Salgsstatus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(235, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sagsnummer:";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(367, 130);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(94, 29);
            this.btn_Search.TabIndex = 5;
            this.btn_Search.Text = "Søg";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // btn_GetAll
            // 
            this.btn_GetAll.Location = new System.Drawing.Point(467, 130);
            this.btn_GetAll.Name = "btn_GetAll";
            this.btn_GetAll.Size = new System.Drawing.Size(94, 29);
            this.btn_GetAll.TabIndex = 6;
            this.btn_GetAll.Text = "Hent alle";
            this.btn_GetAll.UseVisualStyleBackColor = true;
            // 
            // btn_Choose
            // 
            this.btn_Choose.Location = new System.Drawing.Point(1142, 139);
            this.btn_Choose.Name = "btn_Choose";
            this.btn_Choose.Size = new System.Drawing.Size(94, 29);
            this.btn_Choose.TabIndex = 7;
            this.btn_Choose.Text = "Vælg";
            this.btn_Choose.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 458);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sagsnummer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(529, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(642, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "SælgerId";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(745, 458);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "MæglerId";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(834, 458);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "EjendomsId";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(942, 458);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "KøberId";
            // 
            // lbl_CaseOrderId
            // 
            this.lbl_CaseOrderId.AutoSize = true;
            this.lbl_CaseOrderId.Location = new System.Drawing.Point(410, 509);
            this.lbl_CaseOrderId.Name = "lbl_CaseOrderId";
            this.lbl_CaseOrderId.Size = new System.Drawing.Size(50, 20);
            this.lbl_CaseOrderId.TabIndex = 14;
            this.lbl_CaseOrderId.Text = "label9";
            // 
            // lbl_SellerId
            // 
            this.lbl_SellerId.AutoSize = true;
            this.lbl_SellerId.Location = new System.Drawing.Point(642, 509);
            this.lbl_SellerId.Name = "lbl_SellerId";
            this.lbl_SellerId.Size = new System.Drawing.Size(58, 20);
            this.lbl_SellerId.TabIndex = 15;
            this.lbl_SellerId.Text = "label10";
            // 
            // lbl_BrokerId
            // 
            this.lbl_BrokerId.AutoSize = true;
            this.lbl_BrokerId.Location = new System.Drawing.Point(745, 509);
            this.lbl_BrokerId.Name = "lbl_BrokerId";
            this.lbl_BrokerId.Size = new System.Drawing.Size(58, 20);
            this.lbl_BrokerId.TabIndex = 16;
            this.lbl_BrokerId.Text = "label11";
            // 
            // lbl_EstateId
            // 
            this.lbl_EstateId.AutoSize = true;
            this.lbl_EstateId.Location = new System.Drawing.Point(834, 509);
            this.lbl_EstateId.Name = "lbl_EstateId";
            this.lbl_EstateId.Size = new System.Drawing.Size(58, 20);
            this.lbl_EstateId.TabIndex = 17;
            this.lbl_EstateId.Text = "label12";
            // 
            // Cbo_CaseStatus
            // 
            this.Cbo_CaseStatus.FormattingEnabled = true;
            this.Cbo_CaseStatus.Location = new System.Drawing.Point(506, 501);
            this.Cbo_CaseStatus.Name = "Cbo_CaseStatus";
            this.Cbo_CaseStatus.Size = new System.Drawing.Size(109, 28);
            this.Cbo_CaseStatus.TabIndex = 19;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(1114, 500);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(94, 29);
            this.btn_Save.TabIndex = 20;
            this.btn_Save.Text = "Gem";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // lbl_BuyerId
            // 
            this.lbl_BuyerId.AutoSize = true;
            this.lbl_BuyerId.Location = new System.Drawing.Point(942, 509);
            this.lbl_BuyerId.Name = "lbl_BuyerId";
            this.lbl_BuyerId.Size = new System.Drawing.Size(50, 20);
            this.lbl_BuyerId.TabIndex = 21;
            this.lbl_BuyerId.Text = "label9";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(614, 397);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(337, 31);
            this.label9.TabIndex = 22;
            this.label9.Text = "Sags Informationer:";
            // 
            // btn_ChooseCustomer
            // 
            this.btn_ChooseCustomer.Location = new System.Drawing.Point(1014, 500);
            this.btn_ChooseCustomer.Name = "btn_ChooseCustomer";
            this.btn_ChooseCustomer.Size = new System.Drawing.Size(94, 29);
            this.btn_ChooseCustomer.TabIndex = 23;
            this.btn_ChooseCustomer.Text = "Vælg kunde";
            this.btn_ChooseCustomer.UseVisualStyleBackColor = true;
            this.btn_ChooseCustomer.Click += new System.EventHandler(this.btn_ChooseCustomer_Click);
            // 
            // UC7Salgsstatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_ChooseCustomer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_BuyerId);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.Cbo_CaseStatus);
            this.Controls.Add(this.lbl_EstateId);
            this.Controls.Add(this.lbl_BrokerId);
            this.Controls.Add(this.lbl_SellerId);
            this.Controls.Add(this.lbl_CaseOrderId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Choose);
            this.Controls.Add(this.btn_GetAll);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "UC7Salgsstatus";
            this.Size = new System.Drawing.Size(1920, 1080);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_GetAll;
        private System.Windows.Forms.Button btn_Choose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_CaseOrderId;
        private System.Windows.Forms.Label lbl_SellerId;
        private System.Windows.Forms.Label lbl_BrokerId;
        private System.Windows.Forms.Label lbl_EstateId;
        private System.Windows.Forms.ComboBox Cbo_CaseStatus;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lbl_BuyerId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_ChooseCustomer;
    }
}
