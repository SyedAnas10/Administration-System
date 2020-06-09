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
    public partial class FirstWindow : Form
    {
        public FirstWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void picBox_readData_Click(object sender, EventArgs e)
        {
            
        }

        private void picBox_ReadDataIcon_Click(object sender, EventArgs e)
        {
            ReadData readWindow = new ReadData();
            this.Hide();
            readWindow.ShowDialog();
            this.Close();
        }

       

        private void picBox_WriteDataIcon_Click(object sender, EventArgs e)
        {
            WriteData writeDataWindow = new WriteData();
            this.Hide();
            writeDataWindow.ShowDialog();
            this.Close();
        }

        private void lbl_EditData_Click(object sender, EventArgs e)
        {

        }

        private void picBox_EditDataIcon_Click(object sender, EventArgs e)
        {
            EditData editWindow = new EditData();
            editWindow.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void picBox_ReadDataIcon_Click_1(object sender, EventArgs e)
        {
            ReadData readWindow = new ReadData();
            readWindow.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void picBox_DeleteData_Click(object sender, EventArgs e)
        {
            DeleteData deleteDialog = new DeleteData();
            deleteDialog.ShowDialog();
        }
    }
}
