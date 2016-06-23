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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }


        SQLLib sQuery = new SQLLib("OPENLAB-MKT-22", "DentalClinic");

        void update()
        {
            SqlConnection con;
            SqlDataAdapter adapt;
            DataTable dt;
            con = new SqlConnection(sQuery.ConnectString());
            con.Open();
            SqlConnection conn = new SqlConnection(sQuery.ConnectString());
            adapt = new SqlDataAdapter("select * from Inventory", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataInventory.DataSource = dt;
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(sQuery.ConnectString());
            if (txtInvID.Text != "" && txtInvName.Text != "" && txtInvQty.Text != "")
            {
                conn.Open();
                sQuery.Command = "INSERT INTO INVENTORY VALUES (" + txtInvID.Text + " , '" + txtInvName.Text + "' , '" + txtInvQty.Text + "')";
                SqlCommand SDA = new SqlCommand(sQuery.Command, conn);
                try
                {
                    SDA.ExecuteNonQuery();
                    MessageBox.Show("Added Successfully!");
                    txtInvID.Text = "";
                    txtInvName.Text = "";
                    txtInvQty.Text = "";
   
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sQuery.ConnectString());
            if (txtInvID.Text != "" && txtInvName.Text != "" && txtInvQty.Text != "")
            {
                con.Open();
                SqlDataAdapter SDA = new SqlDataAdapter("UPDATE Inventory SET InventoryID=" + txtInvID.Text + ", Inv_Name='" + txtInvName.Text + "', Inv_Quantity='" + txtInvQty.Text + "'WHERE InventoryID=" + txtInvID.Text + "", con);
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

        private void Inventory_Load(object sender, EventArgs e)
        {
            update();
        }

        private void dataInventory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtInvID.Text = dataInventory.SelectedRows[0].Cells[0].Value.ToString();
            txtInvName.Text = dataInventory.SelectedRows[0].Cells[1].Value.ToString();
            txtInvQty.Text = dataInventory.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sQuery.ConnectString());
            con.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("DELETE FROM Inventory WHERE InventoryID = '" + txtInvID.Text + "'", con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            update();
            MessageBox.Show("Deleted Successfully!");
        }

        private void txtInvSearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con;
            SqlDataAdapter adapt;
            DataTable dt;
            con = new SqlConnection(sQuery.ConnectString());
            con.Open();

            SqlConnection conn = new SqlConnection(sQuery.ConnectString());
            if (comboBox1.Text == "ID")
            {
                adapt = new SqlDataAdapter("select * from Inventory where InventoryID like '" + txtInvSearch.Text + "%'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataInventory.DataSource = dt;
                con.Close();
            }

            else if (comboBox1.Text == "Name")
            {
                adapt = new SqlDataAdapter("select * from Inventory where Inv_Name like '" + txtInvSearch.Text + "%'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataInventory.DataSource = dt;
                con.Close();
            }

            else
            {
                adapt = new SqlDataAdapter("select * from Inventory where Inv_Quantity like '" + txtInvSearch.Text + "%'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataInventory.DataSource = dt;
                con.Close();
            }

        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinForms.Staff.Show();
            WinForms.Inventory.Hide();  
        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinForms.Dentist.Show();
            WinForms.Inventory.Hide();                    
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinForms.Main.Show();
            WinForms.Inventory.Hide();  
        }

        private void Inventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                WinForms.Main.Show();
                WinForms.Inventory.Hide();
            }
        }
    }
}
