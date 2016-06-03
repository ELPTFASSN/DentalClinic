using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLib;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

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

        public string ServName
        {
            get { return ServerName; }
            set { ServerName = value; }
        }

        public string DataName
        {
            get { return DatabaseName; }
            set { DatabaseName = value; }
        }

        /// <summary>
        /// Execute command directly and display result to data grid view
        /// </summary>
        /// <param name="sqlCommand"></param>
        /// <param name="targetDataGridView"></param>
        public void CommandExec(string sqlCommand, DataGridView targetDataGridView)
        {
            SqlConnection conn = new SqlConnection(ConnectString());
            SqlCommand cmd = new SqlCommand(Command, conn);
            conn.Open();

            try
            {
                cmd.ExecuteNonQuery();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand, conn);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                targetDataGridView.DataSource = dataSet.Tables[0];
            }
            catch (Exception err1)
            {
                //MessageBox.Show(err1.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// Execute command from textbox and display result to data grid view
        /// </summary>
        /// <param name="sqlCommandFromTextBox"></param>
        /// <param name="targetDataGridView"></param>
        /// 
        public void CommandExec(TextBox sqlCommandFromTextBox, DataGridView targetDataGridView)
        {
            SqlConnection conn = new SqlConnection(ConnectString());
            SqlCommand cmd = new SqlCommand(sqlCommandFromTextBox.Text, conn);
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommandFromTextBox.Text, conn);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                targetDataGridView.DataSource = dataSet.Tables[0];
            }
            catch (Exception err2)
            {
                //MessageBox.Show(err2.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
