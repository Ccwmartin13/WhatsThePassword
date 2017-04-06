using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatsThePassword
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Close(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (tb_UserName.Text == @"Ccwmartin13" && tb_Password.Text == @"Drpepper23")
            {
                Passwords passwords = new Passwords();
                passwords.Show();
                Hide();
                
            }
            else
            {
                MessageBox.Show(@"Incorrect Username or Password!");
            }
        }

        private void Login_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Clipboard.Clear();
                Application.Exit();
            }
        }
    }
}
