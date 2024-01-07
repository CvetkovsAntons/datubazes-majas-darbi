using System.Drawing;
using System.Windows.Forms;

namespace AK_IT_P_Ns_2_AntonsCvetkovs_3md
{
    partial class Form1
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

        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ClientButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SessionButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.GymButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.SportButton = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.GymSportButton = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.deleteAllButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableNameText = new System.Windows.Forms.Label();
            this.totalRowsText = new System.Windows.Forms.Label();
            this.totalRowsCountText = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchDropDown = new System.Windows.Forms.ComboBox();
            this.importDataButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(171, 560);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 56);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "3. majas darbs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Antons Cvetkovs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IT-P-Ns-2";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ClientButton);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(3, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 35);
            this.panel2.TabIndex = 1;
            // 
            // ClientButton
            // 
            this.ClientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.ClientButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ClientButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientButton.Location = new System.Drawing.Point(-3, -8);
            this.ClientButton.Name = "ClientButton";
            this.ClientButton.Size = new System.Drawing.Size(178, 50);
            this.ClientButton.TabIndex = 5;
            this.ClientButton.Text = "Clients";
            this.ClientButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClientButton.UseVisualStyleBackColor = false;
            this.ClientButton.Click += new System.EventHandler(this.loadTableData);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(-3, -10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(182, 50);
            this.button5.TabIndex = 4;
            this.button5.Text = "Clients";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(3, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Clients";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.SessionButton);
            this.panel3.Location = new System.Drawing.Point(3, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(169, 35);
            this.panel3.TabIndex = 2;
            // 
            // SessionButton
            // 
            this.SessionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.SessionButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SessionButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SessionButton.Location = new System.Drawing.Point(-3, -8);
            this.SessionButton.Name = "SessionButton";
            this.SessionButton.Size = new System.Drawing.Size(183, 50);
            this.SessionButton.TabIndex = 1;
            this.SessionButton.Text = "Sessions";
            this.SessionButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SessionButton.UseVisualStyleBackColor = false;
            this.SessionButton.Click += new System.EventHandler(this.loadTableData);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.GymButton);
            this.panel4.Location = new System.Drawing.Point(3, 147);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(169, 35);
            this.panel4.TabIndex = 3;
            // 
            // GymButton
            // 
            this.GymButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.GymButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.GymButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GymButton.Location = new System.Drawing.Point(-3, -8);
            this.GymButton.Name = "GymButton";
            this.GymButton.Size = new System.Drawing.Size(182, 50);
            this.GymButton.TabIndex = 2;
            this.GymButton.Text = "Gyms";
            this.GymButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GymButton.UseVisualStyleBackColor = false;
            this.GymButton.Click += new System.EventHandler(this.loadTableData);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.SportButton);
            this.panel5.Location = new System.Drawing.Point(3, 188);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(169, 35);
            this.panel5.TabIndex = 4;
            // 
            // SportButton
            // 
            this.SportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.SportButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SportButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SportButton.Location = new System.Drawing.Point(-3, -8);
            this.SportButton.Name = "SportButton";
            this.SportButton.Size = new System.Drawing.Size(181, 50);
            this.SportButton.TabIndex = 3;
            this.SportButton.Text = "Sports";
            this.SportButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SportButton.UseVisualStyleBackColor = false;
            this.SportButton.Click += new System.EventHandler(this.loadTableData);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.GymSportButton);
            this.panel7.Location = new System.Drawing.Point(3, 229);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(169, 35);
            this.panel7.TabIndex = 5;
            // 
            // GymSportButton
            // 
            this.GymSportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.GymSportButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.GymSportButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GymSportButton.Location = new System.Drawing.Point(-3, -8);
            this.GymSportButton.Name = "GymSportButton";
            this.GymSportButton.Size = new System.Drawing.Size(181, 50);
            this.GymSportButton.TabIndex = 3;
            this.GymSportButton.Text = "GymSports";
            this.GymSportButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GymSportButton.UseVisualStyleBackColor = false;
            this.GymSportButton.Click += new System.EventHandler(this.loadTableData);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.deleteAllButton);
            this.panel6.Location = new System.Drawing.Point(3, 270);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(169, 35);
            this.panel6.TabIndex = 5;
            // 
            // deleteAllButton
            // 
            this.deleteAllButton.BackColor = System.Drawing.Color.Red;
            this.deleteAllButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.deleteAllButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteAllButton.Location = new System.Drawing.Point(-3, -8);
            this.deleteAllButton.Name = "deleteAllButton";
            this.deleteAllButton.Size = new System.Drawing.Size(181, 50);
            this.deleteAllButton.TabIndex = 3;
            this.deleteAllButton.Text = "Delete All";
            this.deleteAllButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteAllButton.UseVisualStyleBackColor = false;
            this.deleteAllButton.Click += new System.EventHandler(this.deleteAllButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(183, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(741, 453);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Visible = false;
            // 
            // tableNameText
            // 
            this.tableNameText.AutoSize = true;
            this.tableNameText.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.tableNameText.Location = new System.Drawing.Point(178, 3);
            this.tableNameText.Name = "tableNameText";
            this.tableNameText.Size = new System.Drawing.Size(0, 51);
            this.tableNameText.TabIndex = 2;
            // 
            // totalRowsText
            // 
            this.totalRowsText.AutoSize = true;
            this.totalRowsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.totalRowsText.Location = new System.Drawing.Point(379, 24);
            this.totalRowsText.Name = "totalRowsText";
            this.totalRowsText.Size = new System.Drawing.Size(98, 24);
            this.totalRowsText.TabIndex = 3;
            this.totalRowsText.Text = "total rows: ";
            this.totalRowsText.Visible = false;
            // 
            // totalRowsCountText
            // 
            this.totalRowsCountText.AutoSize = true;
            this.totalRowsCountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.totalRowsCountText.Location = new System.Drawing.Point(467, 24);
            this.totalRowsCountText.Name = "totalRowsCountText";
            this.totalRowsCountText.Size = new System.Drawing.Size(20, 24);
            this.totalRowsCountText.TabIndex = 4;
            this.totalRowsCountText.Text = "0";
            this.totalRowsCountText.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(179, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Search:";
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(240, 75);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(166, 20);
            this.searchInput.TabIndex = 7;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(412, 73);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchDropDown
            // 
            this.searchDropDown.FormattingEnabled = true;
            this.searchDropDown.Location = new System.Drawing.Point(183, 51);
            this.searchDropDown.Name = "searchDropDown";
            this.searchDropDown.Size = new System.Drawing.Size(304, 21);
            this.searchDropDown.TabIndex = 9;
            // 
            // importDataButton
            // 
            this.importDataButton.Location = new System.Drawing.Point(930, 69);
            this.importDataButton.Name = "importDataButton";
            this.importDataButton.Size = new System.Drawing.Size(106, 23);
            this.importDataButton.TabIndex = 10;
            this.importDataButton.Text = "Import Data";
            this.importDataButton.UseVisualStyleBackColor = true;
            this.importDataButton.Click += new System.EventHandler(this.importDataButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(930, 40);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(106, 23);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(930, 98);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(106, 23);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(930, 14);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(106, 23);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Save changes";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 560);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.importDataButton);
            this.Controls.Add(this.searchDropDown);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totalRowsCountText);
            this.Controls.Add(this.totalRowsText);
            this.Controls.Add(this.tableNameText);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private FlowLayoutPanel flowLayoutPanel1;
        private Button button2;
        private Panel panel2;
        private Button ClientButton;
        private Button button5;
        private Panel panel3;
        private Button SessionButton;
        private Panel panel4;
        private Button GymButton;
        private Panel panel5;
        private Button SportButton;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Label tableNameText;
        private Label totalRowsText;
        private Label totalRowsCountText;
        private Label label4;
        private TextBox searchInput;
        private Button searchButton;
        private ComboBox searchDropDown;
        private Panel panel6;
        private Button deleteAllButton;
        private Button importDataButton;
        private Panel panel7;
        private Button GymSportButton;
        private Button deleteButton;
        private Button addButton;
        private Button saveButton;
    }
}

