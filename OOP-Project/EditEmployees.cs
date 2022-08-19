using System;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class EditEmployees : Form
    {
        public EditEmployees()
        {
            InitializeComponent();
        }

        private void btnSEARCH_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private Boolean FormFilled()
        {
            if (empEDTIDTab.Text == "" ||
                empFirstNameTab.Text == "" ||
                empLastNameTab.Text == "" ||
                empPhoneTab.Text == "" ||
                empEducationTab.Text == "" ||
                empWorkStatusCB.Text == "" ||
                empAddressTab.Text == "" ||
                empGenderCB.Text == "" ||
                empSalaryTab.Text == "" ||
                empPositionCB.Text == "")
            {
                MessageBox.Show("Missing Information");
                return false;
            }
            if (!(empPositionCB.Text == "Junior Developer" ||
               empPositionCB.Text == "Senior Developer" ||
               empPositionCB.Text == "Technician" ||
               empPositionCB.Text == "Sales Representative" ||
               empPositionCB.Text == "Support Representative"))
            {
                MessageBox.Show("Please Enter a Valid Position!");
                return false;
            }
            string position = empPositionCB.Text;
            switch (position)
            {
                case "Junior Developer":
                    if (empBugsFixedTab.Text == "" ||
                        empCurProjectsTab.Text == "")
                    {
                        MessageBox.Show("Junior Developer is a programmer!\n\r" +
                                        "Please fill out the Programmer Details");
                        return false;
                    }
                    if (empBugsCreatedTab.Text == "" ||
                       empTimesAskedHTab.Text == "")
                    {
                        MessageBox.Show("Please fill out the Junior Developer Details");
                        return false;
                    }
                    break;
                case "Senior Developer":
                    if (empBugsFixedTab.Text == "" ||
                        empCurProjectsTab.Text == "")
                    {
                        MessageBox.Show("Senior Developer is a programmer!\n\r" +
                                        "Please fill out the Programmer Details");
                        return false;
                    }
                    if (empNumTechTab.Text == "" ||
                        empCritBugsFixTab.Text == "")
                    {
                        MessageBox.Show("Please fill out the Senior Developer Details");
                        return false;
                    }
                    break;
                case "Technician":
                    if (empBugsFixedTab.Text == "" ||
                        empCurProjectsTab.Text == "")
                    {
                        MessageBox.Show("Technician is a programmer!\n\r" +
                                        "Please fill out the Programmer Details");
                        break;
                    }
                    if (empComputersFixTab.Text == "" ||
                        empBrokenComputersTab.Text == "")
                    {
                        MessageBox.Show("Please fill out the Technician Details");
                        return false;
                    }
                    break;
                case "Sales Representative":
                    if (empNewCustomersTab.Text == "" ||
                        empCustomersLostTab.Text == "")
                    {
                        MessageBox.Show("Please fill out the Sales Representative Details");
                        return false;
                    }
                    break;
                case "Support Representative":
                    if (empCustomersHelpTab.Text == "" ||
                        empCustomersScamTab.Text == "")
                    {
                        MessageBox.Show("Please fill out the Support Representative Details");
                        return false;
                    }
                    break;
            }
            return true;
        }


        private void createEmployee(string position)
        {
            string empId = empEDTIDTab.Text;
            string empFirstName = empFirstNameTab.Text;
            string empLastrName = empLastNameTab.Text;
            string empPhone = empPhoneTab.Text;
            string empEducation = empEducationTab.Text;
            string empWorkStatus = empWorkStatusCB.Text;
            string empAdress = empAddressTab.Text;
            string empGender = empGenderCB.Text;
            string empBirthday = empBirthDateTab.Text;
            string empPosition = position;
            int empSalary = Convert.ToInt32(empSalaryTab.Text);
            switch (position)
            {
                case "Junior Developer":
                    int empBugsFixed = Convert.ToInt32(empBugsFixedTab.Text);
                    int empCurProjects = Convert.ToInt32(empCurProjectsTab.Text);
                    int empTimesAskedHelp = Convert.ToInt32(empTimesAskedHTab.Text);
                    int empBugsCreated = Convert.ToInt32(empBugsCreatedTab.Text);
                    Employee junior = new JuniorDev(empId, empFirstName, empLastrName, empBirthday, empAdress, empGender,
                        empPhone, empEducation, empWorkStatus, empSalary, empBugsFixed, empCurProjects, empTimesAskedHelp, empBugsCreated);
                    Company.DEP_IT.Add(junior);
                    break;
                case "Senior Developer":
                    int empBugsFixedS = Convert.ToInt32(empBugsFixedTab.Text);
                    int empCurProjectsS = Convert.ToInt32(empCurProjectsTab.Text);
                    int numCriticalBugFix = Convert.ToInt32(empCritBugsFixTab.Text);
                    int numTechnologies = Convert.ToInt32(empNumTechTab.Text);
                    Employee senior = new SeniorDev(empId, empFirstName, empLastrName, empBirthday, empAdress, empGender,
                        empPhone, empEducation, empWorkStatus, empSalary, empBugsFixedS, empCurProjectsS, numCriticalBugFix, numTechnologies);
                    Company.DEP_IT.Add(senior);
                    break;
                case "Technician":
                    int empBugsFixedT = Convert.ToInt32(empBugsFixedTab.Text);
                    int empCurProjectsT = Convert.ToInt32(empCurProjectsTab.Text);
                    int empNumComputersFixed = Convert.ToInt32(empComputersFixTab.Text);
                    int empNumComputersNeedFix = Convert.ToInt32(empBrokenComputersTab.Text);
                    Employee technician = new Technician(empId, empFirstName, empLastrName, empBirthday, empAdress, empGender,
                        empPhone, empEducation, empWorkStatus, empSalary, empBugsFixedT, empCurProjectsT, empNumComputersFixed, empNumComputersNeedFix);
                    Company.DEP_IT.Add(technician);
                    break;
                case "Sales Representative":
                    int numNewCustomers = Convert.ToInt32(empNewCustomersTab.Text);
                    int numCustomersLost = Convert.ToInt32(empCustomersLostTab.Text);
                    Employee salesRep = new SalesRep(empId, empFirstName, empLastrName, empBirthday, empAdress, empGender,
                        empPhone, empEducation, empWorkStatus, empSalary, numNewCustomers, numCustomersLost);
                    Company.DEP_SALES.Add(salesRep);
                    break;
                case "Support Representative":
                    int empCustomersHelped = Convert.ToInt32(empCustomersHelpTab.Text);
                    int empCustomersScammed = Convert.ToInt32(empCustomersScamTab.Text);
                    Employee SupportRep = new SupportRep(empId, empFirstName, empLastrName, empBirthday, empAdress, empGender,
                        empPhone, empEducation, empWorkStatus, empSalary, empCustomersHelped, empCustomersScammed);
                    Company.DEP_SUPPORT.Add(SupportRep);
                    break;
            }
        }

        private void btnADD_MouseClick(object sender, MouseEventArgs e)
        {
            if (FormFilled())
            {
                string position = empPositionCB.Text;
                createEmployee(position);
                MessageBox.Show("Employee Added Succefully!");
            }
        }

        Employee searchEmployee(string ID)
        {
            foreach (Employee emp in Company.DEP_IT)
            {
                if (emp.EmpId == ID) return emp;
            }
            foreach (Employee emp in Company.DEP_SALES)
            {
                if (emp.EmpId == ID) return emp;
            }
            foreach (Employee emp in Company.DEP_SUPPORT)
            {
                if (emp.EmpId == ID) return emp;
            }
            MessageBox.Show("Employee not found");
            return null;
        }

        void fillForm(Employee employee)
        {
            if (employee == null) return;
            empEDTIDTab.Text = employee.EmpId;
            empFirstNameTab.Text = employee.EmpFirstName;
            empLastNameTab.Text = employee.EmpLastName;
            empPhoneTab.Text = employee.EmpPhone;
            empEducationTab.Text = employee.EmpEducation;
            empWorkStatusCB.Text = employee.EmpWorkStatus;
            empAddressTab.Text = employee.EmpAddress;
            empGenderCB.Text = employee.EmpGender;
            empBirthDateTab.Text = employee.EmpBirthDate;
            empSalaryTab.Text = String.Format("{0}", employee.EmpSalary);
            {
                if (employee.GetType() == typeof(JuniorDev))
                {
                    empBugsFixedTab.Text = Convert.ToString((employee as Programmer).NumOfBugsFixed);
                    empCurProjectsTab.Text = Convert.ToString((employee as Programmer).NumOfCurProjects);
                    empTimesAskedHTab.Text = Convert.ToString((employee as JuniorDev).TimesAskedHelp);
                    empBugsCreatedTab.Text = Convert.ToString((employee as JuniorDev).NumOfBugsFixed);
                    empPositionCB.Text = "Junior Developer";

                }
                if (employee.GetType() == typeof(SeniorDev))
                {
                    empBugsFixedTab.Text = Convert.ToString((employee as Programmer).NumOfBugsFixed);
                    empCurProjectsTab.Text = Convert.ToString((employee as Programmer).NumOfCurProjects);
                    empCritBugsFixTab.Text = Convert.ToString((employee as SeniorDev).NumCriticalBugFix);
                    empNumTechTab.Text = Convert.ToString((employee as SeniorDev).NumTechnologies);
                    empPositionCB.Text = "Senior Developer";

                }
                if (employee.GetType() == typeof(Technician))
                {
                    empBugsFixedTab.Text = Convert.ToString((employee as Programmer).NumOfBugsFixed);
                    empCurProjectsTab.Text = Convert.ToString((employee as Programmer).NumOfCurProjects);
                    empComputersFixTab.Text = Convert.ToString((employee as Technician).NumComputersFixed);
                    empBrokenComputersTab.Text = Convert.ToString((employee as Technician).NumComputersNeedFix);
                    empPositionCB.Text = "Technician";

                }
                if (employee.GetType() == typeof(SalesRep))
                {
                    empNewCustomersTab.Text = Convert.ToString((employee as SalesRep).NumNewCustomers);
                    empCustomersLostTab.Text = Convert.ToString((employee as SalesRep).NumCustomersLost);
                    empPositionCB.Text = "Sales Representative";

                }
                if (employee.GetType() == typeof(SupportRep))
                {
                    empCustomersHelpTab.Text = Convert.ToString((employee as SupportRep).NumCustomersHelped);
                    empCustomersScamTab.Text = Convert.ToString((employee as SupportRep).NumCustomersScammed);
                    empPositionCB.Text = "Support Representative";
                }
            }
        }
        Employee foundEmp;
        private void btnSEARCH_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (empIDTab.Text == "")
            {
                MessageBox.Show("Please enter an employee ID to search");
                return;
            }
            foundEmp = searchEmployee(empIDTab.Text);
            fillForm(foundEmp);
        }

        private void deleteEmployee(string ID)
        {
            for (int i = 0; i < Company.DEP_IT.Count; i++)
            {
                if (Company.DEP_IT[i].EmpId == ID)
                {
                    Company.DEP_IT.RemoveAt(i);
                }
            }
            for (int i = 0; i < Company.DEP_SALES.Count; i++)
            {
                if (Company.DEP_SALES[i].EmpId == ID)
                {
                    Company.DEP_SALES.RemoveAt(i);
                }
            }
            for (int i = 0; i < Company.DEP_SUPPORT.Count; i++)
            {
                if (Company.DEP_SUPPORT[i].EmpId == ID)
                {
                    Company.DEP_SUPPORT.RemoveAt(i);
                }
            }
        }

        private void btnEDIT_MouseClick(object sender, MouseEventArgs e)
        {
            if (empIDTab.Text == "")
            {
                MessageBox.Show("Please search for an employee first to edit");
                return;
            }
            String ID = foundEmp.EmpId;
                if (FormFilled())
                {
                    deleteEmployee(ID);
                    createEmployee(empPositionCB.Text);
                    MessageBox.Show("Employee edited successfully");
                }
        }

        private void btnDELETE_MouseClick(object sender, MouseEventArgs e)
        {
            if (empIDTab.Text == "")
            {
                MessageBox.Show("Please search for an employee first to delete");
                return;
            }
            deleteEmployee(empIDTab.Text);
            MessageBox.Show("Employee deleted successfully");
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();

        }
    }
}
