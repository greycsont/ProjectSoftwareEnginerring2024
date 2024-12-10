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
    public partial class Login : Form
    {
        public event Action<String, string> UsernameUpdated;    //event to handle user name to form1
        public void NotifyUsernameUpdate(String returned_user_ID, string username)
        {
            UsernameUpdated?.Invoke(returned_user_ID, 
                                    username);  // handle user name to form1
            this.Close();
        }

        public Login()
        {
            InitializeComponent();
            FormPanelManager.LoadForm(LoginPanel, new LoginPage(this));
        }

        private void loginLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormPanelManager.LoadForm(LoginPanel, new LoginPage(this));
        }

        private void registerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormPanelManager.LoadForm(LoginPanel, new registerPage());
        }

        private void forgotPasswordLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormPanelManager.LoadForm(LoginPanel, new forgotPasswordPage());
        }
    }
}
