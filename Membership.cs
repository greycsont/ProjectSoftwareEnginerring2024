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
        public Membership(String userID)
        {
            _userID = userID;
            InitializeComponent();
        }

        private void community_membership_Button_Click(object sender, EventArgs e)
        {
            if (getLoginState(_userID) == false)
            {
                MessageBox.Show("please login to see more details");
            }
        }

        private bool getLoginState(String userID)
        {
            return !string.IsNullOrEmpty(userID);
        }
    }
}
