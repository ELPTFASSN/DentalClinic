namespace DentalClinic
{
    partial class frmEmployee
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusEmployee = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataPatient = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtPatientSearch = new System.Windows.Forms.TextBox();
            this.txtPatientFName = new System.Windows.Forms.TextBox();
            this.txtPatientMName = new System.Windows.Forms.TextBox();
            this.txtPatientLName = new System.Windows.Forms.TextBox();
            this.txtPatientAge = new System.Windows.Forms.TextBox();
            this.txtPatientAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EditBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPatientContact = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cboPatientSex = new System.Windows.Forms.ComboBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPatient)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusEmployee});
            this.statusStrip1.Location = new System.Drawing.Point(0, 451);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(881, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(66, 17);
            this.toolStripStatusLabel1.Text = "Logged in: ";
            // 
            // statusEmployee
            // 
            this.statusEmployee.Name = "statusEmployee";
            this.statusEmployee.Size = new System.Drawing.Size(12, 17);
            this.statusEmployee.Text = "-";
            // 
            // dataPatient
            // 
            this.dataPatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataPatient.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPatient.Location = new System.Drawing.Point(399, 50);
            this.dataPatient.Name = "dataPatient";
            this.dataPatient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPatient.Size = new System.Drawing.Size(470, 376);
            this.dataPatient.TabIndex = 1;
            this.dataPatient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPatient_CellContentClick);
            this.dataPatient.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataPatient_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search by:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Patient ID",
            "First Name",
            "Last Name"});
            this.comboBox1.Location = new System.Drawing.Point(95, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // txtPatientSearch
            // 
            this.txtPatientSearch.Location = new System.Drawing.Point(248, 53);
            this.txtPatientSearch.Name = "txtPatientSearch";
            this.txtPatientSearch.Size = new System.Drawing.Size(136, 20);
            this.txtPatientSearch.TabIndex = 4;
            this.txtPatientSearch.TextChanged += new System.EventHandler(this.txtPatientSearch_TextChanged);
            // 
            // txtPatientFName
            // 
            this.txtPatientFName.Location = new System.Drawing.Point(95, 137);
            this.txtPatientFName.Name = "txtPatientFName";
            this.txtPatientFName.Size = new System.Drawing.Size(136, 20);
            this.txtPatientFName.TabIndex = 5;
            // 
            // txtPatientMName
            // 
            this.txtPatientMName.Location = new System.Drawing.Point(95, 176);
            this.txtPatientMName.Name = "txtPatientMName";
            this.txtPatientMName.Size = new System.Drawing.Size(136, 20);
            this.txtPatientMName.TabIndex = 6;
            this.txtPatientMName.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtPatientLName
            // 
            this.txtPatientLName.Location = new System.Drawing.Point(95, 214);
            this.txtPatientLName.Name = "txtPatientLName";
            this.txtPatientLName.Size = new System.Drawing.Size(136, 20);
            this.txtPatientLName.TabIndex = 7;
            // 
            // txtPatientAge
            // 
            this.txtPatientAge.Location = new System.Drawing.Point(95, 256);
            this.txtPatientAge.Name = "txtPatientAge";
            this.txtPatientAge.Size = new System.Drawing.Size(136, 20);
            this.txtPatientAge.TabIndex = 8;
            // 
            // txtPatientAdd
            // 
            this.txtPatientAdd.Location = new System.Drawing.Point(95, 328);
            this.txtPatientAdd.Name = "txtPatientAdd";
            this.txtPatientAdd.Size = new System.Drawing.Size(136, 20);
            this.txtPatientAdd.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Middle Name:";
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(108, 403);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 23);
            this.EditBtn.TabIndex = 14;
            this.EditBtn.Text = "EDIT";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Age:";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(15, 403);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 16;
            this.AddBtn.Text = "ADD";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(200, 403);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(75, 23);
            this.DelBtn.TabIndex = 17;
            this.DelBtn.Text = "DELETE";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(881, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientToolStripMenuItem,
            this.scheduleToolStripMenuItem,
            this.inventoryToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.patientToolStripMenuItem.Text = "Patient";
            this.patientToolStripMenuItem.Click += new System.EventHandler(this.patientToolStripMenuItem_Click);
            // 
            // scheduleToolStripMenuItem
            // 
            this.scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            this.scheduleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.scheduleToolStripMenuItem.Text = "Schedule";
            this.scheduleToolStripMenuItem.Click += new System.EventHandler(this.scheduleToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Sex:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 373);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Contact:";
            // 
            // txtPatientContact
            // 
            this.txtPatientContact.Location = new System.Drawing.Point(95, 366);
            this.txtPatientContact.Name = "txtPatientContact";
            this.txtPatientContact.Size = new System.Drawing.Size(136, 20);
            this.txtPatientContact.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Patient ID:";
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(95, 97);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(136, 20);
            this.txtPatientID.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "CLEAR ALL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cboPatientSex
            // 
            this.cboPatientSex.FormattingEnabled = true;
            this.cboPatientSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboPatientSex.Location = new System.Drawing.Point(95, 296);
            this.cboPatientSex.Name = "cboPatientSex";
            this.cboPatientSex.Size = new System.Drawing.Size(136, 21);
            this.cboPatientSex.TabIndex = 26;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 473);
            this.Controls.Add(this.cboPatientSex);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPatientContact);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPatientAdd);
            this.Controls.Add(this.txtPatientAge);
            this.Controls.Add(this.txtPatientLName);
            this.Controls.Add(this.txtPatientMName);
            this.Controls.Add(this.txtPatientFName);
            this.Controls.Add(this.txtPatientSearch);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataPatient);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEmployee";
            this.Text = "Patient Profile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEmployee_FormClosing);
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPatient)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusEmployee;
        private System.Windows.Forms.DataGridView dataPatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtPatientSearch;
        private System.Windows.Forms.TextBox txtPatientFName;
        private System.Windows.Forms.TextBox txtPatientMName;
        private System.Windows.Forms.TextBox txtPatientLName;
        private System.Windows.Forms.TextBox txtPatientAge;
        private System.Windows.Forms.TextBox txtPatientAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPatientContact;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboPatientSex;
    }
}