using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using SQLib;
using OLELib;
using System.IO;

namespace DentalClinic
{
    public partial class Signup : Form
    {
        SQLLib sQuery = new SQLLib("OPENLAB-MKT-22", "DentalClinic");
        OLib oQuery = new OLib("Microsoft.ACE.OLEDB.12.0", "DentalClinic.accdb");
        public Signup()
        {
            InitializeComponent();
        }
        //Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Family\Source\Repos\DentalClinic\DentalClinic\DentalClinic\DentalClinic.accdb
        //string connString = @"Data Source=MKT106-SC-19;Initial Catalog=DentalClinic;Integrated Security=True";
        protected string DBFileName = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = " + Path.GetFullPath(".\\") + "DentalClinic.accdb";
        public void insertData(int sID, string sLast, string sFirst, int sAge, int sContact, string sUser, string sPass, string sRestrict)
        {
            OleDbConnection DBConnection = new OleDbConnection(DBFileName);
            //DBConnection.ConnectionString = DBFileName;

            OleDbCommand DBCommand = new OleDbCommand("INSERT into Staff (StaffID, S_LName, S_FName, S_Age, S_Contact, S_Username, S_Password, S_Restriction) Values(@sID, @sLast, @sFirst, @sAge, @sContact, @sUser, @sPass, @sRestrict)",DBConnection);
            //DBCommand.Connection = DBConnection;
            DBConnection.Open();
            if (DBConnection.State == ConnectionState.Open)
            {
                DBCommand.Parameters.Add("@StaffID", OleDbType.Integer).Value = sID;
                DBCommand.Parameters.Add("@S_LName", OleDbType.VarChar).Value = sLast;
                DBCommand.Parameters.Add("@S_FName", OleDbType.VarChar).Value = sFirst;
                DBCommand.Parameters.Add("@S_Age", OleDbType.Integer).Value = sAge;
                DBCommand.Parameters.Add("@S_Contact", OleDbType.Integer).Value = sContact;
                DBCommand.Parameters.Add("@S_Username", OleDbType.VarChar).Value = sUser;
                DBCommand.Parameters.Add("@S_Password", OleDbType.VarChar).Value = sPass;
                DBCommand.Parameters.Add("@S_Restriction", OleDbType.VarChar).Value = sRestrict;
                try
                {
                    DBCommand.ExecuteNonQuery();
                    MessageBox.Show("Data Added successfully!");
                    DBConnection.Close();

                }
                catch (OleDbException DB_Exception)
                {
                    MessageBox.Show(DB_Exception.Source + "\n" + DB_Exception.Message);
                }
                finally
                {
                    DBConnection.Close();
                }
            }
            else
            {
                MessageBox.Show("Something's wrong with Database connection, Check Directory.");
            }
        }
        private void btnSignup_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(sQuery.ConnectString());

            if (txtEmpCode.Text != "" && txtEmpFName.Text != "" && txtEmpLName.Text != "" && txtEmpAge.Text != "" && txtEmpContact.Text != "" && txtEmpUser.Text != "" && txtEmpPass.Text != "" && cboEmpRestriction.Text != "")
            {
                //insertData(Convert.ToInt32(txtEmpCode.Text), txtEmpLName.Text, txtEmpFName.Text, Convert.ToInt32(txtEmpAge.Text), Convert.ToInt32(txtEmpContact.Text), txtEmpUser.Text, txtEmpPass.Text, cboEmpRestriction.Text);
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

        private void btnTest_Click(object sender, EventArgs e)
        {
            insertData(123, "Last", "First", 12, 123456, "aaa", "123","Administrator");

        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtEmpCode.Text = "";
            txtEmpFName.Text = "";
            txtEmpLName.Text = "";
            txtEmpAge.Text = "";
            txtEmpContact.Text = "";
            txtEmpUser.Text = "";
            txtEmpPass.Text = "";
            cboEmpRestriction.Text = "";
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }
    }
}
