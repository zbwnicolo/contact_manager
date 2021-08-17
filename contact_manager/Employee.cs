using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contact_manager
{
    class Employee : Person
    {
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
    }
}
