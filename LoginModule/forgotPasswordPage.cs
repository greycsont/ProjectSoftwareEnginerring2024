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
    public partial class forgotPasswordPage : Form
    {
        private String verificationCode;
        public forgotPasswordPage()
        {
            InitializeComponent();
        }

        private string GenerateVerificationCode()
        {
            Random random = new Random();
            int verificationCode = random.Next(100000, 1000000);    // 6-digital verification code

            return verificationCode.ToString(); 
        }

        private void checkCodeButton_Click(object sender, EventArgs e)
        {
            verificationCode = GenerateVerificationCode();
            MessageBox.Show("Verification code : " + verificationCode);
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            String email = registed_Email_TextBox.Text;
            String newPassword = new_password_Text_Box.Text;
            String confirmNewPassword = confirm_new_password_Text_Box.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(verification_code_Text_Box.Text) || string.IsNullOrWhiteSpace(confirmNewPassword))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (verification_code_Text_Box.Text == verificationCode 
            && newPassword == confirmNewPassword)
            {
                UserService userService = new UserService();
                userService.UpdateUserPassword(email, newPassword);
                MessageBox.Show("Update new password successfully");
            }
            else
            {
                MessageBox.Show("Wrong verification code or not the same new password");
            }
        }

        
    }
}
