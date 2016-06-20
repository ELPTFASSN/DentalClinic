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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinForms.Dentist.Show();
            WinForms.Staff.Hide();
        }

     /*   private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinForms.Dentist.Show();
            WinForms.Staff.Hide();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinForms.Dentist.Show();
            WinForms.Staff.Hide();
        }
*/
        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinForms.Patient.Show();
            WinForms.Staff.Hide();
        }

        private void scheduleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            WinForms.Dentist.Show();
            WinForms.Staff.Hide();
        }

        private void inventoryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            WinForms.Inventory.Show();
            WinForms.Staff.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinForms.Main.Show();
            WinForms.Staff.Hide();
        }
    }
}
