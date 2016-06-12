using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DentalClinic.Internals
{
    public class Credentials:SQLib.SQLConnect
    {
        private static string g_username;
        public static string Username
        {
            get
            {
                return g_username;
            }

            set
            {
                g_username = value;
            }
        }

        private static string g_password;
        public static string Password
        {
            get
            {
                return g_password;
            }

            set
            {
                g_password = value;
            }
        }

        private static string g_restriction;
        public static string Restriction
        {
            get
            {
                return g_restriction;
            }

            set
            {
                g_restriction = value;
            }
        }

        
    }
}
