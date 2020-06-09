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
    public partial class LoginVerification : Form
    {
        //protected ChangePassword dialog;

        public LoginVerification()
        {
            InitializeComponent();
        }

        public bool VerifyLogin(OleDbConnection database, string address, string table,  string username, string password)
        {
            try
            {
                database.ConnectionString = address;
                database.Open();

                string query= "select * from "+table+" where Username='"+username+"' and Password='"+password+"'";

                OleDbCommand command = new OleDbCommand(query, database);

                //MessageBox.Show(command.CommandText);

                OleDbDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    database.Close();

                    return true;
                }
                else
                {
                    database.Close();
                    return false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error!" + ex);

                return false;
            }
        }

   
  
    }
}
