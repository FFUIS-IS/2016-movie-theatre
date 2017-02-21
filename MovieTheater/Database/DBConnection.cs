using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater
{
    class DBConnection
    {
        private static DBConnection instance;

        private SqlCeConnection connection;

        private string connString;

        private DBConnection()
        {
            HomePage homepage = new HomePage();
            string Dir = homepage.GetHomeDirectory();
            connString = @"Data Source =" + Dir + "\\MovieTheatre.sdf";
            System.Diagnostics.Debug.WriteLine(connString);
            connection = new SqlCeConnection(connString);
            connection.Open();
        }

        public string getConnString()
        {
            return connString;
        }

        public static DBConnection Instance
        {
            get
            {
                if (instance == null)
                    instance = new DBConnection();

                return instance;
            }
        }

        public object ConfigurationManager { get; private set; }

        public SqlCeConnection Connection
        {
            get
            {
                return connection;
            }
        }
    }
}
