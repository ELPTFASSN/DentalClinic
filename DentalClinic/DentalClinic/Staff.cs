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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }


        SQLLib sQuery = new SQLLib(".\\SQLEXPRESS", "DentalClinic");

        void update()
        {
            dataStaff.AutoResizeColumns();


            dataStaff.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
            SqlConnection con;
            SqlDataAdapter adapt;
            DataTable dt;
            con = new SqlConnection(sQuery.ConnectString());
            con.Open();
            SqlConnection conn = new SqlConnection(sQuery.ConnectString());
            adapt = new SqlDataAdapter("select * from Staff", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataStaff.DataSource = dt;
            con.Close();
        }

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

        private void AddBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(sQuery.ConnectString());
            if (txtStaffID.Text != "" && txtStaffFName.Text != "" && txtStaffLName.Text != "" && txtStaffMName.Text != "" && txtStaffAddress.Text != "" && txtStaffContact.Text != "" && txtStaffUser.Text != "" && txtStaffPassword.Text != "")
            {
                conn.Open();
                sQuery.Command = "INSERT INTO Patient VALUES (" + txtStaffID.Text + " , '" + txtStaffLName.Text + "' , '" + txtStaffFName.Text + "' , '" + txtStaffMName.Text + "' , " + txtStaffAddress.Text + " , '" + txtStaffContact.Text + "' ,'" + txtStaffUser.Text + "' ,'" + txtStaffPassword.Text + "')";
                SqlCommand SDA = new SqlCommand(sQuery.Command, conn);
                try
                {
                    SDA.ExecuteNonQuery();
                    MessageBox.Show("Added Successfully!");
                    txtStaffID.Text = "";
                    txtStaffFName.Text = "";
                    txtStaffLName.Text = "";
                    txtStaffAddress.Text = "";
                    txtStaffContact.Text = "";
                    txtStaffUser.Text = "";
                    txtStaffMName.Text = "";
                    txtStaffPassword.Text = "";
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

        private void EditBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sQuery.ConnectString());
            if (txtStaffID.Text != "" && txtStaffFName.Text != "" && txtStaffLName.Text != "" && txtStaffMName.Text != "" && txtStaffAddress.Text != "" && txtStaffContact.Text != "" && txtStaffUser.Text != "" && txtStaffPassword.Text != "")
            {
                con.Open();
                SqlDataAdapter SDA = new SqlDataAdapter("UPDATE Patient SET PatientID=" + txtStaffID.Text + ", P_FName='" + txtStaffFName.Text + "', P_LName='" + txtStaffLName.Text + "', P_MName='"
                    + txtStaffMName.Text + "', P_Age = " + txtStaffAddress.Text + ", P_Sex='" + txtStaffUser.Text + "', P_Add ='" + txtStaffPassword.Text + "', P_Contact='" + txtStaffContact.Text + "'WHERE PatientID=" + txtStaffID.Text + "", con);
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

        private void DelBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sQuery.ConnectString());
            con.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("DELETE FROM Patient WHERE PatientID = '" + txtStaffID.Text + "'", con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            update();
            MessageBox.Show("Deleted Successfully!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtStaffID.Text = "";
            txtStaffFName.Text = "";
            txtStaffLName.Text = "";
            txtStaffAddress.Text = "";
            txtStaffContact.Text = "";
            txtStaffUser.Text = "";
            txtStaffMName.Text = "";
            txtStaffPassword.Text = "";
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            dataStaff.AutoResizeColumns();


            dataStaff.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
            SqlConnection con;
            SqlDataAdapter adapt;
            DataTable dt;
            con = new SqlConnection(sQuery.ConnectString());
            con.Open();
            SqlConnection conn = new SqlConnection(sQuery.ConnectString());
            adapt = new SqlDataAdapter("select * from Staff", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataStaff.DataSource = dt;
            con.Close();
        }

        private void txtPatientSearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con;
            SqlDataAdapter adapt;
            DataTable dt;
            con = new SqlConnection(sQuery.ConnectString());
            con.Open();

            SqlConnection conn = new SqlConnection(sQuery.ConnectString());
            if (comboBox1.Text == "Staff ID")
            {
                adapt = new SqlDataAdapter("select * from Patient where StaffID like '" + txtStaffSearch.Text + "%'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataStaff.DataSource = dt;
                con.Close();
            }

            else if (comboBox1.Text == "First Name")
            {
                adapt = new SqlDataAdapter("select * from Patient where P_FName like '" + txtStaffSearch.Text + "%'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataStaff.DataSource = dt;
                con.Close();
            }

            else
            {
                adapt = new SqlDataAdapter("select * from Patient where P_LName like '" + txtStaffSearch.Text + "%'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataStaff.DataSource = dt;
                con.Close();
            }

        }

        private void dataStaff_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtStaffID.Text = dataStaff.SelectedRows[0].Cells[0].Value.ToString();
            txtStaffFName.Text = dataStaff.SelectedRows[0].Cells[1].Value.ToString();
            txtStaffLName.Text = dataStaff.SelectedRows[0].Cells[2].Value.ToString();
            txtStaffMName.Text = dataStaff.SelectedRows[0].Cells[3].Value.ToString();
            txtStaffAddress.Text = dataStaff.SelectedRows[0].Cells[4].Value.ToString();
            txtStaffContact.Text = dataStaff.SelectedRows[0].Cells[5].Value.ToString();
            txtStaffUser.Text = dataStaff.SelectedRows[0].Cells[6].Value.ToString();
            txtStaffPassword.Text = dataStaff.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void Staff_FormClosing(object sender, FormClosingEventArgs e)
        {
            WinForms.Main.Show();
            WinForms.Staff.Hide();
        }

        private void Staff_Activated(object sender, EventArgs e)
        {
            if (globals.Restriction != null)
            {
                mnuAdmin.Visible = globals.isAdministrator();
            }
        }

        private void mnuAdmin_Click(object sender, EventArgs e)
        {
            WinForms.Admin.Show();
            WinForms.Admin.Hide();
        }
    }
}
