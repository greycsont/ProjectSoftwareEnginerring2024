using MyWindowsFormApp;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("form1 loaded");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DBconnectionClass dbConnection = DBconnectionClass.getInstanceOfDBconnections();
            if (dbConnection != null)
            {
                Console.WriteLine("dbConnection exists");
            }
            else
            {
                Console.WriteLine("dbConnection not exists");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void GUI_TextBox_Email_TextChanged(object sender, EventArgs e)
        {

        }
    }

   
}
