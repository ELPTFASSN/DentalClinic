using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLib
{
    //Data Source=FAMILY-PC\SQLEXPRESS;Initial Catalog=EX_5;Integrated Security=True
    public class SQLConnect:Interface.iConnect
    {
        private string serverName;
        private string databaseName;
        internal string ServerName
        {
            get { return serverName; }
            set { serverName = value; }
        }
        internal string DatabaseName
        {
            get { return databaseName; }
            set { databaseName = value; }
        }
        public string ConnectString()
        {
            return string.Concat("Data Source=", ServerName, ";Initial Catalog=", DatabaseName, ";Integrated Security=True");
        }

        /// <summary>
        /// SQLConnect constructor with parameters
        /// </summary>
        /// <param name="_ServerName"></param>
        /// <param name="_DatabaseName"></param>
        public SQLConnect(string _ServerName, string _DatabaseName)
        {
            ServerName = _ServerName;
            DatabaseName = _DatabaseName;
        }

        public SQLConnect(SQLConnect connector)
        {
            DatabaseName = connector.DatabaseName;
            ServerName = connector.ServerName;
        }

        /// <summary>
        /// SQLConnect default constructor
        /// </summary>
        public SQLConnect()
        { }
    }
}
