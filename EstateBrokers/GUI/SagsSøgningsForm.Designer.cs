
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
            this.dataGridView_caseOrder = new System.Windows.Forms.DataGridView();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_CreateNewCase = new System.Windows.Forms.Button();
            this.btn_choose = new System.Windows.Forms.Button();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_caseOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_caseOrder
            // 
            this.dataGridView_caseOrder.AllowUserToAddRows = false;
            this.dataGridView_caseOrder.AllowUserToDeleteRows = false;
            this.dataGridView_caseOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_caseOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_caseOrder.Location = new System.Drawing.Point(20, 176);
            this.dataGridView_caseOrder.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView_caseOrder.Name = "dataGridView_caseOrder";
            this.dataGridView_caseOrder.ReadOnly = true;
            this.dataGridView_caseOrder.RowHeadersWidth = 51;
            this.dataGridView_caseOrder.Size = new System.Drawing.Size(1633, 760);
            this.dataGridView_caseOrder.TabIndex = 0;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(234, 115);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(153, 46);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "Søg";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_CreateNewCase
            // 
            this.btn_CreateNewCase.Location = new System.Drawing.Point(418, 115);
            this.btn_CreateNewCase.Margin = new System.Windows.Forms.Padding(5);
            this.btn_CreateNewCase.Name = "btn_CreateNewCase";
            this.btn_CreateNewCase.Size = new System.Drawing.Size(153, 46);
            this.btn_CreateNewCase.TabIndex = 2;
            this.btn_CreateNewCase.Text = "Opret ny sag";
            this.btn_CreateNewCase.UseVisualStyleBackColor = true;
            this.btn_CreateNewCase.Click += new System.EventHandler(this.btn_CreateNewCase_Click);
            // 
            // btn_choose
            // 
            this.btn_choose.Location = new System.Drawing.Point(1500, 118);
            this.btn_choose.Margin = new System.Windows.Forms.Padding(5);
            this.btn_choose.Name = "btn_choose";
            this.btn_choose.Size = new System.Drawing.Size(153, 46);
            this.btn_choose.TabIndex = 3;
            this.btn_choose.Text = "Vælg";
            this.btn_choose.UseVisualStyleBackColor = true;
            this.btn_choose.Click += new System.EventHandler(this.btn_choose_Click);
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(21, 118);
            this.txt_address.Margin = new System.Windows.Forms.Padding(5);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(201, 39);
            this.txt_address.TabIndex = 4;
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(21, 82);
            this.lbl_address.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(97, 32);
            this.lbl_address.TabIndex = 5;
            this.lbl_address.Text = "Adresse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(696, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 51);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sags søgning";
            // 
            // SagsSøgningsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1710, 955);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.btn_choose);
            this.Controls.Add(this.btn_CreateNewCase);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dataGridView_caseOrder);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SagsSøgningsForm";
            this.Text = "SagsSøgningsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_caseOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_caseOrder;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_CreateNewCase;
        private System.Windows.Forms.Button btn_choose;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label label2;
    }
}