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
    public partial class DataManipulation : Form
    { 
        public DataManipulation()
        {
            InitializeComponent();
        }

        private void DataManipulation_Load(object sender, EventArgs e)
        {

        }

        public void ReadDataFromDatabase(OleDbConnection databaseConnection, string databaseAddress, string tableName, string primaryKey, string dataToRead, TextBox whereToShow )
        {
            try
            {
                databaseConnection.ConnectionString = databaseAddress;
                databaseConnection.Open();

                string query = "select * from "+tableName+" where ID_RollNum='"+primaryKey+"' ";

                OleDbCommand command = new OleDbCommand(query, databaseConnection);

                // MessageBox.Show(command.CommandText);

                OleDbDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    whereToShow.Text = reader[dataToRead].ToString();
                }

                databaseConnection.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error! " + ex);
            }
        }

        public void WriteDataToDatabase(OleDbConnection databaseConnection, string databaseAddress, string tableName, string rollNum, string fName, string lName, string email, string phoneNo)
        {
            try
            {
                databaseConnection.ConnectionString = databaseAddress;
                databaseConnection.Open();

                string query = "insert into " + tableName + " (ID_RollNum, FirstName, LastName, Email, PhoneNo) values ('" + rollNum + "', '" + fName + "', '" + lName + "', '" + email + "', '" + phoneNo + "')";

                OleDbCommand command = new OleDbCommand(query, databaseConnection);
                // MessageBox.Show(command.CommandText);

                command.ExecuteNonQuery();

                MessageBox.Show("Record Added!");

                databaseConnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error!" + ex);
            }
        }

        public void UpdateDataOfDatabase(OleDbConnection database, string address, string tableName, string primaryKeyName, string primaryKeyValue, string updateColumn, string updatedValue)
        {
            try
            {
                database.ConnectionString = address;
                database.Open();

                string query = "update "+tableName+" set ["+updateColumn+"]= '"+updatedValue+"' where ["+primaryKeyName+"]='"+primaryKeyValue+"'";

                OleDbCommand command = new OleDbCommand(query, database);

                command.ExecuteNonQuery();
               

                database.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error! " + ex);
            }
        }

        public void DeleteDataFromDatabase(OleDbConnection database, string address, string tableName, string primaryKeyName, string primaryKeyValue )
        {
            try
            {
                database.ConnectionString = address;
                database.Open();

                string query = "delete from "+tableName+" where "+primaryKeyName+"='"+primaryKeyValue+"'";

                OleDbCommand command = new OleDbCommand(query, database);
                command.ExecuteNonQuery();

                MessageBox.Show("Record Deleted!");

                database.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error!" + ex);
            }
        }
    }
}
