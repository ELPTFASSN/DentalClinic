using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        
        /// <summary>
        /// OLEDB connection string
        /// </summary>
        /// <returns></returns>
        public string ConnectString()
        {
            return string.Concat("Provider=", DataProvider, "Data Source=", DataSource);
        }

        /// <summary>
        /// OLEConnect constructor recursive
        /// </summary>
        /// <param name="connector"></param>
        public OLEConnect(OLEConnect connector)
        {
            DataProvider = connector.DataProvider;
            DataSource = connector.DataSource;
        }

        /// <summary>
        /// OLEConnect constructor with parameters
        /// </summary>
        /// <param name="_DataProvider"></param>
        /// <param name="_DataSource"></param>
        public OLEConnect(string _DataProvider, string _DataSource)
        {
            DataProvider = _DataProvider;
            DataSource = _DataSource;
        }

        /// <summary>
        /// OLEConnect default constructor
        /// </summary>
        public OLEConnect()
        { }
    }
}
