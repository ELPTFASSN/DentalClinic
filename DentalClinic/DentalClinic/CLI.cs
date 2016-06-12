using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using OLELib;
using SQLib;

namespace DentalClinic
{
    public partial class frmCLI : Form
    {
        //Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\openlab-mkt-01\Source\Repos\DentalClinic\DentalClinic\DentalClinic\DentalClinic.accdb
        //Data Source=OPENLAB-MKT-01;Integrated Security=True
        //SQLLib sQuery = new SQLLib("OPENLAB-MKT-01", "Dentista");
        //OLib oQuery = new OLib(@"Microsoft.ACE.OLEDB.12.0;", @"C:\Users\openlab-mkt-01\Source\Repos\DentalClinic\DentalClinic\DentalClinic\DentalClinic.accdb");

        SQLLib sQuery;
        OLib oQuery = new OLib(@"Microsoft.ACE.OLEDB.12.0;", @"C:\Users\openlab-mkt-01\Source\Repos\DentalClinic\DentalClinic\DentalClinic\DentalClinic.accdb");
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
            txtDataProvider.Text = globals.DataProvider;
            txtDataSource.Text = globals.DataSource;
        }

        private void btnSQLExec_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(sQuery.ConnectString());
            sQuery = new SQLLib(txtDataProvider.Text, txtDataSource.Text);
            sQuery.CommandExec(txtCommand, dbGrid);
        }

        private void btnOLEExec_Click(object sender, EventArgs e)
        {
            oQuery.CommandExec(txtCommand.Text, dbGrid);
        }

        private void txtDataProvider_TextChanged(object sender, EventArgs e)
        {
            globals.DataProvider = txtDataProvider.Text;
        }

        private void txtDataSource_TextChanged(object sender, EventArgs e)
        {
            globals.DataSource = txtDataSource.Text;
        }
    }
}
