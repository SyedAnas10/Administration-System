using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Administration
{
    public partial class LoginPage : LoginVerification
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            OleDbConnection database = new OleDbConnection();
            string address = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Personal\Desktop\Final Project\Administration\Passwords.accdb";
            string table = "PasswordInfo";
            string username = textBox1.Text;
            string password = textBox2.Text;
            if(VerifyLogin(database, address, table, username, password))
            {
                MainWindow m2 = new MainWindow();
                m2.ShowDialog();
                this.Hide();
                this.Close();
            }
            else
            {
                MessageBox.Show("User Name or Password is incorrect");
            }
        }
    }
}
