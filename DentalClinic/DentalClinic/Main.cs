using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLib;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace DentalClinic
{
    public partial class frmMain : Form
    {
        //Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Family\Source\Repos\DentalClinic\DentalClinic\DentalClinic\DentalClinic.accdb
        SQLLib queri = new SQLLib("Microsoft.ACE.OLEDB.12.0;", "DentalClinic.accdb");

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Terminate program", "Confirm Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else { e.Cancel = true; }
            }
            else { e.Cancel = true; }
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            this.Hide();
            WinForms.About.Show();
        }

        private void mnuDebug_Click(object sender, EventArgs e)
        {
            WinForms.CommandLineInterface.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
