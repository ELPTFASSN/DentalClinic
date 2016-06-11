using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DentalClinic
{
    public partial class frmDentist : Form
    {
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
    }
}
