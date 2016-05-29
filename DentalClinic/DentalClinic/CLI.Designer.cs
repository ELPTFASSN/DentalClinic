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
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dbGrid
            // 
            this.dbGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGrid.Location = new System.Drawing.Point(12, 12);
            this.dbGrid.Name = "dbGrid";
            this.dbGrid.Size = new System.Drawing.Size(712, 382);
            this.dbGrid.TabIndex = 0;
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(12, 413);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(712, 20);
            this.txtCommand.TabIndex = 1;
            // 
            // btnSQLExec
            // 
            this.btnSQLExec.Location = new System.Drawing.Point(195, 450);
            this.btnSQLExec.Name = "btnSQLExec";
            this.btnSQLExec.Size = new System.Drawing.Size(75, 23);
            this.btnSQLExec.TabIndex = 2;
            this.btnSQLExec.Text = "SQL Exec";
            this.btnSQLExec.UseVisualStyleBackColor = true;
            this.btnSQLExec.Click += new System.EventHandler(this.btnSQLExec_Click);
            // 
            // btnOLEExec
            // 
            this.btnOLEExec.Location = new System.Drawing.Point(446, 450);
            this.btnOLEExec.Name = "btnOLEExec";
            this.btnOLEExec.Size = new System.Drawing.Size(75, 23);
            this.btnOLEExec.TabIndex = 3;
            this.btnOLEExec.Text = "OLE Exec";
            this.btnOLEExec.UseVisualStyleBackColor = true;
            // 
            // frmCLI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 485);
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
    }
}