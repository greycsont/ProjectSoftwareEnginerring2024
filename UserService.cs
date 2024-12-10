using MyWindowsFormApp;
using System;
using System.Collections.Generic;
using System.Data;
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
            string sqlQuery = "SELECT COUNT(*) FROM [User] WHERE Email = @Email AND Password = @Password";

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
            string sqlQuery = "SELECT ID, FirstName + ' ' + LastName AS Username FROM [User] WHERE Email = @Email AND Password = @Password";

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

        public (string Username, string Description) GetUserInfoByID(String userId)     // used in UserProfile.cs
        {
            string sqlQuery = "SELECT FirstName + ' ' + LastName AS Username, Description FROM [User] WHERE ID = @UserID";

            var parameters = new Dictionary<string, object>
            {
                { "@UserID", userId }
            };

            DataSet result = DBconnectionClass.getInstanceOfDBconnections().getDataset(sqlQuery, parameters);

            if (result.Tables[0].Rows.Count > 0)
            {
                string username = result.Tables[0].Rows[0]["Username"].ToString();
                string description = result.Tables[0].Rows[0]["Description"].ToString();
                return (username, description); // Return tuple with Username and Description
            }

            return (null, null); // Return nulls if no user found
        }

        public bool UpdateUserProfile(string userId, string newDescription)     // used in UserProfile.cs
        {
            string sqlQuery = "UPDATE [User] SET Description = @Description WHERE ID = @UserID";

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

            string sqlQuery = "UPDATE [User] SET Password = @Password WHERE Email = @Email";

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
                return false;   // if email exists, return false
            }

            string sqlQuery = "INSERT INTO [User] (Email, Password, FirstName, LastName)" +
                              "VALUES (@Email, @Password, @FirstName, @LastName)";

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
            string sqlQuery = "SELECT COUNT(*) FROM [User] WHERE Email = @Email";

            var parameters = new Dictionary<string, object>
            {
                { "@Email", email }
            };

            DataSet result = DBconnectionClass.getInstanceOfDBconnections().getDataset(sqlQuery, parameters);

            if (result.Tables[0].Rows.Count > 0)
            {
                int count = Convert.ToInt32(result.Tables[0].Rows[0][0]);
                MessageBox.Show("The email is already registed");
                return count > 0;   // if email exists, return true
            }

            return false;   // if email not exists, return false
        }

    }
}
