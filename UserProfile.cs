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
                           userService.GetUserInfoByID(_userID).Description);
        }

        private void GetUserProfile(String userName, String Description)
        {
            user_Name_Label.Text = userName;
            description_Text_Box.Text = Description;
        }

        private void save_change_Button_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            userService.UpdateUserProfile(_userID, description_Text_Box.Text.ToString());
            MessageBox.Show("Saved changes!");
        }
    }
}
