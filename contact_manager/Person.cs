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
        public string firstName;
        public string lastName;
        public string salutation;
        public string phoneNumber;
        public DateTime birthday;
        public string gender;
        public string title;
        public string phoneNumberPriv;
        public string phoneNumberWork;
        public string faxNumer;
        public string phoneNumberMobile;
        public string email;
        public Boolean status;
        public string place;
        public string nationality;
        public string street;
        public string postcode;
        public static int id = 1;
        public static Person[] DataStoreEmployee = new Person[1];

        //Constructor class Person
        public Person(CreateEmployee ce)
        {
            this.FirstName = ce.TxtEmployeeCreatFirstn.Text;
            this.LastName = ce.TxtEmployeeCreatLastn.Text;
            this.Salutation = Convert.ToString(ce.CmbDropEmployeeCreatSalut.Text);
            this.PhoneNumber = "";
            this.Birthday = DateTime.Now;
            this.Gender = "";
            this.Title = "";
            this.PhoneNumberPriv = "";
            this.PhoneNumberWork = "";
            this.FaxNumber = "";
            this.PhoneNumberMobile = "";
            this.Email = "";
            this.Status = true;
            this.Place = "";
            this.Nationality = "";
            this.Street = "";
            this.Postcode = "";
        }

        public Person()
        {

        }

        public static void addPerson(CreateEmployee createEmployee)
        {
            string dir = Convert.ToString(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\ContactManagerData");
            Directory.CreateDirectory(dir);
            //StreamWriter sw = new StreamWriter(dir + "\\Person.txt", true);
            StreamWriter sw = new StreamWriter("Person.txt", true);

            Person p = new Person(createEmployee);
            Console.WriteLine(createEmployee.CmbDropEmployeeCreatSalut.Text);
            //p.FirstName = createEmployee.TxtEmployeeCreatFirstn.Text;
            //p.LastName = createEmployee.TxtEmployeeCreatLastn.Text;

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

        public string Salutation {
            get { return salutation; }
            set { salutation = value; } 
        }
        public string PhoneNumber { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public string Title { get; set; }
        public string PhoneNumberPriv { get; set; }
        public string PhoneNumberWork { get; set; }
        public string FaxNumber { get; set; }
        public string PhoneNumberMobile { get; set; }
        public string Email { get; set; }
        public Boolean Status { get; set; }
        public string Place { get; set; }
        public string Nationality { get; set; }
        public string Street { get; set; }
        public string Postcode { get; set; }

        /*
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Salutation = Salutation;
        }
        */

        public override string ToString()
        {
            string output = string.Empty;

            output += string.Format("{0}, {1}, {2}", LastName, FirstName, Salutation);

            return output;
        }

        public static void Read()
        {
            StreamReader sr = new StreamReader("Person.txt");
            DataStoreEmployee = new Person[Convert.ToInt32(sr.ReadLine())];

            /*
            for (int x = 0; x < DataStoreEmployee.Length; x++)
            {
                DataStoreEmployee[x] = new Person(CreateEmployee);
                DataStoreEmployee[x].FirstName = sr.ReadLine();
                DataStoreEmployee[x].LastName = sr.ReadLine();
            }
            */

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

        public static void ClearForm(CreateEmployee ce)
        {
            ce.TxtEmployeeCreatFirstn.Text = string.Empty;
            ce.TxtEmployeeCreatLastn.Text = string.Empty;
        }
    }
}
