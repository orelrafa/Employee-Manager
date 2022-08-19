using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace OOP_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customDesign();
        }

        



        public void customDesign() 
        {
            panelDepartmentSubmenu.Visible = false;
            panelEmployeeSubmenu.Visible = false;
        }

        private void hideSubmenu() 
        {
            if (panelDepartmentSubmenu.Visible == true) 
                panelDepartmentSubmenu.Visible = false;
            if (panelEmployeeSubmenu.Visible == true) 
                panelEmployeeSubmenu.Visible = false;
        }

        private void showSubmenu(Panel submenu) 
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else submenu.Visible = false;
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            showSubmenu(panelDepartmentSubmenu);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            showSubmenu(panelEmployeeSubmenu);
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm) 
        {
            if (activeForm != null) 
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {   
            openChildForm(new Home());   
        }

        private void btnIT_MouseClick(object sender, MouseEventArgs e)
        {
            openChildForm(new IT());
        }

        private void btnSales_MouseClick(object sender, MouseEventArgs e)
        {
            openChildForm(new Sales());
        }

        private void btnSupport_MouseClick(object sender, MouseEventArgs e)
        {
            openChildForm(new Support());
        }

        private void btnViewEmp_MouseClick(object sender, MouseEventArgs e)
        {
            openChildForm(new ViewEmployees());
        }

        private void btnAbout_MouseClick(object sender, MouseEventArgs e)
        {
            openChildForm(new About());
        }

        private void btnEditEmp_MouseClick(object sender, MouseEventArgs e)
        {
            openChildForm(new EditEmployees());
        }
    }
}
