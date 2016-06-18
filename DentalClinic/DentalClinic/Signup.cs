using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using SQLib;
using OLELib;

namespace DentalClinic
{
    public partial class Signup : Form
    {
        SQLLib sQuery = new SQLLib(".\\SQLEXPRESS", "DentalClinic");
        public Signup()
        {
            InitializeComponent();
        }

        //string connString = @"Data Source=MKT106-SC-19;Initial Catalog=DentalClinic;Integrated Security=True";

        private void btnSignup_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(sQuery.ConnectString());
            if (txtEmpCode.Text != "" && txtEmpFName.Text != "" && txtEmpLName.Text != "" && txtEmpAge.Text != "" && txtEmpContact.Text != "" && txtEmpUser.Text != "" && txtEmpPass.Text != "" && cboEmpRestriction.Text != "")
            {
                conn.Open();
                sQuery.Command = "INSERT INTO Staff VALUES (" + txtEmpCode.Text + " , '" + txtEmpFName.Text + "' , '" + txtEmpLName.Text + "' , '" + txtEmpAge.Text + "' , " + txtEmpContact.Text + " , '" + txtEmpUser.Text + "' ,'" + txtEmpPass.Text + "' ,'" + cboEmpRestriction.Text + "')";
                SqlCommand SDA = new SqlCommand(sQuery.Command, conn);
                try
                {
                    SDA.ExecuteNonQuery();
                    MessageBox.Show("Signup Successfully!");
                    txtEmpCode.Text = "";
                    txtEmpFName.Text = "";
                    txtEmpLName.Text = "";
                    txtEmpAge.Text = "";
                    txtEmpContact.Text = "";
                    txtEmpUser.Text = "";
                    txtEmpPass.Text = "";
                    cboEmpRestriction.Text = "";

                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Code!");
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Missing Values");
            }
        }

        private void Signup_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                WinForms.Main.Show();
                WinForms.SignUp.Hide();
            }
        }

        private void mnuFileLogin_Click(object sender, EventArgs e)
        {
            WinForms.Main.Show();
            WinForms.SignUp.Hide();
        }
    }
}
