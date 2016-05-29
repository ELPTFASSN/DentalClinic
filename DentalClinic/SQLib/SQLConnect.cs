using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLib
{
    //Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Family\Source\Repos\DentalClinic\DentalClinic\DentalClinic\DentalClinic.accdb
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
            return string.Concat("Provider=", ServerName, "Data Source=", DatabaseName,"");
        }
    }
}
