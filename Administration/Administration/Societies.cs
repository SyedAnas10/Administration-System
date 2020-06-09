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
    public partial class Societies : DataManipulation
    {
        public Societies()
        {
            InitializeComponent();
        }

        private void Societies_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection soc_con = new OleDbConnection();
                soc_con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Personal\Desktop\Final Project\Administration\Societies.accdb";

                soc_con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = soc_con;
                string query = "Select * from SocietiesInfo";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridtable.DataSource = dt;


                soc_con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void gridtable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = gridtable.Rows[e.RowIndex];
                txtName.Text = row.Cells[1].Value.ToString();
                txtHead.Text = row.Cells[2].Value.ToString();
                txtCo.Text = row.Cells[3].Value.ToString();
                txtPresident.Text = row.Cells[4].Value.ToString();
                txtVp.Text = row.Cells[5].Value.ToString();
            }
        }

        new public void WriteDataToDatabase(OleDbConnection databaseConnection, string databaseAddress, string tableName,  string Name, string Head , string CoHead, string President, string Vice)
        {
            try
            {
                databaseConnection.ConnectionString = databaseAddress;
                databaseConnection.Open();

                string query = "insert into " + tableName + " ([Name], [Faculty Head], [Co-Faculty Head], [President], [Vice President]) values ('" + Name + "', '" + Head + "', '" + CoHead + "', '" + President + "', '" + Vice + "')";

                OleDbCommand command = new OleDbCommand(query, databaseConnection);
                // MessageBox.Show(command.CommandText);

                command.ExecuteNonQuery();

                MessageBox.Show("Record Added!\nRestart the application to see changes");

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex);
            }
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OleDbConnection soc_con = new OleDbConnection();
            string address = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Personal\Desktop\Final Project\Administration\Societies.accdb";
            string table = "SocietiesInfo";
            WriteDataToDatabase(soc_con, address, table, txtName.Text, txtHead.Text, txtCo.Text, txtPresident.Text, txtVp.Text);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            OleDbConnection soc_con = new OleDbConnection();
            string address = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Personal\Desktop\Final Project\Administration\Societies.accdb";
            string table = "SocietiesInfo";
            UpdateDataOfDatabase(soc_con,address,table,"Name",txtName.Text,"Faculty Head",txtHead.Text);
            UpdateDataOfDatabase(soc_con, address, table, "Name", txtName.Text,  "Co-Faculty Head", txtCo.Text);
            UpdateDataOfDatabase(soc_con, address, table, "Name", txtName.Text, "President", txtPresident.Text);
            UpdateDataOfDatabase(soc_con, address, table, "Name", txtName.Text, "Vice President", txtVp.Text);
            MessageBox.Show("Record Updated!");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MainWindow m1 = new MainWindow();
            this.Hide();
            this.Close();
            m1.ShowDialog();        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SocietyDetails s1 = new SocietyDetails();
            s1.ShowDialog();
       
        }
    }
}
