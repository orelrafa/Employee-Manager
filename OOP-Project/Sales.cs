using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            dataGridViewSales.DataSource = Company.DEP_SALES;
            dataGridViewSales.Columns[0].HeaderText = "ID";
            dataGridViewSales.Columns[1].HeaderText = "First Name";
            dataGridViewSales.Columns[2].HeaderText = "Last Name";
            dataGridViewSales.Columns[3].HeaderText = "Birthdate";
            dataGridViewSales.Columns[4].HeaderText = "Address";
            dataGridViewSales.Columns[5].HeaderText = "Gender";
            dataGridViewSales.Columns[6].HeaderText = "Phone";
            dataGridViewSales.Columns[7].HeaderText = "Education";
            dataGridViewSales.Columns[8].HeaderText = "Work Status";
            dataGridViewSales.Columns[9].HeaderText = "Salary";
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();

        }
    }
}
