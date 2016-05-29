using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLib;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace SQLib
{
    public class SQLLib:SQLConnect,Interface.iCommand
    {
        //Data Source=FAMILY-PC\SQLEXPRESS;Initial Catalog=EX_5;Integrated Security=True

        /// <summary>
        /// SQLLib default constructor
        /// </summary>
        public SQLLib()
        { }

        /// <summary>
        /// SQLLib constructor with parameters
        /// </summary>
        /// <param name="serverName"></param>
        /// <param name="databaseName"></param>
        public SQLLib(string serverName, string databaseName)
        {
            this.ServerName = serverName;
            this.DatabaseName = databaseName;
        }

        private string sqlCommand;
        public string Command
        {
            get { return sqlCommand; }
            set { sqlCommand = value; }
        }

        /// <summary>
        /// Execute command directly and display result to data grid view
        /// </summary>
        /// <param name="selectCommand"></param>
        /// <param name="targetDataGridView"></param>
        public void CommandExec(string selectCommand, DataGridView targetDataGridView)
        {
            SqlConnection conn = new SqlConnection(ConnectString());
            SqlCommand cmd = new SqlCommand(Command, conn);
            conn.Open();

            try
            {
                cmd.ExecuteNonQuery();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand, conn);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                targetDataGridView.DataSource = dataSet.Tables[0];
            }
            catch (Exception err1)
            {
                MessageBox.Show(err1.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// Execute command from textbox and display result to data grid view
        /// </summary>
        /// <param name="selectCommandFromTextBox"></param>
        /// <param name="targetDataGridView"></param>
        /// 
        public void CommandExec(TextBox selectCommandFromTextBox, DataGridView targetDataGridView)
        {
            SqlConnection conn = new SqlConnection(ConnectString());
            SqlCommand cmd = new SqlCommand(selectCommandFromTextBox.Text, conn);
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommandFromTextBox.Text, conn);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                targetDataGridView.DataSource = dataSet.Tables[0];
            }
            catch (Exception err2)
            {
                MessageBox.Show(err2.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
