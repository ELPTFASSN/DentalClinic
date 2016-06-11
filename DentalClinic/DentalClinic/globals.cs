using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using OLELib;
using SQLib;

namespace DentalClinic
{
    class globals
    {
        private static string dataProvider;
        public static string DataProvider
        {
            get { return dataProvider; }
            set { dataProvider = value; }
        }
        private static string dataSource;
        public static string DataSource
        {
            get { return dataSource; }
            set { dataSource = value; }
        }

        /// <summary>
        /// Displays developer information in aboutbox
        /// </summary>
        /// <param name="targetDevName"></param>
        /// <param name="targetDevPosition"></param>
        /// <param name="targetDevPicture"></param>
        public static void displayDevInfo(Label targetDevName, Label targetDevPosition, PictureBox targetDevPicture)
        {
            if (targetDevName.Text.Contains("dev 1"))
            {
                targetDevName.Text = ProjResource.dev1Name;
                targetDevPosition.Text = ProjResource.dev1Position;
                targetDevPicture.Image = ProjResource.santiago;
            }
            else if (targetDevName.Text.Contains("dev 2"))
            {
                targetDevName.Text = ProjResource.dev2Name;
                targetDevPosition.Text = ProjResource.dev2Position;
                targetDevPicture.Image = ProjResource.benigno;
            }
            else if (targetDevName.Text.Contains("dev 3"))
            {
                targetDevName.Text = ProjResource.dev3Name;
                targetDevPosition.Text = ProjResource.dev3Position;
                targetDevPicture.Image = ProjResource.mandadero;
            }
            else if (targetDevName.Text.Contains("dev 4"))
            {
                targetDevName.Text = ProjResource.dev4Name;
                targetDevPosition.Text = ProjResource.dev4Position;
                targetDevPicture.Image = ProjResource.aloba;
            }
        }

        public static bool isExist(string tableName, string primaryKeyField, string primaryKeyValue, string targetFieldName, string stringToMatch)
        {
            SQLLib sQuery = new SQLLib(".\\SQLEXPRESS", "DentalClinic");
            sQuery.Command = @"SELECT * FROM " + tableName + " WHERE " + primaryKeyField + " = '" + primaryKeyValue + "'";
            bool result = false;
            string str1 = "", str2 = "";
            str1 = getData(tableName, primaryKeyField, primaryKeyValue, targetFieldName);
            str2 = stringToMatch;
            if (str1 == str2)
            {
                result = true;
            }
            else
            { result = false; }
            return result;
        }

        public static string getData(string tableName, string primaryKeyField, string primaryKeyValue, string targetFieldName)
        {
            SQLLib sQuery = new SQLLib(".\\SQLEXPRESS", "DentalClinic");
            sQuery.Command = @"SELECT * FROM " + tableName + " WHERE " + primaryKeyField + " = '" + primaryKeyValue + "'";
            string result = "";
            SqlConnection conn = new SqlConnection(sQuery.ConnectString());
            SqlCommand command = new SqlCommand(sQuery.Command, conn);
            conn.Open();
            try
            {
                SqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    result = (read[targetFieldName.ToString()].ToString());
                }
                read.Close();
            }
            catch (Exception errGet)
            {
                MessageBox.Show(errGet.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

    }
}
