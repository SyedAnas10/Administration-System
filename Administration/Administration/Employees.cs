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
    public partial class Employees : DataManipulation
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection emp_con = new OleDbConnection();
                emp_con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Personal\Desktop\Final Project\Administration\Employees.accdb";

                emp_con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = emp_con;
                string query = "Select * from EmployeeInfo";
                command.CommandText = query;

                OleDbDataReader da = command.ExecuteReader();
                while(da.Read())
                {
                    comboBox1.Items.Add(da["FirstName"].ToString());
                }


                emp_con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        

        public void WriteDataToDatabase(OleDbConnection databaseConnection, string databaseAddress, string tableName, string id, string fName, string lName, string desig, string Salary, string Number)
        {
            try
            {
                databaseConnection.ConnectionString = databaseAddress;
                databaseConnection.Open();

                string query = "insert into " + tableName + " ([ID], [FirstName], [LastName], [Designation], [Salary], [ContactNumber]) values ('" + id + "', '" + fName + "', '" + lName + "', '" + desig + "', '" + Salary + "', '" + Number + "')";

                OleDbCommand command = new OleDbCommand(query, databaseConnection);
                // MessageBox.Show(command.CommandText);

                command.ExecuteNonQuery();

                MessageBox.Show("Record Added!\nRestart Application to see changes");

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection emp_con = new OleDbConnection();
            string address = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Personal\Desktop\Final Project\Administration\Employees.accdb";
            string table = "EmployeeInfo";
            WriteDataToDatabase(emp_con, address, table, txtID.Text, txtFname.Text, txtLname.Text, txtDesignation.Text, txtSalary.Text, txtSalary.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection soc_con = new OleDbConnection();
            string address = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Personal\Desktop\Final Project\Administration\Employees.accdb";
            string table = "EmployeeInfo";
            UpdateDataOfDatabase(soc_con, address, table, "ID", txtID.Text, "FirstName", txtFname.Text);
            UpdateDataOfDatabase(soc_con, address, table, "ID", txtID.Text, "LastName", txtLname.Text);
            UpdateDataOfDatabase(soc_con, address, table, "ID", txtID.Text, "Designation", txtDesignation.Text);
            UpdateDataOfDatabase(soc_con, address, table, "ID", txtID.Text, "Salary", txtSalary.Text);
            UpdateDataOfDatabase(soc_con, address, table, "ID", txtID.Text, "ContactNumber", txtNumber.Text);
            MessageBox.Show("Record Updated\nRestart Application to see changes");
        }

        private void label8_Click(object sender, EventArgs e)
        {
            MainWindow m1 = new MainWindow();
            this.Hide();
            this.Close();
            m1.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                 OleDbConnection emp_con = new OleDbConnection();
                emp_con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Personal\Desktop\Final Project\Administration\Employees.accdb";

                emp_con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = emp_con;
                string query = "Select * from EmployeeInfo where FirstName = '"+ comboBox1.Text + "' ";
                command.CommandText = query;

                OleDbDataReader da = command.ExecuteReader();
                while (da.Read())
                {
                    txtID.Text = da["ID"].ToString();
                    txtFname.Text = da["FirstName"].ToString();
                    txtLname.Text = da["LastName"].ToString();
                    txtDesignation.Text = da["Designation"].ToString();
                    txtSalary.Text = da["Salary"].ToString();
                    txtNumber.Text = da["ContactNumber"].ToString();
                }


                emp_con.Close();
            }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
    }

        private void button4_Click(object sender, EventArgs e)
        {
            OleDbConnection soc_con = new OleDbConnection();
            string address = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Personal\Desktop\Final Project\Administration\Employees.accdb";
            string table = "EmployeeInfo";
            DeleteDataFromDatabase(soc_con, address, table, "FirstName" , txtFname.Text);
        }
    }
}
