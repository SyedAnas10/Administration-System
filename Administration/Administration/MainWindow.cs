using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administration
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Societies_box_Click(object sender, EventArgs e)
        {
            Societies s1 = new Societies();
            s1.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void EmployeesBox_Click(object sender, EventArgs e)
        {
            Employees e1 = new Employees();
            e1.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void BudgetBox_Click(object sender, EventArgs e)
        {
            Budget b1 = new Budget();
            b1.ShowDialog();
            this.Hide();
            this.Close();
        }
    }
}
