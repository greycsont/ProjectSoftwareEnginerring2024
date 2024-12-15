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
    public partial class Membership : Form
    {
        private String _userID;
        private Panel _mainpanel;
        public Membership(Panel mainpanel, String userID)
        {
            _mainpanel = mainpanel;
            _userID = userID;
            InitializeComponent();
        }

        private void community_membership_Button_Click(object sender, EventArgs e)
        {
            if (getLoginState(_userID) == false)
            {
                MessageBox.Show("please login to see more details");
            }
            else
            {
                MainForm.formChangedTo(_mainpanel, new CommunityMembership());
            }
        }

        private bool getLoginState(String userID)
        {
            return !string.IsNullOrEmpty(userID);
        }

        private void workspace_membership_Button_Click(object sender, EventArgs e)
        {
            if (getLoginState(_userID) == false)
            {
                MessageBox.Show("please login to see more details");
            }
            else
            {
                MainForm.formChangedTo(_mainpanel, new WorkspaceMembershipRequest());
            }
        }
    }
}
