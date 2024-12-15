using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.LoginModule;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {

        public static String userID;
        public MainForm()
        {
            InitializeComponent();
        }

        private void UpdateUsername(String returned_user_ID, string username)
        {
            userID = returned_user_ID;
            userNameLinkLabel.Text = username;
        }

        private void main_page_Click(object sender, EventArgs e)
        {
            formChangedTo(mainpanel, new MainPage());
        }

        private void userNameLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (userID == null)
            {
                Login login = new Login();
                login.UsernameUpdated += UpdateUsername;    // subscribe the event
                login.ShowDialog();
            }
            else
            {
                formChangedTo(mainpanel, new UserProfile(userID));
            }

        }

        private void event_diary_Button_Click(object sender, EventArgs e)
        {
            formChangedTo(mainpanel, new EventDiary());
        }

        private void membership_Button_Click(object sender, EventArgs e)
        {
            formChangedTo(mainpanel, new Membership(mainpanel, userID));
        }

        private void Booking_Click(object sender, EventArgs e)
        {
            formChangedTo(mainpanel, new Booking());
        }

        public static void formChangedTo(Panel panel, Form form)
        {
            FormPanelManager.LoadForm(panel, form);
        }

        
    }
}
