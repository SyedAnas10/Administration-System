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
    public partial class ReadData : DataManipulation
    {
        private OleDbConnection connection = new OleDbConnection();
        private const string address = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Visual Studio Projects\MSystem\MSystem\Database.accdb;
Persist Security Info=False;";

        public ReadData()
        {
            InitializeComponent();
        }

        private void ReadData_Load(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            ReadDataFromDatabase(connection, address, "BasicInfo", txtBox_RollNum.Text, "FirstName", txtBox_FirstName);
            ReadDataFromDatabase(connection, address, "BasicInfo", txtBox_RollNum.Text, "LastName", txtBox_LastName);
            ReadDataFromDatabase(connection, address, "BasicInfo", txtBox_RollNum.Text, "Email", txtBox_Email);
            ReadDataFromDatabase(connection, address, "BasicInfo", txtBox_RollNum.Text, "PhoneNo", txtBox_PhoneNo);

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            FirstWindow mainWindow = new FirstWindow();
            mainWindow.ShowDialog();
            this.Close();
        }
    }
}
