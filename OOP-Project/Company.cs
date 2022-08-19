using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    using System;
    [Serializable]
    public static class Company
    {
         public static string compName = "The Default Company";
         public static int numTotalEmp = 0;
         public static List<Employee> DEP_IT= new List<Employee>();
         public static List<Employee> DEP_SALES = new List<Employee>();
         public static List<Employee> DEP_SUPPORT = new List<Employee>();
         public static List<List<Employee>> COMPANY_LIST = new List<List<Employee>> { DEP_IT,DEP_SALES,DEP_SUPPORT};
         
         
    }
    [Serializable]
    public abstract class Employee
    {
        //instance variables
        string empId; 
        string empFirstName;
        string empLastName;
        string empBirthDate;
        string empAddress;
        string empGender;
        string empPhone;
        string empEducation;
        string empWorkStatus;
        int    empSalary;

        public Employee(string empId,string empFirstName,string empLastName, string empBirthDate, 
            string empAddress, string empGender, string empPhone, string empEducation, 
            string empWorkStatus, int empSalary) 
        {
            this.empId = empId;
            this.empFirstName = empFirstName;
            this.empLastName = empLastName;
            this.empBirthDate = empBirthDate;
            this.empAddress = empAddress;
            this.empGender = empGender;
            this.empPhone = empPhone;
            this.empEducation = empEducation;
            this.empWorkStatus = empWorkStatus;
            this.empSalary = empSalary;
        }

        public string EmpId
        {
            get{ return empId; }
            set { empId = value; } 
        }
        public string EmpFirstName 
        {
            get { return empFirstName; }
            set { empFirstName = value; }
        }
        public string EmpLastName 
        {
            get { return empLastName; }
            set { empLastName = value; }
        }
        public string EmpBirthDate
        {
            get { return empBirthDate; }
            set { empBirthDate = value; }
        }
        public string EmpAddress {
            get { return empAddress; }
            set { empAddress = value; }
        }
        public string EmpGender {
            get { return empGender; }
            set { empGender = value; }
        }
        public string EmpPhone {
            get { return empPhone; }
            set { empPhone = value; }
        }
        public string EmpEducation 
        {
            get { return empEducation; }
            set { EmpEducation = value; }
        }
        public string EmpWorkStatus {
            get { return empWorkStatus; }
            set { empWorkStatus = value; }
        }
        public int EmpSalary 
        {
            get { return empSalary; }
            set { empSalary = value; }
        }

    }
    [Serializable]
    public abstract class Programmer : Employee 
    {
        int numOfBugsFixed;
        int numOfCurProjects;

        public Programmer(string empId, string empFirstName, string empLastName, string empBirthDate,
                     string empAddress, string empGender, string empPhone, string empEducation,
                     string empWorkStatus, int empSalary, int numOfBugsFixed, int numOfCurProjects) 
                :base(empId,empFirstName,empLastName,empBirthDate,empAddress,empGender,empPhone,empEducation,empWorkStatus,empSalary)
        {
            this.numOfBugsFixed = numOfBugsFixed;
            this.numOfCurProjects = numOfCurProjects;
        }

        public int NumOfBugsFixed
        {
            get { return numOfBugsFixed; }
            set { numOfBugsFixed = value;  }
        }

        public int NumOfCurProjects 
        {
            get { return numOfCurProjects; }
            set { numOfCurProjects = value; }
        }
    }
    [Serializable]
    public class JuniorDev : Programmer {
        int timesAskedHelp;
        int numBugsCreated;

        public JuniorDev(string empId, string empFirstName, string empLastName, string empBirthDate,
                     string empAddress, string empGender, string empPhone, string empEducation, 
                     string empWorkStatus, int empSalary , int numOfBugsFixed, int numOfCurProjects, int timesAskedHelp, int numBugsCreated)
            :base(empId, empFirstName, empLastName, empBirthDate,empAddress, empGender, empPhone, empEducation, empWorkStatus, empSalary, numOfBugsFixed, numOfCurProjects)
        {
            this.timesAskedHelp = timesAskedHelp;
            this.numBugsCreated = numBugsCreated;
        }

        public int TimesAskedHelp
        {
            get { return timesAskedHelp; }
            set { timesAskedHelp = value; }
        }

        public int NumBugsCreated
        {
            get { return numBugsCreated; }
            set { numBugsCreated = value; }
        }
    }
    [Serializable]
    public class SeniorDev : Programmer{
        int numCriticalBugFix;
        int numTechnologies;

        public SeniorDev(string empId, string empFirstName, string empLastName, string empBirthDate,
                     string empAddress, string empGender, string empPhone, string empEducation,
                     string empWorkStatus, int empSalary, int numOfBugsFixed, int numOfCurProjects, int numCriticalBugFix, int numTechnologies)
            : base(empId, empFirstName, empLastName, empBirthDate, empAddress, empGender, empPhone, empEducation, empWorkStatus, empSalary, numOfBugsFixed, numOfCurProjects) 
        {
            this.numCriticalBugFix = numCriticalBugFix;
            this.numTechnologies = numTechnologies;
        }

        public int NumCriticalBugFix 
        {
            get { return numCriticalBugFix; }
            set { numCriticalBugFix = value; }
        }
        public int NumTechnologies 
        {
            get { return numTechnologies; }
            set { numTechnologies = value; }
        }
    }
    [Serializable]
    public class Technician : Programmer {
        int numComputersFixed;
        int numComputersNeedFix;

        public Technician(string empId, string empFirstName, string empLastName, string empBirthDate,
                     string empAddress, string empGender, string empPhone, string empEducation,
                     string empWorkStatus, int empSalary, int numOfBugsFixed, int numOfCurProjects, int numComputersFixed, int numComputersNeedFix)
            : base(empId, empFirstName, empLastName, empBirthDate, empAddress, empGender, empPhone, empEducation, empWorkStatus, empSalary, numOfBugsFixed, numOfCurProjects)
        {
            this.numComputersFixed = numComputersFixed;
            this.numComputersNeedFix = numComputersNeedFix;
        }

        public int NumComputersFixed 
        {
            get { return numComputersFixed; }
            set { numComputersFixed = value; }
        }

        public int NumComputersNeedFix 
        {
            get { return numComputersNeedFix; }
            set { numComputersNeedFix = value; }
        }
    }
    [Serializable]
    public class SalesRep : Employee {
        int numNewCustomers;
        int numCustomersLost;
        public SalesRep(string empId, string empFirstName, string empLastName, string empBirthDate,
                     string empAddress, string empGender, string empPhone, string empEducation,
                     string empWorkStatus, int empSalary, int numNewCustomers, int numCustomersLost)
           : base(empId, empFirstName, empLastName, empBirthDate, empAddress, empGender, empPhone, empEducation, empWorkStatus, empSalary)
        {
            this.numNewCustomers = numNewCustomers;
            this.numCustomersLost = numCustomersLost;
        }
    
        
        public int NumNewCustomers 
        {
            get { return numNewCustomers; }
            set { numNewCustomers = value; }
        }

        public int NumCustomersLost
        {
            get { return numCustomersLost; }
            set { numCustomersLost = value; }
        }
    }
    [Serializable]
    public class SupportRep : Employee
    {
        int numCustomersHelped;
        int numCustomersScammed;

        public SupportRep(string empId, string empFirstName, string empLastName, string empBirthDate,
             string empAddress, string empGender, string empPhone, string empEducation,
             string empWorkStatus, int empSalary, int numCustomersHelped, int numCustomersScammed)
          : base(empId, empFirstName, empLastName, empBirthDate, empAddress, empGender, empPhone, empEducation, empWorkStatus, empSalary)
        {
            this.numCustomersHelped = numCustomersHelped;
            this.numCustomersScammed = numCustomersScammed;
        }

        public int NumCustomersHelped 
        {
            get { return numCustomersHelped; }
            set { numCustomersHelped = value; }
        }

        public int NumCustomersScammed 
        {
            get { return numCustomersScammed; }
            set { numCustomersScammed = value; }
        }
    }


}
