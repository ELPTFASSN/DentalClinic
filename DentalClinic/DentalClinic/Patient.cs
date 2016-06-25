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
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        SQLLib sQuery = new SQLLib(".\\SQLEXPRESS", "DentalClinic");

        void update()
        {
            dataPatient.AutoResizeColumns();


            dataPatient.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
            SqlConnection con;
            SqlDataAdapter adapt;
            DataTable dt;
            con = new SqlConnection(sQuery.ConnectString());
            con.Open();
            SqlConnection conn = new SqlConnection(sQuery.ConnectString());
            adapt = new SqlDataAdapter("select * from Patient", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataPatient.DataSource = dt;
            con.Close();
        }

        private void frmEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                WinForms.Main.Show();
                WinForms.Patient.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            dataPatient.AutoResizeColumns();


            dataPatient.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
            SqlConnection con;
            SqlDataAdapter adapt;
            DataTable dt;
            con = new SqlConnection(sQuery.ConnectString());
            con.Open();
            SqlConnection conn = new SqlConnection(sQuery.ConnectString());
            adapt = new SqlDataAdapter("select * from Patient", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataPatient.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(sQuery.ConnectString());
            if (txtPatientID.Text != "" && txtPatientFName.Text != "" && txtPatientLName.Text != "" && txtPatientMName.Text != "" && txtPatientAge.Text != "" && cboPatientSex.Text != "" && txtPatientAdd.Text != "" && txtPatientContact.Text != "")
            {
                conn.Open();
                sQuery.Command = "INSERT INTO Patient VALUES (" + txtPatientID.Text + " , '" + txtPatientLName.Text + "' , '" + txtPatientFName.Text + "' , '" + txtPatientMName.Text + "' , " + txtPatientAge.Text + " , '" + cboPatientSex.Text + "' ,'" + txtPatientAdd.Text + "' ,'" + txtPatientContact.Text + "')";
                SqlCommand SDA = new SqlCommand(sQuery.Command, conn);
                try
                {
                    SDA.ExecuteNonQuery();
                    MessageBox.Show("Added Successfully!");
                    txtPatientID.Text = "";
                    txtPatientFName.Text = "";
                    txtPatientLName.Text = "";
                    txtPatientAge.Text = "";
                    txtPatientContact.Text = "";
                    txtPatientAdd.Text = "";
                    txtPatientMName.Text = "";
                    cboPatientSex.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Missing Values!");
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Invalid Values!");
            }

            update();

        }

        private void EditBtn_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sQuery.ConnectString());
            if (txtPatientID.Text != "" && txtPatientFName.Text != "" && txtPatientLName.Text != "" && txtPatientMName.Text != "" && txtPatientAge.Text != "" && cboPatientSex.Text != "" && txtPatientAdd.Text != "" && txtPatientContact.Text != "")
            {
                con.Open();
                SqlDataAdapter SDA = new SqlDataAdapter("UPDATE Patient SET PatientID=" + txtPatientID.Text + ", P_FName='" + txtPatientFName.Text + "', P_LName='" + txtPatientLName.Text + "', P_MName='"
                    + txtPatientMName.Text + "', P_Age = " + txtPatientAge.Text + ", P_Sex='" + cboPatientSex.Text + "', P_Add ='" + txtPatientAdd.Text + "', P_Contact='" + txtPatientContact.Text + "'WHERE PatientID=" + txtPatientID.Text + "", con);
                SDA.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully!");
                con.Close();
            }
            else
            {
                MessageBox.Show("Missing Values!");
            }
            update();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinForms.Main.Show();
            WinForms.Patient.Hide();  
        }

        private void txtPatientSearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con;
            SqlDataAdapter adapt;
            DataTable dt;
            con = new SqlConnection(sQuery.ConnectString());
            con.Open();

            SqlConnection conn = new SqlConnection(sQuery.ConnectString());
            if (comboBox1.Text == "Patient ID")
            {
                adapt = new SqlDataAdapter("select * from Patient where PatientID like '" + txtPatientSearch.Text + "%'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataPatient.DataSource = dt;
                con.Close();
            }

            else if (comboBox1.Text == "First Name")
            {
                adapt = new SqlDataAdapter("select * from Patient where P_FName like '" + txtPatientSearch.Text + "%'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataPatient.DataSource = dt;
                con.Close();
            }

            else 
            {
                adapt = new SqlDataAdapter("select * from Patient where P_LName like '" + txtPatientSearch.Text + "%'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataPatient.DataSource = dt;
                con.Close();
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtPatientID.Text = "";
            txtPatientFName.Text = "";
            txtPatientLName.Text = "";
            txtPatientAge.Text = "";
            txtPatientContact.Text = "";
            txtPatientAdd.Text = "";
            txtPatientMName.Text = "";
            cboPatientSex.Text = "";
        }

        private void dataPatient_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtPatientID.Text = dataPatient.SelectedRows[0].Cells[0].Value.ToString();
            txtPatientFName.Text = dataPatient.SelectedRows[0].Cells[1].Value.ToString();
            txtPatientMName.Text = dataPatient.SelectedRows[0].Cells[2].Value.ToString();
            txtPatientLName.Text = dataPatient.SelectedRows[0].Cells[3].Value.ToString();
            txtPatientAge.Text = dataPatient.SelectedRows[0].Cells[4].Value.ToString();
            cboPatientSex.Text = dataPatient.SelectedRows[0].Cells[5].Value.ToString();
            txtPatientAdd.Text = dataPatient.SelectedRows[0].Cells[6].Value.ToString();
            txtPatientContact.Text = dataPatient.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sQuery.ConnectString());
            con.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("DELETE FROM Patient WHERE PatientID = '" + txtPatientID.Text + "'", con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            update();
            MessageBox.Show("Deleted Successfully!");
        }

        private void dataPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinForms.Dentist.Show();
            WinForms.Patient.Hide();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinForms.Inventory.Show();
            WinForms.Patient.Hide();
           
        }

        private void frmEmployee_Activated(object sender, EventArgs e)
        {
            if (globals.Restriction != null)
            {
                mnuAdmin.Visible = globals.isAdministrator();
            }
        }

        private void mnuAdmin_Click(object sender, EventArgs e)
        {
            WinForms.Admin.Show();
            WinForms.Patient.Hide();
        }
    }
}
