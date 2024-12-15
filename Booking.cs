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
    public partial class Booking : Form
    {
        private int _offset = 0;

        private String _event_1_ID;
        private String _event_2_ID;
        private String _event_3_ID;

        public Booking()
        {
            InitializeComponent();
            LoadEvents();
        }

        private void event_1_Button_Click(object sender, EventArgs e)
        {

        }

        private void event_2_button_Click(object sender, EventArgs e)
        {

        }

        private void event_3_Button_Click(object sender, EventArgs e)
        {

        }

        private void LoadEvents()
        {
            UserService userService = new UserService();

            //get cureent events based 
            var events = userService.GetUpcomingEvents(_offset);


            UpdateEventControl(event_1_title_Label, event_1_type_Label, events.ElementAtOrDefault(0));
            UpdateEventControl(event_2_title_Label, event_2_type_Label, events.ElementAtOrDefault(1));
            UpdateEventControl(event_3_title_Label, event_3_type_Label, events.ElementAtOrDefault(2));

            _offset += 3;
        }

        private void UpdateEventControl(Label titleLabel, Label typeLabel, (string EventID, string Title, string EventTypeName) eventData)
        {
            // if no event left, set variable to nothing
            if (eventData == default)
            {
                titleLabel.Text = "No events available";
                typeLabel.Text = "";
                titleLabel.Visible = true;
                typeLabel.Visible = false;
            }
            else
            {
                titleLabel.Text = eventData.Title;
                typeLabel.Text = eventData.EventTypeName;
                titleLabel.Visible = true;
                typeLabel.Visible = true;
            }
        }

        private void next_event_Button_Click(object sender, EventArgs e)
        {
            LoadEvents();
        }
    }
}
