using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWindowsFormsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Console.WriteLine("form2 loaded");
            Console.WriteLine("Panel container size: " + panelContainer.Size);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Panel container size: " + panelContainer.Size);
            LoadFormInPanel(new testform());
        }

        public void LoadFormInPanel(object childForm)
        {
            if ( this.panelContainer.Controls.Count > 0 )
            {
                this.panelContainer.Controls.RemoveAt(0);
            }
            Form f = childForm as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(f);
            this.panelContainer.Tag = f;
            f.Show();
            Console.WriteLine("Form ",f," loaded");
        }

     
    }
}
