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
    public partial class SocietyDetails : DataManipulation
    {
        public SocietyDetails()
        {
            InitializeComponent();
        }

        private void SocietyDetails_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection soc_con = new OleDbConnection();
                soc_con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Personal\Desktop\Final Project\Administration\Societies.accdb";

                soc_con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = soc_con;
                string query = "Select * from Events";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                eventsTables.DataSource = dt;


                soc_con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }

         
        }
    }
}
