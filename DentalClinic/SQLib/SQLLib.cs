using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLib;

namespace SQLib
{
    public class SQLLib:SQLConnect
    {
        private string sqlCommand;
        public SQLLib(string serverName,string databaseName)
        {
            this.ServerName = serverName;
            this.DatabaseName = databaseName;
        }

        public string SQLCommand
        {
            get { return sqlCommand; }
            set { sqlCommand = value; }
        }
    }
}
