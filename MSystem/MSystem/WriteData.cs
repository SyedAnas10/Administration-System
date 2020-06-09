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
    public partial class WriteData : DataManipulation
    {
        private OleDbConnection connection = new OleDbConnection();
        private const string address = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Visual Studio Projects\MSystem\MSystem\Database.accdb;
Persist Security Info=False;";

        public WriteData()
        {
            InitializeComponent();
        }

        private void WriteData_Load(object sender, EventArgs e)
        {

        }

        private void btn_AddRecords_Click(object sender, EventArgs e)
        {
            WriteDataToDatabase(connection, address, "BasicInfo", txtBox_RollNum.Text, txtBox_FirstName.Text, txtBox_LastName.Text, txtBox_Email.Text, txtBox_PhoneNo.Text);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            FirstWindow mainWindow = new FirstWindow();
            mainWindow.ShowDialog();
            this.Close();
        }
    }
}
