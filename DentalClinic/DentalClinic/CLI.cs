using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SQLib;

namespace DentalClinic
{
    public partial class frmCLI : Form
    {
        SQLLib queri = new SQLLib(".\\SQLEXPRESS", "Dentista");

        public frmCLI()
        {
            InitializeComponent();
        }

        private void frmCLI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void frmCLI_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSQLExec_Click(object sender, EventArgs e)
        {
            queri.CommandExec(txtCommand, dbGrid);
        }
    }
}
