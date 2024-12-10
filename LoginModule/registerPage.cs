using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.LoginModule
{
    public partial class registerPage : Form
    {
        public registerPage()
        {
            InitializeComponent();
        }

        private void loginLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            String first_Name = first_name_Text_Box.Text;
            String last_Name = last_name_Text_Box.Text;
            String email = email_Text_Box.Text;
            String password = password_Text_Box.Text;

            // ensure all the textbox is non-empty
            if (string.IsNullOrWhiteSpace(first_Name) || string.IsNullOrWhiteSpace(last_Name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            UserService userService = new UserService();

            bool isRegistered = userService.registerUser(first_Name, 
                                                         last_Name,
                                                         email,
                                                         password);

            if (isRegistered)
            {
                MessageBox.Show("Registration successful.");
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.");
            }

        }
    }
}
