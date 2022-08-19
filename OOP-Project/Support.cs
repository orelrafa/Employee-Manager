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
    public partial class Support : Form
    {
        public Support()
        {
            InitializeComponent();
        }

        private void Support_Load(object sender, EventArgs e)
        {
            dataGridViewSupport.DataSource = Company.DEP_SUPPORT;
            dataGridViewSupport.Columns[0].HeaderText = "ID";
            dataGridViewSupport.Columns[1].HeaderText = "First Name";
            dataGridViewSupport.Columns[2].HeaderText = "Last Name";
            dataGridViewSupport.Columns[3].HeaderText = "Birthdate";
            dataGridViewSupport.Columns[4].HeaderText = "Address";
            dataGridViewSupport.Columns[5].HeaderText = "Gender";
            dataGridViewSupport.Columns[6].HeaderText = "Phone";
            dataGridViewSupport.Columns[7].HeaderText = "Education";
            dataGridViewSupport.Columns[8].HeaderText = "Work Status";
            dataGridViewSupport.Columns[9].HeaderText = "Salary";
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
