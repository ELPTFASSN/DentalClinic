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
    }
}
