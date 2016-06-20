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
        //SQLLib queri = new SQLLib("Microsoft.ACE.OLEDB.12.0;", "DentalClinic.accdb");
        
        //SQLLib sQuery = new SQLLib(".\\SQLEXPRESS", "DentalClinic");
        SQLLib sQuery = new SQLLib("OPENLAB-MKT-22", "DentalClinic");
        public frmMain()
        {
            InitializeComponent();
        }

        //string connString = @"Data Source=MKT106-SC-19;Initial Catalog=DentalClinic;Integrated Security=True";

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

        private void btnSignup_Click(object sender, EventArgs e)
        {
            WinForms.Main.Hide();
            WinForms.SignUp.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection connLogin = new SqlConnection(sQuery.ConnectString());
            sQuery.Command = @"select * from Staff where S_Username = '" + txtEmpUser.Text + "' AND S_Password = '" + txtEmpPass.Text + "' AND S_Restriction = '" + cboEmpRestriction.Text + "'";
            try
            {
                connLogin.Open();
                SqlCommand cmd = new SqlCommand(sQuery.Command, connLogin);
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    if (cboEmpRestriction.Text == "Administrator")
                    {
                        MessageBox.Show("Successfully Logged In", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        WinForms.Admin.Show();
                        WinForms.Main.Hide();
                        globals.setCredentials(txtEmpUser.Text,txtEmpPass.Text,cboEmpRestriction.Text);
                    
                    }
                    else if (cboEmpRestriction.Text == "Dentist")
                    {
                        MessageBox.Show("Successfully Logged In", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        WinForms.Dentist.Show();
                        WinForms.Main.Hide();
                        globals.setCredentials(txtEmpUser.Text, txtEmpPass.Text, cboEmpRestriction.Text);
                    }
                    else
                    {
                        MessageBox.Show("Successfully Logged In", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        WinForms.Patient.Show();
                        WinForms.Main.Hide();
                        globals.setCredentials(txtEmpUser.Text, txtEmpPass.Text, cboEmpRestriction.Text);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password!", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmpUser.Focus();
                    txtEmpPass.Clear();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connLogin.Close();
            }
        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            if (globals.Restriction != null)
            {
                mnuDebug.Enabled = globals.isAdministrator();
            }
        }

        private void frmMain_Load_1(object sender, EventArgs e)
        {

        }

        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinForms.SignUp.Show();
            WinForms.Main.Hide(); 
        }
    }
}
