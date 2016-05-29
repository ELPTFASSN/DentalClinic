using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OLELib
{
    public class OLELib:OLEConnect,Interface.iCommand
    {
        /// <summary>
        /// OLELib default constructor
        /// </summary>
        public OLELib()
        { }

        /// <summary>
        /// OLELib constructor with parameters
        /// </summary>
        /// <param name="dProvider"></param>
        /// <param name="dSource"></param>
        public OLELib(string dProvider, string dSource)
        {
            this.DataProvider = dProvider;
            this.DataSource = dSource;
        }

        public void CommandExec(TextBox oleCommandFromTextBox, DataGridView targetDataGridView)
        {
            throw new NotImplementedException();
        }

        public void CommandExec(string oleCommand, DataGridView targetDataGridView)
        {
            throw new NotImplementedException();
        }
    }
}
