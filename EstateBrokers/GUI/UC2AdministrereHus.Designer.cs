
namespace GUI
{
    partial class UC2AdministrereHus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC2AdministrereHus));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_AllEstates = new System.Windows.Forms.DataGridView();
            this.bt_GetAllEstates = new System.Windows.Forms.Button();
            this.bt_SaveEstates = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AllEstates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 1080);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView_AllEstates
            // 
            this.dataGridView_AllEstates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AllEstates.Location = new System.Drawing.Point(202, 122);
            this.dataGridView_AllEstates.Name = "dataGridView_AllEstates";
            this.dataGridView_AllEstates.RowHeadersWidth = 51;
            this.dataGridView_AllEstates.Size = new System.Drawing.Size(1442, 718);
            this.dataGridView_AllEstates.TabIndex = 1;
            // 
            // bt_GetAllEstates
            // 
            this.bt_GetAllEstates.Location = new System.Drawing.Point(202, 73);
            this.bt_GetAllEstates.Name = "bt_GetAllEstates";
            this.bt_GetAllEstates.Size = new System.Drawing.Size(106, 43);
            this.bt_GetAllEstates.TabIndex = 2;
            this.bt_GetAllEstates.Text = "Hent Alle";
            this.bt_GetAllEstates.UseVisualStyleBackColor = true;
            this.bt_GetAllEstates.Click += new System.EventHandler(this.bt_GetAllEstates_Click);
            // 
            // bt_SaveEstates
            // 
            this.bt_SaveEstates.Location = new System.Drawing.Point(314, 73);
            this.bt_SaveEstates.Name = "bt_SaveEstates";
            this.bt_SaveEstates.Size = new System.Drawing.Size(104, 43);
            this.bt_SaveEstates.TabIndex = 3;
            this.bt_SaveEstates.Text = "Gem";
            this.bt_SaveEstates.UseVisualStyleBackColor = true;
            this.bt_SaveEstates.Click += new System.EventHandler(this.bt_SaveEstates_Click);
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
            // UC2AdministrereHus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bt_SaveEstates);
            this.Controls.Add(this.bt_GetAllEstates);
            this.Controls.Add(this.dataGridView_AllEstates);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "UC2AdministrereHus";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AllEstates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_AllEstates;
        private System.Windows.Forms.Button bt_GetAllEstates;
        private System.Windows.Forms.Button bt_SaveEstates;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
