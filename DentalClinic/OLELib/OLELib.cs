using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OLELib;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Runtime.InteropServices;

namespace OLELib
{
    public class OLib:OLEConnect,Interface.iCommand
    {
        //@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\isada.shaira\Desktop\JobRecruitmentForm\JRSDatabase.accdb";
        //Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\openlab-mkt-01\Source\Repos\DentalClinic\DentalClinic\DentalClinic\DentalClinic.accdb
        
        /// <summary>
        /// SQLLib default constructor
        /// </summary>
        public OLib()
        { }

        /// <summary>
        /// SQLLib constructor with parameters
        /// </summary>
        /// <param name="_DateProvider"></param>
        /// <param name="_DateSource"></param>
        public OLib(string _DateProvider, string _DateSource)
        {
            this.DataProvider = _DateProvider;
            this.DataSource = _DateSource;
        }

        private string oleCommand;

        public string Command
        {
            get { return oleCommand; }
            set { oleCommand = value; }
        }

        /// <summary>
        /// Execute database command from textbox and display result to data grid
        /// </summary>
        /// <param name="oleCommandFromTextBox"></param>
        /// <param name="targetDataGridView"></param>
        public void CommandExec(TextBox oleCommandFromTextBox, DataGridView targetDataGridView)
        {
            string ConnStr = ConnectString();
            OleDbConnection conn = new OleDbConnection(ConnStr);
            
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(oleCommandFromTextBox.Text, conn);
            OleDbDataReader objReader;

            objReader = cmd.ExecuteReader();
            if (objReader != null)
            {
                targetDataGridView.DataSource = objReader;
                conn.Close();
            }

            /*
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    cmd.ExecuteNonQuery();
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(oleCommandFromTextBox.Text, conn);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);

                    targetDataGridView.DataSource = dataSet.Tables[0];
                }
            }
            catch(Exception err1)
            {
                MessageBox.Show(err1.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }*/
        }

        /// <summary>
        /// Execute database command directly and display result to data grid
        /// </summary>
        /// <param name="oleCommand"></param>
        /// <param name="targetDataGridView"></param>
        public void CommandExec(string oleCommand, DataGridView targetDataGridView)
        {
            OleDbConnection conn = new OleDbConnection(ConnectString());
            OleDbCommand cmd = new OleDbCommand(oleCommand, conn);

            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(oleCommand, conn);
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
