using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SQLib;
using OLELib;
using System.Data.SqlClient;

namespace DentalClinic
{
    public partial class frmDentist : Form
    {
        /// <summary>
        /// Connection String
        /// </summary>
        SQLLib sQuery = new SQLLib(".\\SQLEXPRESS", "DentalClinic");
        //
        public frmDentist()
        {
            InitializeComponent();
        }

        private void frmDentist_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                WinForms.Main.Show();
                WinForms.Dentist.Hide();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            globals.addSchedule(txtSchedID, dtDate, dtTime, txtDescription, datagridSched);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            globals.removeSchedule(datagridSched);
        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinForms.Patient.Show();
            WinForms.Dentist.Hide();  
        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinForms.Inventory.Show();
            WinForms.Dentist.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinForms.Main.Show();
            WinForms.Dentist.Hide(); 
        }

        private void frmDentist_Load(object sender, EventArgs e)
        {

        }

        private void frmDentist_Activated(object sender, EventArgs e)
        {
            statusDentist.Text = globals.Username;
            sQuery.CommandExec("SELECT * FROM Schedule", datagridSched);
            if (globals.Restriction != null)
            {
                mnuAdmin.Visible = globals.isAdministrator();
            }
        }

        private void mnuAdmin_Click(object sender, EventArgs e)
        {
            WinForms.Admin.Show();
            WinForms.Dentist.Hide();
        }
    }
}
