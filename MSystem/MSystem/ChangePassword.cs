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

namespace LibraryManagementSystem
{
    public partial class ChangePassword : DataManipulation
    {
        OleDbConnection connection = new OleDbConnection();
        private string databaseAddress; //= @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Visual Studio Projects\LibraryManagementSystem\LibraryManagementSystem\LoginInfoDatabase.accdb;
//Persist Security Info=False;";

        public void setAddress(string address)
        {
            databaseAddress = address;
        }

        public ChangePassword()
        {
            InitializeComponent();
        }

        public bool ForgotPassword(OleDbConnection connection, string address, string table, string username, string phoneNo, string newPass)
        {
            try
            {
                connection.ConnectionString = address;
                connection.Open();

                string queryForVerification = "select * from ["+table+"] where [Username]='"+username+"' and [PhoneNo]='"+phoneNo+"'";

                OleDbCommand cmdForVerification = new OleDbCommand(queryForVerification, connection);
                OleDbDataReader reader = cmdForVerification.ExecuteReader();

                if(reader.Read())
                {
                    connection.Close();

                    connection.Open();
                    string queryForUpdate = "update ["+table+"] set [Password]='"+newPass+"' where [Username]='"+username+"' and [PhoneNo]='"+phoneNo+"'";

                    OleDbCommand cmdForUpdate = new OleDbCommand(queryForUpdate, connection);
                    cmdForUpdate.ExecuteNonQuery();

                    connection.Close();

                    return true;
                }
                else
                {
                    MessageBox.Show("Username or Phone No is incorrect!");
                    connection.Close();

                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex);
                connection.Close();

                return false;
            }
        }

        public void btn_UpdatePass_Click(object sender, EventArgs e)
        {
            if (ForgotPassword(connection, databaseAddress, "LoginInfo", txtBox_Username.Text, txtBox_PhoneNo.Text, txtBox_NewPass.Text))
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.ShowDialog();
                this.Hide(); this.Close();
                
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide(); this.Close();
        }
    }
}
