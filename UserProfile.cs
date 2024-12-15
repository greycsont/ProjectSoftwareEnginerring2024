using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserProfile : Form
    {
        private String _userID;
        public UserProfile(String userID)
        {
            UserService userService = new UserService();
            _userID = userID;
            InitializeComponent();

            GetUserProfile(userService.GetUserInfoByID(_userID).Username,
                           userService.GetUserInfoByID(_userID).Description,
                           userService.GetUserInfoByID(_userID).MembershipType);
        }

        private void GetUserProfile(String userName, String Description, String MembershipType)
        {
            user_Name_Label.Text = userName;
            description_Text_Box.Text = Description;
            membership_Label.Text = ("Current membership\n" + MembershipType);
        }

        private void save_change_Button_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            userService.UpdateUserProfile(_userID, description_Text_Box.Text.ToString());
            MessageBox.Show("Saved changes!");
        }
    }
}
