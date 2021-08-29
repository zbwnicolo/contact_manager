using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace contact_manager
{
    public class Person
    {
        public static string firstName;
        public static string lastName;
        public static int id = 1;
        public static Person[] DataStoreEmployee = new Person[1];
        public static void addPerson(CreateEmployee createEmployee)
        {
            string dir = Convert.ToString(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\ContactManagerData");
            Directory.CreateDirectory(dir);
            StreamWriter sw = new StreamWriter(dir + "\\Person.txt", true);

            Person p = new Person();
            p.FirstName = createEmployee.TxtEmployeeCreatFirstn.Text;
            p.LastName = createEmployee.TxtEmployeeCreatLastn.Text;

            sw.WriteLine(p);

            for (int x = 0; x < DataStoreEmployee.Length; x++)
            {
                //sw.WriteLine(DataStoreEmployee[x]);
                //sw.WriteLine(DataStoreEmployee[x]);
            }

            id++;

            sw.Close();
        }

        public void deletePerson()
        {

        }

        public void editPerson()
        {

        }
        public string Salutation
        {
            get;
            set;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public DateTime Birthday
        {
            get;
            set;
        }

        public string Gender
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }

        public string PhoneNumberPriv
        {
            get;
            set;
        }

        public string PhoneNumberWork
        {
            get;
            set;
        }

        public string FaxNumber
        {
            get;
            set;
        }

        public string PhoneNumberMobile
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }

        public Boolean Status
        {
            get;
            set;
        }

        public string Place
        {
            get;
            set;
        }

        public string Nationality
        {
            get;
            set;
        }

        public string Street
        {
            get;
            set;
        }

        public string Postcode
        {
            get;
            set;
        }

        public Person()
        {

        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Salutation = Salutation;
        }

        public override string ToString()
        {
            string output = string.Empty;

            output += string.Format("{0}, {1}", LastName, FirstName);

            return output;
        }

        public static void Read()
        {
            StreamReader sr = new StreamReader("Person.txt");
            DataStoreEmployee = new Person[Convert.ToInt32(sr.ReadLine())];

            for (int x = 0; x < DataStoreEmployee.Length; x++)
            {
                DataStoreEmployee[x] = new Person();
                DataStoreEmployee[x].FirstName = sr.ReadLine();
                DataStoreEmployee[x].LastName = sr.ReadLine();
            }

            sr.Close();
        }

        public static void Display(CreateEmployee createEmployee)
        {
            createEmployee.LstOutput.Items.Clear();
           
            for (int x = 0; x < DataStoreEmployee.Length; x++)
            {
                createEmployee.LstOutput.Items.Add(DataStoreEmployee[x].ToString());
            }
        }

        public static void ClearForm(CreateEmployee createEmployee)
        {
            createEmployee.TxtEmployeeCreatFirstn.Text = string.Empty;
            createEmployee.TxtEmployeeCreatLastn.Text = string.Empty;
        }
    }
}
