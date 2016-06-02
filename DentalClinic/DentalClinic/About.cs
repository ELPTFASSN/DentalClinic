using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinic
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void frmAbout_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                WinForms.Main.Show();
                this.Hide();
            }
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            globals.displayDevInfo(lblDev1Name, lblDev1Position, imgDev1);
            globals.displayDevInfo(lblDev2Name, lblDev2Position, imgDev2);
            globals.displayDevInfo(lblDev3Name, lblDev3Position, imgDev3);
            globals.displayDevInfo(lblDev4Name, lblDev4Position, imgDev4);
        }
    }
}
