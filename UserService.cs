using MyWindowsFormApp;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class UserService
    {
        public bool validateUser(string email, string password)     //used in LoginPage.cs via Login.cs
        {
            string sqlQuery = LoadSqlFile("ValidateUser.sql");

            var parameters = new Dictionary<string, object>
            {
                { "@Email", email },
                { "@Password", password }
            };

            DataSet result = DBconnectionClass.getInstanceOfDBconnections().getDataset(sqlQuery, parameters);

            if (result.Tables[0].Rows.Count > 0)
            {
                int count = Convert.ToInt32(result.Tables[0].Rows[0][0]);
                return count > 0;   // if it found the same data, return >1 = True
            }

            return false;   // if not, return False
        }

        public (String returned_user_ID, string UserName) GetUserNames(string email, string password)       // used in Login.cs
        {
            string sqlQuery = LoadSqlFile("GetUserNames.sql");

            var parameters = new Dictionary<string, object>
            {
                { "@Email", email },
                { "@Password", password }
            };

            DataSet result = DBconnectionClass.getInstanceOfDBconnections().getDataset(sqlQuery, parameters);

            if (result.Tables[0].Rows.Count > 0)
            {
                // Assuming the first row contains the result
                String returned_user_ID = result.Tables[0].Rows[0]["ID"].ToString();

                String UserName = result.Tables[0].Rows[0]["Username"].ToString();

                return (returned_user_ID, UserName);   // return a tuple containing the first and last name
            }

            return (null, null);    // If no match is found, return (null, null)
        }

        public (string Username, string Description, string MembershipType) GetUserInfoByID(String userId)     // used in UserProfile.cs
        {
            string sqlQuery = LoadSqlFile("GetUserInfoByID.sql");

            var parameters = new Dictionary<string, object>
            {
                { "@UserID", userId }
            };

            DataSet result = DBconnectionClass.getInstanceOfDBconnections().getDataset(sqlQuery, parameters);

            if (result.Tables[0].Rows.Count > 0)
            {
                string username = result.Tables[0].Rows[0]["Username"].ToString();
                string description = result.Tables[0].Rows[0]["Description"].ToString();
                string membershipType = result.Tables[0].Rows[0]["MembershipType"].ToString();

                return (username, description, membershipType);
            }

            return (null, null, null); // Return nulls if no user found
        }

        public bool UpdateUserProfile(string userId, string newDescription)     // used in UserProfile.cs
        {
            string sqlQuery = LoadSqlFile("UpdateUserProfile.sql");

            var parameters = new Dictionary<string, object>
            {
                { "@UserID", userId },
                { "@Description", newDescription }
            };

            int rowsAffected = DBconnectionClass.getInstanceOfDBconnections().executeNonQuery(sqlQuery, parameters);

            return rowsAffected > 0; // if the update is successful, return true
        }

        public bool UpdateUserPassword(string email, string newPassword)    // used in forgotPasswordPage.cs
        {
            if (!isEmailAlreadyRegistered(email))
            {
                return false;   // if email not exists, return false
            }

            string sqlQuery = LoadSqlFile("UpdatePassword.sql");

            var parameters = new Dictionary<string, object>
            {
                { "@Email", email },
                { "@Password", newPassword }
            };

            int rowsAffected = DBconnectionClass.getInstanceOfDBconnections().executeNonQuery(sqlQuery, parameters);

            return rowsAffected > 0; // if the update is successful, return true
        }

        public bool registerUser(string email, string password, string firstName, string lastName)      // used in register.cs
        {
            // check if email exists
            if (isEmailAlreadyRegistered(email))
            {
                MessageBox.Show("The email is already registed");
                return false;   // if email exists, return false
            }

            string sqlQuery = LoadSqlFile("RegisterUser.sql");

            var parameters = new Dictionary<string, object>
            {
                { "@Email", email },
                { "@Password", password },
                { "@FirstName", firstName },
                { "@LastName", lastName }
            };

            // insect data
            int rowsAffected = DBconnectionClass.getInstanceOfDBconnections().executeNonQuery(sqlQuery, parameters);

            return rowsAffected > 0;    // if insect is successful, return true
        }


        private bool isEmailAlreadyRegistered(string email)     // used in register.cs
        {
            string sqlQuery = LoadSqlFile("CheckEmailRegistered.sql");

            var parameters = new Dictionary<string, object>
            {
                { "@Email", email }
            };

            DataSet result = DBconnectionClass.getInstanceOfDBconnections().getDataset(sqlQuery, parameters);

            if (result.Tables[0].Rows.Count > 0)
            {
                int count = Convert.ToInt32(result.Tables[0].Rows[0][0]);
                return count > 0;   // if email exists, return true
            }

            return false;   // if email not exists, return false
        }

        public List<(string EventID, string Title, String EventTypeName)> GetUpcomingEvents(int offset)
        {
            string sqlQuery = LoadSqlFile("GetUpcomingEvents.sql");

            var parameters = new Dictionary<string, object>
            {
                { "@Offset", offset }
            };

            DataSet result = DBconnectionClass.getInstanceOfDBconnections().getDataset(sqlQuery, parameters);

            var events = new List<(string, string, string)>();

            if (result.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    string eventID = row["ID"].ToString();
                    string title = row["Title"].ToString();
                    string eventTypeName = row["Name"].ToString();

                    events.Add((eventID, title, eventTypeName));
                }
            }

            return events; // Return the list of upcoming events
        }



        private string LoadSqlFile(string fileName)
        {
            // baseDirectory = project\bin\Debug\net8.0-windows
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // calculate project's file path
            string projectRoot = Path.GetFullPath(Path.Combine(baseDirectory, @"..\..\..\"));

            // combine sql_query's file path
            string sqlFilePath = Path.Combine(projectRoot, "sql_query", fileName);

            if (!File.Exists(sqlFilePath))
            {
                throw new FileNotFoundException($"SQL file '{fileName}' not found in '{sqlFilePath}'.");
            }

            return File.ReadAllText(sqlFilePath);
        }
    }
}
