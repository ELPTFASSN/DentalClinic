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
            OleDbConnection DBConnection = new OleDbConnection(ConnectString());
            OleDbCommand DBCommand = new OleDbCommand(oleCommandFromTextBox.Text, DBConnection);
            DBConnection.Open();
            if (DBConnection.State == ConnectionState.Open)
            {
                try
                {
                    DBCommand.ExecuteNonQuery();
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(oleCommandFromTextBox.Text, DBConnection);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);

                    targetDataGridView.DataSource = dataSet.Tables[0];
                    DBConnection.Close();
                }
                catch (OleDbException dberr)
                {
                    MessageBox.Show(dberr.Message, dberr.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DBConnection.Close();
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

        /// <summary>
        /// Execute database command directly and display result to data grid
        /// </summary>
        /// <param name="oleCommand"></param>
        /// <param name="targetDataGridView"></param>
        public void CommandExec(string oleCommand, DataGridView targetDataGridView)
        {
            OleDbConnection DBConnection = new OleDbConnection(ConnectString());
            OleDbCommand DBCommand = new OleDbCommand(oleCommand, DBConnection);
            DBConnection.Open();
            if (DBConnection.State == ConnectionState.Open)
            {
                try
                {
                    DBCommand.ExecuteNonQuery();
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(oleCommand, DBConnection);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);

                    targetDataGridView.DataSource = dataSet.Tables[0];
                    DBCommand.Cancel();
                }
                catch (OleDbException dberr)
                {
                    MessageBox.Show(dberr.Message,dberr.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DBConnection.Close();
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
    }
}
