using MovieTheater.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater
{
    class DBLogin
    {
        public static bool CheckLogin(string username, string password, string loginType)
        {
            LoginResponse response = new LoginResponse();
            System.Diagnostics.Debug.WriteLine("Checking login..");
            String query = @"SELECT * FROM Employers WHERE userName = '" + username + "' AND userPassword = '" + password + "' LIMIT 1";
            SqlCeConnection Connection = DBConnection.Instance.Connection;
            SqlCeCommand jobCommand = new SqlCeCommand(query, Connection);
            SqlCeDataReader jobsReader = jobCommand.ExecuteReader();

            while (jobsReader.Read())
            {
                System.Diagnostics.Debug.WriteLine(jobsReader["firstName"] + " " + jobsReader["lastName"]);
                response.isValidLogin = true;
                response.username = jobsReader["userName"].ToString();
                response.userId = (int)jobsReader["userId"];

              //  response.loginType;
            }

            return false;
        }
    }
}
