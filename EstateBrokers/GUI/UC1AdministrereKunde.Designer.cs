
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC1AdministrereKunde));
            this.dataGridView_CustAdmin = new System.Windows.Forms.DataGridView();
            this.bt_GetAllCustAdmin = new System.Windows.Forms.Button();
            this.bt_saveCustAdmin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CustAdmin)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_CustAdmin
            // 
            this.dataGridView_CustAdmin.AllowUserToOrderColumns = true;
            this.dataGridView_CustAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_CustAdmin.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_CustAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CustAdmin.Location = new System.Drawing.Point(202, 141);
            this.dataGridView_CustAdmin.Name = "dataGridView_CustAdmin";
            this.dataGridView_CustAdmin.RowHeadersWidth = 51;
            this.dataGridView_CustAdmin.Size = new System.Drawing.Size(1442, 718);
            this.dataGridView_CustAdmin.TabIndex = 0;
            // 
            // bt_GetAllCustAdmin
            // 
            this.bt_GetAllCustAdmin.Location = new System.Drawing.Point(202, 92);
            this.bt_GetAllCustAdmin.Name = "bt_GetAllCustAdmin";
            this.bt_GetAllCustAdmin.Size = new System.Drawing.Size(108, 43);
            this.bt_GetAllCustAdmin.TabIndex = 1;
            this.bt_GetAllCustAdmin.Text = "Hent alle";
            this.bt_GetAllCustAdmin.UseVisualStyleBackColor = true;
            this.bt_GetAllCustAdmin.Click += new System.EventHandler(this.bt_GetAllCustAdmin_Click);
            // 
            // bt_saveCustAdmin
            // 
            this.bt_saveCustAdmin.Location = new System.Drawing.Point(316, 92);
            this.bt_saveCustAdmin.Name = "bt_saveCustAdmin";
            this.bt_saveCustAdmin.Size = new System.Drawing.Size(108, 43);
            this.bt_saveCustAdmin.TabIndex = 2;
            this.bt_saveCustAdmin.Text = "Gem";
            this.bt_saveCustAdmin.UseVisualStyleBackColor = true;
            this.bt_saveCustAdmin.Click += new System.EventHandler(this.bt_saveCustAdmin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 1080);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UC1AdministrereKunde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_saveCustAdmin);
            this.Controls.Add(this.bt_GetAllCustAdmin);
            this.Controls.Add(this.dataGridView_CustAdmin);
            this.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "UC1AdministrereKunde";
            this.Size = new System.Drawing.Size(1920, 1080);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CustAdmin)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_CustAdmin;
        private System.Windows.Forms.Button bt_GetAllCustAdmin;
        private System.Windows.Forms.Button bt_saveCustAdmin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
