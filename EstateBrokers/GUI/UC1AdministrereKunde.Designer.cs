
namespace GUI
{
    partial class UC1AdministrereKunde
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
            this.dataGridView_CustAdmin = new System.Windows.Forms.DataGridView();
            this.bt_GetAllCustAdmin = new System.Windows.Forms.Button();
            this.bt_saveCustAdmin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CustAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_CustAdmin
            // 
            this.dataGridView_CustAdmin.AllowUserToOrderColumns = true;
            this.dataGridView_CustAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CustAdmin.Location = new System.Drawing.Point(328, 226);
            this.dataGridView_CustAdmin.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView_CustAdmin.Name = "dataGridView_CustAdmin";
            this.dataGridView_CustAdmin.RowHeadersWidth = 51;
            this.dataGridView_CustAdmin.Size = new System.Drawing.Size(2343, 1149);
            this.dataGridView_CustAdmin.TabIndex = 0;
            // 
            // bt_GetAllCustAdmin
            // 
            this.bt_GetAllCustAdmin.Location = new System.Drawing.Point(328, 147);
            this.bt_GetAllCustAdmin.Margin = new System.Windows.Forms.Padding(5);
            this.bt_GetAllCustAdmin.Name = "bt_GetAllCustAdmin";
            this.bt_GetAllCustAdmin.Size = new System.Drawing.Size(176, 69);
            this.bt_GetAllCustAdmin.TabIndex = 1;
            this.bt_GetAllCustAdmin.Text = "Hent alle";
            this.bt_GetAllCustAdmin.UseVisualStyleBackColor = true;
            // 
            // bt_saveCustAdmin
            // 
            this.bt_saveCustAdmin.Location = new System.Drawing.Point(514, 147);
            this.bt_saveCustAdmin.Margin = new System.Windows.Forms.Padding(5);
            this.bt_saveCustAdmin.Name = "bt_saveCustAdmin";
            this.bt_saveCustAdmin.Size = new System.Drawing.Size(176, 69);
            this.bt_saveCustAdmin.TabIndex = 2;
            this.bt_saveCustAdmin.Text = "Gem";
            this.bt_saveCustAdmin.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 1728);
            this.panel1.TabIndex = 3;
            // 
            // AdministrereKunde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_saveCustAdmin);
            this.Controls.Add(this.bt_GetAllCustAdmin);
            this.Controls.Add(this.dataGridView_CustAdmin);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(3120, 1728);
            this.Name = "AdministrereKunde";
            this.Size = new System.Drawing.Size(3120, 1728);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CustAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_CustAdmin;
        private System.Windows.Forms.Button bt_GetAllCustAdmin;
        private System.Windows.Forms.Button bt_saveCustAdmin;
        private System.Windows.Forms.Panel panel1;
    }
}
