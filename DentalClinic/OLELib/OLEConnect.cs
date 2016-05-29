using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OLELib
{
    //@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\isada.shaira\Desktop\JobRecruitmentForm\JRSDatabase.accdb";
    public class OLEConnect : Interface.iConnect
    {
        private string dataSource;
        private string dataProvider;
        internal string DataSource
        {
            get { return dataSource; }
            set { dataSource = value; }
        }
        internal string DataProvider
        {
            get { return dataProvider; }
            set { dataProvider = value; }
        }

        public string ConnectString()
        {
            return string.Concat("Provider=", DataProvider, "Data Source=", DataSource);
        }
    }
}
