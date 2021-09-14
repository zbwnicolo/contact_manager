using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contact_manager
{
    public class Employee : Person
    {
        public string department;
        public string role;
        public int employmentLevel;
        public string managementLevel;
        public DateTime entryDate;
        public DateTime exitDate;
        public string companyName;
        public string companyStreet;
        public string companyPlace;
        public string companyPostcode;
        public string phoneNumberWork;
        public string faxNumer;
        public static List<Employee> employee = new List<Employee>();

        public Employee(CreatePerson cp) : base()
        {
            this.EmployeeID = Guid.NewGuid();
            this.Department = cp.TxtPersonCreatCompDepart.Text;
            this.Role = cp.TxtPersonCreatCompRole.Text;
            this.EmploymentLevel = Convert.ToInt32(cp.TxtPersonCreatCompEmplLvl.Text);
            this.ManagementLevel = cp.TxtPersonCreatCompProcent.Text;
            this.EntryDate = Convert.ToDateTime(cp.TxtPersonCreatCompEntryDate.Text);
            this.ExitDate = Convert.ToDateTime(cp.TxtPersonCreatCompExitDate.Text);
            this.AHVNumber = cp.TxtPersonCreatAhv.Text;
            this.CompanyName = cp.TxtPersonCreatCompName.Text;
            this.CompanyStreet = cp.TxtPersonCreatCompAddr.Text;
            this.CompanyPlace = cp.TxtPersonCreatCompRes.Text;
            this.CompanyPostcode = cp.TxtPersonCreatCompZipCode.Text;
            this.PhoneNumberWork = cp.TxtPersonCreatCompTel.Text;
            this.FaxNumber = cp.TxtPersonCreatCompFax.Text;
        }
        public Employee()
        {

        }

        public override void addPerson(CreatePerson cp)
        {
            StreamWriter sw = new StreamWriter("Employee.txt", append: true);
            Employee e = new Employee(cp);
            sw.WriteLine(e);
            sw.Close();
        }
        public override void TxtToObject()
        {
            string line;

            //Check if file is empty
            if (new FileInfo("Person.txt").Length != 0)
            {
                // Read the file and display it line by line.
                System.IO.StreamReader file = new System.IO.StreamReader("Employee.txt");
                while ((line = file.ReadLine()) != null)
                {
                    string[] words = line.Split(',');
                    Employee.employee.Add(new Employee
                    {
                        EmployeeID = Guid.Parse(words[0]),
                        Department = (words[17]),
                        Role = (words[18]),
                        EmploymentLevel = Convert.ToInt32((words[19])),
                        ManagementLevel = (words[20]),
                        EntryDate = Convert.ToDateTime((words[21])),
                        ExitDate = Convert.ToDateTime((words[22])),
                        CompanyName = (words[23]),
                        CompanyStreet = (words[24]),
                        CompanyPlace = (words[25]),
                        CompanyPostcode = (words[26]),
                        PhoneNumberWork = (words[27]),
                        FaxNumber = (words[28]),
                    });
                }

                file.Close();
            }
        }
        public Guid EmployeeID { get; private set; }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        public int EmploymentLevel
        {
            get { return employmentLevel; }
            set { employmentLevel = value; }
        }

        public string ManagementLevel
        {
            get { return managementLevel; }
            set { managementLevel = value; }
        }

        public DateTime EntryDate
        {
            get { return entryDate; }
            set { entryDate = value; }
        }

        public DateTime ExitDate
        {
            get { return exitDate; }
            set { exitDate = value; }
        }

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        public string CompanyStreet
        {
            get { return companyStreet; }
            set { companyStreet = value; }
        }

        public string CompanyPlace
        {
            get { return companyPlace; }
            set { companyPlace = value; }
        }

        public string CompanyPostcode
        {
            get { return companyPostcode; }
            set { companyPostcode = value; }
        }
        public string PhoneNumberWork
        {
            get { return phoneNumberWork; }
            set { phoneNumberWork = value; }
        }
        public string FaxNumber
        {
            get { return faxNumer; }
            set { faxNumer = value; }
        }
    }
}