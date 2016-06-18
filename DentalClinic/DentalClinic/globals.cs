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
    public class globals : Internals.Credentials
    {
        private static string dataProvider = ".\\SQLEXPRESS";
        public static string DataProvider
        {
            get { return dataProvider; }
            set { dataProvider = value; }
        }

        private static string dataSource = "DentalClinic";
        public static string DataSource
        {
            get { return dataSource; }
            set { dataSource = value; }
        }

        public static SQLLib sQuery = new SQLLib(DataProvider, DataSource);
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

        /// <summary>
        /// Check from database if exist
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="primaryKeyField"></param>
        /// <param name="primaryKeyValue"></param>
        /// <param name="targetFieldName"></param>
        /// <param name="stringToMatch"></param>
        /// <returns></returns>
        public static bool isExist(string tableName, string primaryKeyField, string primaryKeyValue, string targetFieldName, string stringToMatch)
        {
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

        /// <summary>
        /// Gets a field value and returns as string
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="primaryKeyField"></param>
        /// <param name="primaryKeyValue"></param>
        /// <param name="targetFieldName"></param>
        /// <returns></returns>
        public static string getData(string tableName, string primaryKeyField, string primaryKeyValue, string targetFieldName)
        {
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

        public static bool isAdministrator()
        {
            bool result = false;
            if (Restriction.Contains("Admin") || Restriction.Contains("admin".ToLower()) || Restriction.Contains("admin".ToUpper()))
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        public static bool isDentist()
        {
            bool result = false;
            if (Restriction.Contains("Dentist") || Restriction.Contains("Dentist".ToLower()) || Restriction.Contains("Dentist".ToUpper()))
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        public static bool isAssistant()
        {
            bool result = false;
            if (Restriction.Contains("Assistant") || Restriction.Contains("Assistant".ToLower()) || Restriction.Contains("Assistant".ToUpper()))
            { result = true; }
            else if (Restriction.Contains("Employee") || Restriction.Contains("Employee".ToLower()) || Restriction.Contains("Employee".ToUpper()))
            { result = true; }
            else if (Restriction.Contains("Staff") || Restriction.Contains("Staff".ToUpper()) || Restriction.Contains("Staff".ToLower()))
            { result = true; }
            else
            { result = false; }
            return result;
        }

        public static void setCredentials(string _username, string _password, string _restriction)
        {
            Username = _username;
            Password = _password;
            Restriction = _restriction;
        }

        public static void showCredentials(ToolStripStatusLabel targetStatusLabel)
        {

        }
    }
}
