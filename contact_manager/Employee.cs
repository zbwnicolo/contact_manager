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
        public string phoneNumberWork;
        public string faxNumer;

        public Employee(CreatePerson cp) : base()
        {
            this.PhoneNumberWork = cp.TxtEmployeeCreatCompTel.Text;
            this.FaxNumber = cp.TxtEmployeeCreatCompFax.Text;
        }
        public Employee()
        {

        }

        public override void addPerson(CreatePerson cp)
        {
            StreamWriter sw = new StreamWriter("Person.txt", append: true);
            Employee e = new Employee(cp);
            sw.WriteLine(e);
            sw.Close();
        }

        public string Department
        {
            get;
            set;
        }

        public string Role
        {
            get;
            set;
        }

        public int EmploymentLevel
        {
            get;
            set;
        }

        public string ManagementLevel
        {
            get;
            set;
        }

        public DateTime EntryDate
        {
            get;
            set;
        }

        public DateTime ExitDate
        {
            get;
            set;
        }

        public string AhvNumber
        {
            get;
            set;
        }

        public string CompanyName
        {
            get;
            set;
        }

        public string CompanyStreet
        {
            get;
            set;
        }

        public string CompanyPlace
        {
            get;
            set;
        }

        public string CompanyPostcode
        {
            get;
            set;
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
