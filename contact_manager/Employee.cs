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

        public Employee(CreatePerson cp) : base(cp)
        {
            this.Department = cp.TxtPersonCreatCompDepart.Text;
            this.Role = cp.TxtPersonCreatCompRole.Text;
            this.EmploymentLevel = Convert.ToInt32(cp.TxtPersonCreatCompProcent.Text);
            this.ManagementLevel = cp.TxtPersonCreatCompEmplLvl.Text;
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
            if (new FileInfo("Employee.txt").Length != 0)
            {
                // Read the file and display it line by line.
                System.IO.StreamReader file = new System.IO.StreamReader("Employee.txt");
                while ((line = file.ReadLine()) != null)
                {
                    string[] words = line.Split(',');
                    Employee.employee.Add(new Employee
                    {
                        Department = (words[0]),
                        Role = (words[1]),
                        EmploymentLevel = Convert.ToInt32((words[2])),
                        ManagementLevel = (words[3]),
                        EntryDate = Convert.ToDateTime((words[4])),
                        ExitDate = Convert.ToDateTime((words[5])),
                        CompanyName = (words[6]),
                        CompanyStreet = (words[7]),
                        CompanyPlace = (words[8]),
                        CompanyPostcode = (words[9]),
                        PhoneNumberWork = (words[10]),
                        FaxNumber = (words[11]),
                        InstanceID = Guid.Parse(words[12]),
                        Type = (words[13]),
                        Salutation = words[14],
                        Title = words[15],
                        FirstName = words[16],
                        LastName = words[17],
                        Street = words[18],
                        Postcode = words[19],
                        Place = words[20],
                        PhoneNumberPriv = words[21],
                        PhoneNumberMobile = words[22],
                        Birthday = Convert.ToDateTime(words[23]),
                        Gender = words[24],
                        Email = words[25],
                        Nationality = words[26],
                        AHVNumber = words[27],
                        Status = Convert.ToBoolean(words[28]),
                    });
                }

                file.Close();
            }
        }
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