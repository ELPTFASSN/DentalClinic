using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DentalClinic
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }



        string connString = @"Data Source=MKT106-SC-19;Initial Catalog=DentalClinic;Integrated Security=True";




        private void Signup_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connString);
            if (txtEmpCode.Text != "" && txtEmpFName.Text != "" && txtEmpLName.Text != "" && txtEmpAge.Text != "" && txtEmpContact.Text != "" && txtEmpUser.Text != "" && txtEmpPass.Text != "" && cboEmpRestriction.Text != "")
            {
                con.Open();
                SqlCommand SDA = new SqlCommand("INSERT INTO EMPLOYEE VALUES (" + txtEmpCode.Text + " , '" + txtEmpFName.Text + "' , '" + txtEmpLName.Text + "' , '" + txtEmpAge.Text + "' , " + txtEmpContact.Text + " , '" + txtEmpUser.Text + "' ,'" + txtEmpPass.Text + "' ,'" + cboEmpRestriction.Text + "')", con);
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
                con.Close();
            }
            else
            {
                MessageBox.Show("Missing Values");
            }
        }
    }
}
