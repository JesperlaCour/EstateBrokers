
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
            this.txt_CaseOrderId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Show = new System.Windows.Forms.Button();
            this.btn_FindCaseOrder = new System.Windows.Forms.Button();
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
            this.btn_ChooseBuyer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 810);
            this.panel1.TabIndex = 0;
            // 
            // txt_CaseOrderId
            // 
            this.txt_CaseOrderId.Location = new System.Drawing.Point(589, 115);
            this.txt_CaseOrderId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CaseOrderId.Name = "txt_CaseOrderId";
            this.txt_CaseOrderId.Size = new System.Drawing.Size(110, 23);
            this.txt_CaseOrderId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(589, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ændre Salgsstatus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(589, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sagsnummer:";
            // 
            // btn_Show
            // 
            this.btn_Show.Location = new System.Drawing.Point(704, 115);
            this.btn_Show.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(82, 22);
            this.btn_Show.TabIndex = 5;
            this.btn_Show.Text = "Vis";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // btn_FindCaseOrder
            // 
            this.btn_FindCaseOrder.Location = new System.Drawing.Point(792, 115);
            this.btn_FindCaseOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_FindCaseOrder.Name = "btn_FindCaseOrder";
            this.btn_FindCaseOrder.Size = new System.Drawing.Size(82, 22);
            this.btn_FindCaseOrder.TabIndex = 6;
            this.btn_FindCaseOrder.Text = "Find Sag";
            this.btn_FindCaseOrder.UseVisualStyleBackColor = true;
            this.btn_FindCaseOrder.Click += new System.EventHandler(this.btn_FindCaseOrder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sagsnummer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(500, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(599, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "SælgerId";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(690, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "MæglerId";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(767, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "EjendomsId";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(862, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "KøberId";
            // 
            // lbl_CaseOrderId
            // 
            this.lbl_CaseOrderId.AutoSize = true;
            this.lbl_CaseOrderId.Location = new System.Drawing.Point(396, 270);
            this.lbl_CaseOrderId.Name = "lbl_CaseOrderId";
            this.lbl_CaseOrderId.Size = new System.Drawing.Size(38, 15);
            this.lbl_CaseOrderId.TabIndex = 14;
            this.lbl_CaseOrderId.Text = "label9";
            // 
            // lbl_SellerId
            // 
            this.lbl_SellerId.AutoSize = true;
            this.lbl_SellerId.Location = new System.Drawing.Point(599, 270);
            this.lbl_SellerId.Name = "lbl_SellerId";
            this.lbl_SellerId.Size = new System.Drawing.Size(44, 15);
            this.lbl_SellerId.TabIndex = 15;
            this.lbl_SellerId.Text = "label10";
            // 
            // lbl_BrokerId
            // 
            this.lbl_BrokerId.AutoSize = true;
            this.lbl_BrokerId.Location = new System.Drawing.Point(690, 270);
            this.lbl_BrokerId.Name = "lbl_BrokerId";
            this.lbl_BrokerId.Size = new System.Drawing.Size(44, 15);
            this.lbl_BrokerId.TabIndex = 16;
            this.lbl_BrokerId.Text = "label11";
            // 
            // lbl_EstateId
            // 
            this.lbl_EstateId.AutoSize = true;
            this.lbl_EstateId.Location = new System.Drawing.Point(767, 270);
            this.lbl_EstateId.Name = "lbl_EstateId";
            this.lbl_EstateId.Size = new System.Drawing.Size(44, 15);
            this.lbl_EstateId.TabIndex = 17;
            this.lbl_EstateId.Text = "label12";
            // 
            // Cbo_CaseStatus
            // 
            this.Cbo_CaseStatus.FormattingEnabled = true;
            this.Cbo_CaseStatus.Location = new System.Drawing.Point(480, 264);
            this.Cbo_CaseStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cbo_CaseStatus.Name = "Cbo_CaseStatus";
            this.Cbo_CaseStatus.Size = new System.Drawing.Size(96, 23);
            this.Cbo_CaseStatus.TabIndex = 19;
            this.Cbo_CaseStatus.SelectedIndexChanged += new System.EventHandler(this.Cbo_CaseStatus_SelectedIndexChanged);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(1012, 263);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(82, 22);
            this.btn_Save.TabIndex = 20;
            this.btn_Save.Text = "Gem";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_BuyerId
            // 
            this.lbl_BuyerId.AutoSize = true;
            this.lbl_BuyerId.Location = new System.Drawing.Point(862, 270);
            this.lbl_BuyerId.Name = "lbl_BuyerId";
            this.lbl_BuyerId.Size = new System.Drawing.Size(38, 15);
            this.lbl_BuyerId.TabIndex = 21;
            this.lbl_BuyerId.Text = "label9";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(575, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(259, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "Sags Informationer:";
            // 
            // btn_ChooseBuyer
            // 
            this.btn_ChooseBuyer.Location = new System.Drawing.Point(925, 263);
            this.btn_ChooseBuyer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ChooseBuyer.Name = "btn_ChooseBuyer";
            this.btn_ChooseBuyer.Size = new System.Drawing.Size(82, 22);
            this.btn_ChooseBuyer.TabIndex = 23;
            this.btn_ChooseBuyer.Text = "Vælg køber";
            this.btn_ChooseBuyer.UseVisualStyleBackColor = true;
            this.btn_ChooseBuyer.Click += new System.EventHandler(this.btn_ChooseCustomer_Click);
            // 
            // UC7Salgsstatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_ChooseBuyer);
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
            this.Controls.Add(this.btn_FindCaseOrder);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_CaseOrderId);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1680, 810);
            this.Name = "UC7Salgsstatus";
            this.Size = new System.Drawing.Size(1680, 810);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_CaseOrderId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.Button btn_FindCaseOrder;
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
        private System.Windows.Forms.Button btn_ChooseBuyer;
    }
}
