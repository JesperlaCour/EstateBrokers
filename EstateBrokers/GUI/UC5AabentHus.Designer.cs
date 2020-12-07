
using System.Linq;
using System.Windows.Forms;

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
            this.dataGridView_selectedCaseOrders = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox_selectedBrokers = new System.Windows.Forms.ListBox();
            this.btn_clearBrokerList = new System.Windows.Forms.Button();
            this.dataGridView_AllCaseOrders = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_selectedCaseOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AllCaseOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 810);
            this.panel1.TabIndex = 0;
            // 
            // cbo_brokers
            // 
            this.cbo_brokers.FormattingEnabled = true;
            this.cbo_brokers.Location = new System.Drawing.Point(1297, 121);
            this.cbo_brokers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_brokers.Name = "cbo_brokers";
            this.cbo_brokers.Size = new System.Drawing.Size(147, 23);
            this.cbo_brokers.TabIndex = 2;
            this.cbo_brokers.SelectedIndexChanged += new System.EventHandler(this.cbo_brokers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(809, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Arrangere åbenthus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(218, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Adresse:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(863, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valgte huse";
            // 
            // btn_ShowExisting
            // 
            this.btn_ShowExisting.Location = new System.Drawing.Point(214, 46);
            this.btn_ShowExisting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ShowExisting.Name = "btn_ShowExisting";
            this.btn_ShowExisting.Size = new System.Drawing.Size(113, 22);
            this.btn_ShowExisting.TabIndex = 10;
            this.btn_ShowExisting.Text = "Se eksisterende";
            this.btn_ShowExisting.UseVisualStyleBackColor = true;
            this.btn_ShowExisting.Click += new System.EventHandler(this.btn_ShowExisting_Click);
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(218, 88);
            this.txt_address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(110, 23);
            this.txt_address.TabIndex = 11;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(333, 88);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(82, 22);
            this.btn_Search.TabIndex = 12;
            this.btn_Search.Text = "Søg";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_ChooseHouse
            // 
            this.btn_ChooseHouse.Location = new System.Drawing.Point(695, 305);
            this.btn_ChooseHouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ChooseHouse.Name = "btn_ChooseHouse";
            this.btn_ChooseHouse.Size = new System.Drawing.Size(79, 22);
            this.btn_ChooseHouse.TabIndex = 13;
            this.btn_ChooseHouse.Text = "Tilføj";
            this.btn_ChooseHouse.UseVisualStyleBackColor = true;
            this.btn_ChooseHouse.Click += new System.EventHandler(this.btn_ChooseHouse_Click);
            // 
            // btn_RemoveHouse
            // 
            this.btn_RemoveHouse.Location = new System.Drawing.Point(695, 349);
            this.btn_RemoveHouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_RemoveHouse.Name = "btn_RemoveHouse";
            this.btn_RemoveHouse.Size = new System.Drawing.Size(79, 22);
            this.btn_RemoveHouse.TabIndex = 14;
            this.btn_RemoveHouse.Text = "Fjern";
            this.btn_RemoveHouse.UseVisualStyleBackColor = true;
            this.btn_RemoveHouse.Click += new System.EventHandler(this.btn_RemoveHouse_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1297, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Mæglere";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1297, 338);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 23);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1297, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Åbenhus dato:";
            // 
            // btn_Assigned
            // 
            this.btn_Assigned.Location = new System.Drawing.Point(1297, 377);
            this.btn_Assigned.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Assigned.Name = "btn_Assigned";
            this.btn_Assigned.Size = new System.Drawing.Size(218, 48);
            this.btn_Assigned.TabIndex = 18;
            this.btn_Assigned.Text = "Tildel";
            this.btn_Assigned.UseVisualStyleBackColor = true;
            this.btn_Assigned.Click += new System.EventHandler(this.btn_Assigned_Click);
            // 
            // dataGridView_selectedCaseOrders
            // 
            this.dataGridView_selectedCaseOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_selectedCaseOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_selectedCaseOrders.Location = new System.Drawing.Point(793, 121);
            this.dataGridView_selectedCaseOrders.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dataGridView_selectedCaseOrders.Name = "dataGridView_selectedCaseOrders";
            this.dataGridView_selectedCaseOrders.RowHeadersWidth = 82;
            this.dataGridView_selectedCaseOrders.Size = new System.Drawing.Size(458, 475);
            this.dataGridView_selectedCaseOrders.TabIndex = 23;
            this.dataGridView_selectedCaseOrders.Text = "dataGridView2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1455, 121);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Vælg";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox_selectedBrokers
            // 
            this.listBox_selectedBrokers.FormattingEnabled = true;
            this.listBox_selectedBrokers.ItemHeight = 15;
            this.listBox_selectedBrokers.Location = new System.Drawing.Point(1297, 159);
            this.listBox_selectedBrokers.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.listBox_selectedBrokers.Name = "listBox_selectedBrokers";
            this.listBox_selectedBrokers.Size = new System.Drawing.Size(223, 94);
            this.listBox_selectedBrokers.TabIndex = 26;
            // 
            // btn_clearBrokerList
            // 
            this.btn_clearBrokerList.Location = new System.Drawing.Point(1433, 259);
            this.btn_clearBrokerList.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_clearBrokerList.Name = "btn_clearBrokerList";
            this.btn_clearBrokerList.Size = new System.Drawing.Size(81, 22);
            this.btn_clearBrokerList.TabIndex = 27;
            this.btn_clearBrokerList.Text = "Ryd liste";
            this.btn_clearBrokerList.UseVisualStyleBackColor = true;
            this.btn_clearBrokerList.Click += new System.EventHandler(this.btn_clearBrokerList_Click);
            // 
            // dataGridView_AllCaseOrders
            // 
            this.dataGridView_AllCaseOrders.AllowUserToAddRows = false;
            this.dataGridView_AllCaseOrders.AllowUserToDeleteRows = false;
            this.dataGridView_AllCaseOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_AllCaseOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AllCaseOrders.Location = new System.Drawing.Point(218, 121);
            this.dataGridView_AllCaseOrders.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dataGridView_AllCaseOrders.Name = "dataGridView_AllCaseOrders";
            this.dataGridView_AllCaseOrders.ReadOnly = true;
            this.dataGridView_AllCaseOrders.RowHeadersWidth = 82;
            this.dataGridView_AllCaseOrders.Size = new System.Drawing.Size(458, 475);
            this.dataGridView_AllCaseOrders.TabIndex = 22;
            this.dataGridView_AllCaseOrders.Text = "dataGridView1";
            // 
            // UC5AabentHus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_clearBrokerList);
            this.Controls.Add(this.listBox_selectedBrokers);
            this.Controls.Add(this.button1);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1680, 810);
            this.Name = "UC5AabentHus";
            this.Size = new System.Drawing.Size(1731, 810);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_selectedCaseOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AllCaseOrders)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox_selectedBrokers;
        private System.Windows.Forms.Button btn_clearBrokerList;
    }
}
