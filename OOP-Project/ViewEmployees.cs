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
    public partial class ViewEmployees : Form
    {
        public ViewEmployees()
        {
            InitializeComponent();
        }

        private void ViewEmployees_Load(object sender, EventArgs e)
        {

            List<Employee> allEmployees = new List<Employee>();
            allEmployees = Company.DEP_IT.Concat(Company.DEP_SALES).ToList();
            allEmployees = allEmployees.Concat(Company.DEP_SUPPORT).ToList();
            dataGridViewEmployees.DataSource = allEmployees;
            dataGridViewEmployees.Columns[0].HeaderText = "ID";
            dataGridViewEmployees.Columns[1].HeaderText = "First Name";
            dataGridViewEmployees.Columns[2].HeaderText = "Last Name";
            dataGridViewEmployees.Columns[3].HeaderText = "Birthdate";
            dataGridViewEmployees.Columns[4].HeaderText = "Address";
            dataGridViewEmployees.Columns[5].HeaderText = "Gender";
            dataGridViewEmployees.Columns[6].HeaderText = "Phone";
            dataGridViewEmployees.Columns[7].HeaderText = "Education";
            dataGridViewEmployees.Columns[8].HeaderText = "Work Status";
            dataGridViewEmployees.Columns[9].HeaderText = "Salary";
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
