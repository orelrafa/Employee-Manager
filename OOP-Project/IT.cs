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
    public partial class IT : Form
    {
        public IT()
        {
            InitializeComponent();
        }

        private void btnX_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void IT_Load(object sender, EventArgs e)
        {
            //dataGridViewIT.ColumnCount = 8;
            dataGridViewIT.DataSource = Company.DEP_IT;
            dataGridViewIT.Columns[0].HeaderText = "ID";
            dataGridViewIT.Columns[1].HeaderText = "First Name";
            dataGridViewIT.Columns[2].HeaderText = "Last Name";
            dataGridViewIT.Columns[3].HeaderText = "Birthdate";
            dataGridViewIT.Columns[4].HeaderText = "Address";
            dataGridViewIT.Columns[5].HeaderText = "Gender";
            dataGridViewIT.Columns[6].HeaderText = "Phone";
            dataGridViewIT.Columns[7].HeaderText = "Education";
            dataGridViewIT.Columns[8].HeaderText = "Work Status";
            dataGridViewIT.Columns[9].HeaderText = "Salary";
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();

        }
    }
}
