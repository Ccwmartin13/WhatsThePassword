using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WhatsThePassword
{
    public partial class AddNewPassword : Form
    {
        StringBuilder csv = new StringBuilder();
        public AddNewPassword()
        {
            InitializeComponent();
            
        }

        private void AddNewPassword_Close(object sender, FormClosingEventArgs e)
        {
            Clipboard.Clear();
            Application.Exit();
        }

        private void AddNewPassword_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Clipboard.Clear();
                Application.Exit();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var fileName = "C:\\Users\\cmart\\Desktop\\Spring_2017_NSU\\FILES_UNLOCKED\\Passwords.csv";

            var Website = tb_Website.Text;
            var Username = tb_UserName.Text;
            var Password = tb_Password.Text;
            var NewPassword = $"{Website},{Username},{Password}";

            csv.AppendLine(NewPassword);

            SaveToPasswords(fileName);

            MessageBox.Show(@"New password accepted.");
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Passwords passwords = new Passwords();
            passwords.Show();
            Hide();
            
        }

        private void SaveToPasswords(string fileName)
        {
            TextWriter w = new StreamWriter(fileName, true);
            w.Write(csv.ToString());
            w.Close();
        }
    }
}
