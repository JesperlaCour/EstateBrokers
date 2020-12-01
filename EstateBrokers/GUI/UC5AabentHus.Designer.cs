
namespace GUI
{
    partial class UC5AabentHus
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
            this.cbo_brokers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ShowExisting = new System.Windows.Forms.Button();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_ChooseHouse = new System.Windows.Forms.Button();
            this.btn_RemoveHouse = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Assigned = new System.Windows.Forms.Button();
            this.dataGridView_AllCaseOrders = new System.Windows.Forms.DataGridView();
            this.dataGridView_selectedCaseOrders = new System.Windows.Forms.DataGridView();
            this.dataGridView_selectedBrokers = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AllCaseOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_selectedCaseOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_selectedBrokers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 1728);
            this.panel1.TabIndex = 0;
            // 
            // cbo_brokers
            // 
            this.cbo_brokers.FormattingEnabled = true;
            this.cbo_brokers.Location = new System.Drawing.Point(2408, 258);
            this.cbo_brokers.Margin = new System.Windows.Forms.Padding(5);
            this.cbo_brokers.Name = "cbo_brokers";
            this.cbo_brokers.Size = new System.Drawing.Size(269, 40);
            this.cbo_brokers.TabIndex = 2;
            this.cbo_brokers.SelectedIndexChanged += new System.EventHandler(this.cbo_brokers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1503, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "Arrengere åbenthus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(405, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Adresse:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1602, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 41);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valgte huse";
            // 
            // btn_ShowExisting
            // 
            this.btn_ShowExisting.Location = new System.Drawing.Point(398, 99);
            this.btn_ShowExisting.Margin = new System.Windows.Forms.Padding(5);
            this.btn_ShowExisting.Name = "btn_ShowExisting";
            this.btn_ShowExisting.Size = new System.Drawing.Size(210, 46);
            this.btn_ShowExisting.TabIndex = 10;
            this.btn_ShowExisting.Text = "Se eksisterende";
            this.btn_ShowExisting.UseVisualStyleBackColor = true;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(405, 187);
            this.txt_address.Margin = new System.Windows.Forms.Padding(5);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(201, 39);
            this.txt_address.TabIndex = 11;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(618, 187);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(153, 46);
            this.btn_Search.TabIndex = 12;
            this.btn_Search.Text = "Søg";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_ChooseHouse
            // 
            this.btn_ChooseHouse.Location = new System.Drawing.Point(1220, 645);
            this.btn_ChooseHouse.Margin = new System.Windows.Forms.Padding(5);
            this.btn_ChooseHouse.Name = "btn_ChooseHouse";
            this.btn_ChooseHouse.Size = new System.Drawing.Size(147, 46);
            this.btn_ChooseHouse.TabIndex = 13;
            this.btn_ChooseHouse.Text = "Tilføj";
            this.btn_ChooseHouse.UseVisualStyleBackColor = true;
            this.btn_ChooseHouse.Click += new System.EventHandler(this.btn_ChooseHouse_Click);
            // 
            // btn_RemoveHouse
            // 
            this.btn_RemoveHouse.Location = new System.Drawing.Point(1220, 740);
            this.btn_RemoveHouse.Margin = new System.Windows.Forms.Padding(5);
            this.btn_RemoveHouse.Name = "btn_RemoveHouse";
            this.btn_RemoveHouse.Size = new System.Drawing.Size(147, 46);
            this.btn_RemoveHouse.TabIndex = 14;
            this.btn_RemoveHouse.Text = "Fjern";
            this.btn_RemoveHouse.UseVisualStyleBackColor = true;
            this.btn_RemoveHouse.Click += new System.EventHandler(this.btn_RemoveHouse_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(2408, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 27);
            this.label4.TabIndex = 15;
            this.label4.Text = "Mæglere";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(2408, 720);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(404, 39);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(2408, 669);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 27);
            this.label5.TabIndex = 17;
            this.label5.Text = "Åbenhus dato:";
            // 
            // btn_Assigned
            // 
            this.btn_Assigned.Location = new System.Drawing.Point(2408, 804);
            this.btn_Assigned.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Assigned.Name = "btn_Assigned";
            this.btn_Assigned.Size = new System.Drawing.Size(404, 103);
            this.btn_Assigned.TabIndex = 18;
            this.btn_Assigned.Text = "Tildel";
            this.btn_Assigned.UseVisualStyleBackColor = true;
            this.btn_Assigned.Click += new System.EventHandler(this.btn_Assigned_Click);
            // 
            // dataGridView_AllCaseOrders
            // 
            this.dataGridView_AllCaseOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AllCaseOrders.Location = new System.Drawing.Point(405, 258);
            this.dataGridView_AllCaseOrders.Name = "dataGridView_AllCaseOrders";
            this.dataGridView_AllCaseOrders.RowHeadersWidth = 82;
            this.dataGridView_AllCaseOrders.Size = new System.Drawing.Size(760, 1008);
            this.dataGridView_AllCaseOrders.TabIndex = 22;
            this.dataGridView_AllCaseOrders.Text = "dataGridView1";
            // 
            // dataGridView_selectedCaseOrders
            // 
            this.dataGridView_selectedCaseOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_selectedCaseOrders.Location = new System.Drawing.Point(1401, 258);
            this.dataGridView_selectedCaseOrders.Name = "dataGridView_selectedCaseOrders";
            this.dataGridView_selectedCaseOrders.RowHeadersWidth = 82;
            this.dataGridView_selectedCaseOrders.Size = new System.Drawing.Size(896, 1013);
            this.dataGridView_selectedCaseOrders.TabIndex = 23;
            this.dataGridView_selectedCaseOrders.Text = "dataGridView2";
            // 
            // dataGridView_selectedBrokers
            // 
            this.dataGridView_selectedBrokers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_selectedBrokers.Location = new System.Drawing.Point(2408, 323);
            this.dataGridView_selectedBrokers.Name = "dataGridView_selectedBrokers";
            this.dataGridView_selectedBrokers.RowHeadersWidth = 82;
            this.dataGridView_selectedBrokers.Size = new System.Drawing.Size(404, 343);
            this.dataGridView_selectedBrokers.TabIndex = 24;
            this.dataGridView_selectedBrokers.Text = "dataGridView1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2703, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 40);
            this.button1.TabIndex = 25;
            this.button1.Text = "Vælg";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UC5AabentHus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView_selectedBrokers);
            this.Controls.Add(this.dataGridView_selectedCaseOrders);
            this.Controls.Add(this.dataGridView_AllCaseOrders);
            this.Controls.Add(this.btn_Assigned);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_RemoveHouse);
            this.Controls.Add(this.btn_ChooseHouse);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.btn_ShowExisting);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_brokers);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(3120, 1728);
            this.Name = "UC5AabentHus";
            this.Size = new System.Drawing.Size(3214, 1728);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AllCaseOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_selectedCaseOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_selectedBrokers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbo_brokers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ShowExisting;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_ChooseHouse;
        private System.Windows.Forms.Button btn_RemoveHouse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Assigned;
        private System.Windows.Forms.DataGridView dataGridView_AllCaseOrders;
        private System.Windows.Forms.DataGridView dataGridView_selectedCaseOrders;
        private System.Windows.Forms.DataGridView dataGridView_selectedBrokers;
        private System.Windows.Forms.Button button1;
    }
}
