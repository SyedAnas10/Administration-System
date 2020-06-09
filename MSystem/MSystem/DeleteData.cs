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

namespace MSystem
{
    public partial class DeleteData : DataManipulation
    {
        private OleDbConnection connection = new OleDbConnection();
        private const string address = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Visual Studio Projects\MSystem\MSystem\Database.accdb;
        Persist Security Info=False;";

        public DeleteData()
        {
            InitializeComponent();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DeleteDataFromDatabase(connection, address, "BasicInfo", "ID_RollNum", txtBox_RollNum.Text);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide(); this.Close();
        }

        private void DeleteData_Load(object sender, EventArgs e)
        {

        }
    }
}
