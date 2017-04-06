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
using Microsoft.VisualBasic.FileIO;

namespace WhatsThePassword
{
    public partial class Passwords : Form
    {
        public Passwords()
        {
            InitializeComponent();

            
            var fileName = "C:\\Users\\cmart\\Desktop\\Spring_2017_NSU\\FILES_UNLOCKED\\Passwords.csv";
            if (File.Exists(fileName))
            {
                var delimiters = ",";

                var AllPasswords = NewDataTable(fileName, delimiters, true);

                dataGridView1.DataSource = AllPasswords;
            }
            if (!File.Exists(fileName))
            {
                MessageBox.Show(@"Please unlock hidden file.");
            }
        }

        public static DataTable NewDataTable(string fileName, string delimiters, bool firstRowContainsFieldNames = true)
        {
            DataTable result = new DataTable();

            using (TextFieldParser tfp = new TextFieldParser(fileName))
            {
                tfp.SetDelimiters(delimiters);

                if (!tfp.EndOfData)
                {
                    string[] fields = tfp.ReadFields();

                    for (int i = 0; i < fields.Count(); i++)
                    {
                        if (firstRowContainsFieldNames)
                            result.Columns.Add(fields[i]);
                        else
                            result.Columns.Add("Col" + i);
                    }

                    if (!firstRowContainsFieldNames)
                        result.Rows.Add(fields);
                }

                while (!tfp.EndOfData)
                    result.Rows.Add(tfp.ReadFields());
            }

            return result;
        }

        private void Passwords_Close(object sender, FormClosingEventArgs e)
        {
            Clipboard.Clear();
            Application.Exit();
        }

        private void Passwords_Copy_Password(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Copy_Pass(object sender, DataGridViewCellMouseEventArgs e)
        {
            var Copied = dataGridView1.CurrentCell.Value.ToString();
            Clipboard.ContainsText();
            if (Copied != string.Empty)
            {
                Clipboard.SetText(Copied);
            }
            else
            {
                MessageBox.Show(@"Please select a valid password.");
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            AddNewPassword AddNew = new AddNewPassword();
            AddNew.Show();
            Hide();
            
        }

        private void Passwords_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Clipboard.Clear();
                Application.Exit();
            }
        }
    }
}
