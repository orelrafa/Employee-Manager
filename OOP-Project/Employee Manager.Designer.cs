
namespace OOP_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.panelEmployeeSubmenu = new System.Windows.Forms.Panel();
            this.btnEditEmp = new System.Windows.Forms.Button();
            this.btnViewEmp = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.panelDepartmentSubmenu = new System.Windows.Forms.Panel();
            this.btnSupport = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnIT = new System.Windows.Forms.Button();
            this.btnDepartment = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panelEmployeeSubmenu.SuspendLayout();
            this.panelDepartmentSubmenu.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.pictureBox1);
            this.panelSideMenu.Controls.Add(this.btnAbout);
            this.panelSideMenu.Controls.Add(this.panelEmployeeSubmenu);
            this.panelSideMenu.Controls.Add(this.btnEmployee);
            this.panelSideMenu.Controls.Add(this.panelDepartmentSubmenu);
            this.panelSideMenu.Controls.Add(this.btnDepartment);
            this.panelSideMenu.Controls.Add(this.btnHome);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 698);
            this.panelSideMenu.TabIndex = 0;
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAbout.Location = new System.Drawing.Point(0, 523);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAbout.Size = new System.Drawing.Size(250, 45);
            this.btnAbout.TabIndex = 11;
            this.btnAbout.Text = "About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAbout_MouseClick);
            // 
            // panelEmployeeSubmenu
            // 
            this.panelEmployeeSubmenu.Controls.Add(this.btnEditEmp);
            this.panelEmployeeSubmenu.Controls.Add(this.btnViewEmp);
            this.panelEmployeeSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEmployeeSubmenu.Location = new System.Drawing.Point(0, 423);
            this.panelEmployeeSubmenu.Name = "panelEmployeeSubmenu";
            this.panelEmployeeSubmenu.Size = new System.Drawing.Size(250, 100);
            this.panelEmployeeSubmenu.TabIndex = 8;
            // 
            // btnEditEmp
            // 
            this.btnEditEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnEditEmp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditEmp.FlatAppearance.BorderSize = 0;
            this.btnEditEmp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEditEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditEmp.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEditEmp.Location = new System.Drawing.Point(0, 45);
            this.btnEditEmp.Name = "btnEditEmp";
            this.btnEditEmp.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEditEmp.Size = new System.Drawing.Size(250, 45);
            this.btnEditEmp.TabIndex = 9;
            this.btnEditEmp.Text = "Edit Employees";
            this.btnEditEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditEmp.UseVisualStyleBackColor = false;
            this.btnEditEmp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnEditEmp_MouseClick);
            // 
            // btnViewEmp
            // 
            this.btnViewEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnViewEmp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewEmp.FlatAppearance.BorderSize = 0;
            this.btnViewEmp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnViewEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewEmp.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnViewEmp.Location = new System.Drawing.Point(0, 0);
            this.btnViewEmp.Name = "btnViewEmp";
            this.btnViewEmp.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnViewEmp.Size = new System.Drawing.Size(250, 45);
            this.btnViewEmp.TabIndex = 8;
            this.btnViewEmp.Text = "View Employees";
            this.btnViewEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewEmp.UseVisualStyleBackColor = false;
            this.btnViewEmp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnViewEmp_MouseClick);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEmployee.Location = new System.Drawing.Point(0, 378);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEmployee.Size = new System.Drawing.Size(250, 45);
            this.btnEmployee.TabIndex = 4;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // panelDepartmentSubmenu
            // 
            this.panelDepartmentSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelDepartmentSubmenu.Controls.Add(this.btnSupport);
            this.panelDepartmentSubmenu.Controls.Add(this.btnSales);
            this.panelDepartmentSubmenu.Controls.Add(this.btnIT);
            this.panelDepartmentSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDepartmentSubmenu.Location = new System.Drawing.Point(0, 249);
            this.panelDepartmentSubmenu.Name = "panelDepartmentSubmenu";
            this.panelDepartmentSubmenu.Size = new System.Drawing.Size(250, 129);
            this.panelDepartmentSubmenu.TabIndex = 3;
            // 
            // btnSupport
            // 
            this.btnSupport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnSupport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSupport.FlatAppearance.BorderSize = 0;
            this.btnSupport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSupport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupport.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSupport.Location = new System.Drawing.Point(0, 80);
            this.btnSupport.Name = "btnSupport";
            this.btnSupport.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSupport.Size = new System.Drawing.Size(250, 40);
            this.btnSupport.TabIndex = 2;
            this.btnSupport.Text = "Support";
            this.btnSupport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupport.UseVisualStyleBackColor = false;
            this.btnSupport.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSupport_MouseClick);
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSales.Location = new System.Drawing.Point(0, 40);
            this.btnSales.Name = "btnSales";
            this.btnSales.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSales.Size = new System.Drawing.Size(250, 40);
            this.btnSales.TabIndex = 1;
            this.btnSales.Text = "Sales";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSales_MouseClick);
            // 
            // btnIT
            // 
            this.btnIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnIT.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIT.FlatAppearance.BorderSize = 0;
            this.btnIT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIT.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnIT.Location = new System.Drawing.Point(0, 0);
            this.btnIT.Name = "btnIT";
            this.btnIT.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnIT.Size = new System.Drawing.Size(250, 40);
            this.btnIT.TabIndex = 0;
            this.btnIT.Text = "IT";
            this.btnIT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIT.UseVisualStyleBackColor = false;
            this.btnIT.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnIT_MouseClick);
            // 
            // btnDepartment
            // 
            this.btnDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnDepartment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDepartment.FlatAppearance.BorderSize = 0;
            this.btnDepartment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartment.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDepartment.Location = new System.Drawing.Point(0, 204);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDepartment.Size = new System.Drawing.Size(250, 45);
            this.btnDepartment.TabIndex = 2;
            this.btnDepartment.Text = "Department";
            this.btnDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartment.UseVisualStyleBackColor = false;
            this.btnDepartment.Click += new System.EventHandler(this.btnDepartment_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHome.Location = new System.Drawing.Point(0, 159);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(250, 45);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelChildForm.Controls.Add(this.pictureBox2);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(832, 698);
            this.panelChildForm.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(832, 698);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 614);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 84);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Transparent;
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 159);
            this.panelLogo.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 698);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Manager";
            this.panelSideMenu.ResumeLayout(false);
            this.panelEmployeeSubmenu.ResumeLayout(false);
            this.panelDepartmentSubmenu.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelDepartmentSubmenu;
        private System.Windows.Forms.Button btnSupport;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnIT;
        private System.Windows.Forms.Button btnDepartment;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Panel panelEmployeeSubmenu;
        private System.Windows.Forms.Button btnEditEmp;
        private System.Windows.Forms.Button btnViewEmp;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

