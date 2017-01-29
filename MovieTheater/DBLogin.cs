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
        public static LoginResponse CheckLogin(string username, string password, int loginTypeId)
        {
            LoginResponse response = new LoginResponse();

            String query = @"SELECT TOP 1 * FROM Employers WHERE userName = '" + username + "' AND userPassword = '" + password + "'";
            SqlCeConnection Connection = DBConnection.Instance.Connection;
            SqlCeCommand jobCommand = new SqlCeCommand(query, Connection);
            SqlCeDataReader jobsReader = jobCommand.ExecuteReader();

            if(jobsReader.Read() == false)
            {
                response.isValidLogin = false;
                return response;
            }
            System.Diagnostics.Debug.WriteLine(jobsReader["firstName"] + " " + jobsReader["lastName"]);
            response.isValidLogin = true;
            response.username = jobsReader["userName"].ToString();
            response.userId = (int)jobsReader["Id"];
            response.loginTypeId = loginTypeId;

            String queryJob = @"SELECT TOP 1 * FROM Employers_Jobs WHERE  Employers_Id = " + response.userId + " AND jobs_id = " + loginTypeId;
            SqlCeCommand jobCommand2 = new SqlCeCommand(queryJob, Connection);
            SqlCeDataReader jobsReader2 = jobCommand.ExecuteReader();

            if(jobsReader2.Read() == false)
            {
                response.isValidLogin = false;
                return response;
            }
       
            return response;
        }
    }
}
