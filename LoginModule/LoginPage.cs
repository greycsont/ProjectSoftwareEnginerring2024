using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1.LoginModule
{
    public partial class LoginPage : Form
    {
        private Login _parent;
        public LoginPage(Login parent)
        {
            _parent = parent;   // Link of LoginPage to Login
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;

            UserService userService = new UserService();

            bool isValidUser = userService.validateUser(email, password);


            if (isValidUser)
            {
                _parent.NotifyUsernameUpdate(userService.GetUserNames(email, password).returned_user_ID, 
                                             userService.GetUserNames(email, password).UserName);

                MessageBox.Show("Login successful!");
            }
            else
            {
                MessageBox.Show("Invalid email or password.");
            }
        }
    }
}
