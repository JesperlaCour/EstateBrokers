﻿
namespace GUI
{
    partial class OpretSagForm
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
            this.tbt_sellerID = new System.Windows.Forms.TextBox();
            this.tbt_estateID = new System.Windows.Forms.TextBox();
            this.tbt_ListingPrice = new System.Windows.Forms.TextBox();
            this.bt_CreateNewCase = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cbo_ChooseBroker = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Courier New", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opret ny sag:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(20, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kundenummer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(20, 286);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ejendomsnummer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(20, 393);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(320, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Aftalt Udbudspris:";
            // 
            // tbt_sellerID
            // 
            this.tbt_sellerID.Location = new System.Drawing.Point(20, 220);
            this.tbt_sellerID.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.tbt_sellerID.Name = "tbt_sellerID";
            this.tbt_sellerID.Size = new System.Drawing.Size(201, 39);
            this.tbt_sellerID.TabIndex = 4;
            // 
            // tbt_estateID
            // 
            this.tbt_estateID.Location = new System.Drawing.Point(20, 322);
            this.tbt_estateID.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.tbt_estateID.Name = "tbt_estateID";
            this.tbt_estateID.Size = new System.Drawing.Size(249, 39);
            this.tbt_estateID.TabIndex = 5;
            // 
            // tbt_ListingPrice
            // 
            this.tbt_ListingPrice.Location = new System.Drawing.Point(20, 429);
            this.tbt_ListingPrice.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.tbt_ListingPrice.Name = "tbt_ListingPrice";
            this.tbt_ListingPrice.Size = new System.Drawing.Size(294, 39);
            this.tbt_ListingPrice.TabIndex = 6;
            // 
            // bt_CreateNewCase
            // 
            this.bt_CreateNewCase.Location = new System.Drawing.Point(20, 482);
            this.bt_CreateNewCase.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.bt_CreateNewCase.Name = "bt_CreateNewCase";
            this.bt_CreateNewCase.Size = new System.Drawing.Size(152, 47);
            this.bt_CreateNewCase.TabIndex = 7;
            this.bt_CreateNewCase.Text = "Opret sag";
            this.bt_CreateNewCase.UseVisualStyleBackColor = true;
            this.bt_CreateNewCase.Click += new System.EventHandler(this.bt_CreateNewCase_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(234, 220);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 47);
            this.button2.TabIndex = 8;
            this.button2.Text = "Find kunde";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(282, 322);
            this.button3.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 47);
            this.button3.TabIndex = 9;
            this.button3.Text = "Find Hus";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbo_ChooseBroker
            // 
            this.cbo_ChooseBroker.FormattingEnabled = true;
            this.cbo_ChooseBroker.Location = new System.Drawing.Point(20, 117);
            this.cbo_ChooseBroker.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cbo_ChooseBroker.Name = "cbo_ChooseBroker";
            this.cbo_ChooseBroker.Size = new System.Drawing.Size(244, 40);
            this.cbo_ChooseBroker.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(20, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "Vælge Mægler:";
            // 
            // OpretSagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 546);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbo_ChooseBroker);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bt_CreateNewCase);
            this.Controls.Add(this.tbt_ListingPrice);
            this.Controls.Add(this.tbt_estateID);
            this.Controls.Add(this.tbt_sellerID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "OpretSagForm";
            this.Text = "OpretSagForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbt_ListingPrice;
        private System.Windows.Forms.Button bt_CreateNewCase;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbo_ChooseBroker;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tbt_estateID;
        public System.Windows.Forms.TextBox tbt_sellerID;
    }
}