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
    Public class Person
    {
        private string firstName;
        private string lastName;
        public void addPerson()
        {
            Person p = new Person();

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

        /*public void Save(string filename)
        {
            using (var stream = new FileStream(filename, FileMode.Create))
            {
                var XML = new XmlSerializer(typeof(Person));
                XML.Serialize(stream, this);
            }
        }

        public static Person LoadFromFile(string fileName)
        {
            using (var stream = new FileStream(fileName, FileMode.Open))
            {
                var XML = new XmlSerializer(typeof(Person));
                return (Person)XML.Deserialize(stream);
            }
        }*/

        public Person()
        {
            FirstName = "Testus";
            LastName = "Test";
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            string output = string.Empty;

            output += string.Format("{0}, {1}", LastName, FirstName);

            return output;
        }
        public static Person[] DataStoreEmployee = new Person[1];

        public static void Write(Person person)
        {
            StreamWriter sw = new StreamWriter("Person.txt");
            sw.WriteLine(DataStoreEmployee.Length + 1);
            sw.WriteLine(person.FirstName);
            sw.WriteLine(person.LastName);

            for (int x = 0; x < DataStoreEmployee.Length; x++)
            {
                sw.WriteLine(DataStoreEmployee[x].FirstName);
                sw.WriteLine(DataStoreEmployee[x].LastName);
            }

            sw.Close();
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

        public static void Display()
        {
            LstOutput.Items.Clear();
           
            for (int x = 0; x < DataStoreEmployee.Length; x++)
            {
                LstOutput.Items.Add(DataStoreEmployee[x].ToString());
            }
        }

        public static void ClearForm()
        {
            TxtEmployeeCreatFirstn.Text = string.Empty;
            TxtEmployeeCreatLastn.Text = string.Empty;
        }
    }
}
