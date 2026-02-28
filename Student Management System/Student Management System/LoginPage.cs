using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class main_menu : Form
    {
        public main_menu()
        {
            InitializeComponent();
        } 

        //log in with selected username and password
        private void button_logIn_Click(object sender, EventArgs e)
        {
            string uname = txb_username.Text;
            string pass = txb_password.Text;
            if ((uname == "irem" && pass == "irem" )|| (uname == "admin" && pass == "1234"))
            {
                MainMenu teacherMenu = new MainMenu(uname);
                this.Hide();
                teacherMenu.Show();
            }
            else
            {
                MessageBox.Show("Username or Password is Wrong","Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //exit button
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
