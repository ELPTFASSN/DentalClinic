namespace DentalClinic
{
    partial class frmCLI
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
            this.dbGrid = new System.Windows.Forms.DataGridView();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.btnSQLExec = new System.Windows.Forms.Button();
            this.btnOLEExec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataProvider = new System.Windows.Forms.TextBox();
            this.txtDataSource = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dbGrid
            // 
            this.dbGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGrid.Location = new System.Drawing.Point(12, 69);
            this.dbGrid.Name = "dbGrid";
            this.dbGrid.Size = new System.Drawing.Size(712, 382);
            this.dbGrid.TabIndex = 0;
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(12, 470);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(712, 20);
            this.txtCommand.TabIndex = 1;
            // 
            // btnSQLExec
            // 
            this.btnSQLExec.Location = new System.Drawing.Point(195, 507);
            this.btnSQLExec.Name = "btnSQLExec";
            this.btnSQLExec.Size = new System.Drawing.Size(75, 23);
            this.btnSQLExec.TabIndex = 2;
            this.btnSQLExec.Text = "SQL Exec";
            this.btnSQLExec.UseVisualStyleBackColor = true;
            this.btnSQLExec.Click += new System.EventHandler(this.btnSQLExec_Click);
            // 
            // btnOLEExec
            // 
            this.btnOLEExec.Location = new System.Drawing.Point(446, 507);
            this.btnOLEExec.Name = "btnOLEExec";
            this.btnOLEExec.Size = new System.Drawing.Size(75, 23);
            this.btnOLEExec.TabIndex = 3;
            this.btnOLEExec.Text = "OLE Exec";
            this.btnOLEExec.UseVisualStyleBackColor = true;
            this.btnOLEExec.Click += new System.EventHandler(this.btnOLEExec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data Provider";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data Source";
            // 
            // txtDataProvider
            // 
            this.txtDataProvider.Location = new System.Drawing.Point(109, 8);
            this.txtDataProvider.Name = "txtDataProvider";
            this.txtDataProvider.Size = new System.Drawing.Size(615, 20);
            this.txtDataProvider.TabIndex = 6;
            this.txtDataProvider.Text = ".\\SQLEXPRESS";
            this.txtDataProvider.TextChanged += new System.EventHandler(this.txtDataProvider_TextChanged);
            // 
            // txtDataSource
            // 
            this.txtDataSource.Location = new System.Drawing.Point(109, 33);
            this.txtDataSource.Name = "txtDataSource";
            this.txtDataSource.Size = new System.Drawing.Size(615, 20);
            this.txtDataSource.TabIndex = 7;
            this.txtDataSource.Text = "Dentista";
            this.txtDataSource.TextChanged += new System.EventHandler(this.txtDataSource_TextChanged);
            // 
            // frmCLI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 545);
            this.Controls.Add(this.txtDataSource);
            this.Controls.Add(this.txtDataProvider);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOLEExec);
            this.Controls.Add(this.btnSQLExec);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.dbGrid);
            this.Name = "frmCLI";
            this.Text = "CLI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCLI_FormClosing);
            this.Load += new System.EventHandler(this.frmCLI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dbGrid;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Button btnSQLExec;
        private System.Windows.Forms.Button btnOLEExec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDataProvider;
        private System.Windows.Forms.TextBox txtDataSource;
    }
}