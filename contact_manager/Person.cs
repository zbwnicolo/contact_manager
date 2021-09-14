using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace contact_manager
{
    public class Person
    {
        public string type;
        public string salutation;
        public string title;
        public string firstName;
        public string lastName;
        public DateTime birthday;
        public string phoneNumberPriv;
        public string phoneNumberMobile;
        public string nationality;
        public string gender;
        public string street;
        public string place;
        public string postcode;
        public string email;
        public string ahvNumber;
        public Boolean status;
        public static List<Person> people = new List<Person>();
        private PropertyInfo[] _PropertyInfos = null;

        //Constructor class Person
        public Person(CreatePerson cp)
        {
            this.InstanceID = Guid.NewGuid();
            this.Type = cp.CmbPersonCreatType.Text; 
            this.Salutation = Convert.ToString(cp.CmbPersonCreatSalut.Text);
            this.Title = cp.TxtPersonCreatTitle.Text;
            this.FirstName = cp.TxtPersonCreatFirstn.Text;
            this.LastName = cp.TxtPersonCreatLastn.Text;
            this.Birthday = Convert.ToDateTime(cp.TxtPersonCreatBirth.Text);
            this.PhoneNumberPriv = cp.TxtPersonCreatTel.Text;
            this.PhoneNumberMobile = cp.TxtPersonCreatMobile.Text;
            this.Nationality = cp.TxtPersonCreatNation.Text;
            this.Gender = cp.CmbPersonCreatGend.Text;
            this.Street = cp.TxtPersonCreatAddr.Text;
            this.Place = cp.TxtPersonCreatResid.Text;
            this.Postcode = cp.TxtPersonCreatZipcode.Text;
            this.Email = cp.TxtPersonCreatMailPriv.Text;
            this.AHVNumber = cp.TxtPersonCreatAhv.Text;
            this.Status = Convert.ToBoolean(cp.RadCreatPersonActive.Checked);
        }

        public Person()
        {

        }
  
        //Method create new Person and add to file
        virtual public void addPerson(CreatePerson cp)
        {
            //StreamWriter sw = new StreamWriter("Person.txt", append: true);
            //Person p = new Person(cp);
            //sw.WriteLine(p);
            //sw.Close();
        }

        //Method delete Person and remove from file and table
        public static void deletePerson(Dashboard db)
        {
            string id = db.DataGridEmployee.SelectedRows[0].Cells[0].Value.ToString();

            //Loop through all Persons and compare IDs with selected ID
            for (int i = people.Count - 1; i >= 0; i--)
            {
                if (Convert.ToString(people[i].InstanceID) == id)
                {
                    people.RemoveAt(i);
                }
            }

            //write remaining Persons into file
            StreamWriter sw = new StreamWriter("Person.txt");
            foreach (var person in people)
            {
                sw.WriteLine(person);
            }
            sw.Close();

        }

        //Method edit person and write new values into file
        public static void editPerson(EditPerson ep)
        {
            string id = ep.TxtInstanceID.Text;

            //Find person with selected ID and assign new values to object
            var obj = people.FirstOrDefault(x => Convert.ToString(x.InstanceID) == id);

            if (obj != null)
            {
                obj.salutation = ep.CmbDropPersonMgmtSalut.Text;
                obj.title = ep.TxtPersonMgmtTitle.Text;
                obj.firstName = ep.TxtPersonMgmtFirstn.Text;
                obj.lastName = ep.TxtPersonMgmtLastn.Text;
                obj.birthday = Convert.ToDateTime(ep.TxtPersonMgmtBirth.Text);
                obj.phoneNumberPriv = ep.TxtPersonMgmtTel.Text;
                obj.phoneNumberMobile = ep.TxtPersonMgmtMobile.Text;
                obj.nationality = ep.TxtPersonMgmtNation.Text;
                obj.gender = ep.CmbPersonMgmtGend.Text;
                obj.street = ep.TxtPersonMgmtAddr.Text;
                obj.place = ep.TxtPersonMgmtResid.Text;
                obj.postcode = ep.TxtPersonMgmtZipcode.Text;
                obj.email = ep.TxtPersonMgmtMailPriv.Text;
                obj.ahvNumber = ep.TxtPersonMgmtAhv.Text;
                obj.status = ep.RadPersonMgmtActive.Checked;
            }

            //write new list of Persons into file
            StreamWriter sw = new StreamWriter("Person.txt");
            foreach (var person in people)
            {
                sw.WriteLine(person);
            }
            sw.Close();

        }
        public Guid InstanceID { get; private set; }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Salutation
        {
            get { return salutation; }
            set { salutation = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
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
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        public string Postcode
        {
            get { return postcode; }
            set { postcode = value; }
        }
        public string Place
        {
            get { return place; }
            set { place = value; }
        }
        public string PhoneNumberPriv
        {
            get { return phoneNumberPriv; }
            set { phoneNumberPriv = value; }
        }
        public string PhoneNumberMobile
        {
            get { return phoneNumberMobile; }
            set { phoneNumberMobile = value; }
        }
        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Nationality
        {
            get { return nationality; }
            set { nationality = value; }
        }
        public string AHVNumber
        {
            get { return ahvNumber; }
            set { ahvNumber = value; }
        }
        public Boolean Status
        {
            get { return status; }
            set { status = value; }
        }

        //loop through all Properties and turn them into Strings to write them into the file
        public override string ToString()
        {
            if (_PropertyInfos == null)
                _PropertyInfos = this.GetType().GetProperties();

            var sb = new StringBuilder();

            foreach (var info in _PropertyInfos)
            {
                var value = info.GetValue(this, null) ?? "(null)";
                sb.Append(value.ToString() + ",");
            }

            return sb.ToString();
        }

        //Method to read TXT file and turn data into Objects 
        virtual public void TxtToObject()
        {
            string line;

            //Check if file is empty
            if (new FileInfo("Person.txt").Length != 0)
            {
                // Read the file and display it line by line.
                System.IO.StreamReader file = new System.IO.StreamReader("Person.txt");
                while ((line = file.ReadLine()) != null)
                {
                    string[] words = line.Split(',');
                    Person.people.Add(new Person
                    {
                        InstanceID = Guid.Parse(words[0]),
                        Type = (words[1]),
                        Salutation = words[2],
                        Title = words[3],
                        FirstName = words[4],
                        LastName = words[5],
                        Street = words[6],
                        Postcode = words[7],
                        Place = words[8],
                        PhoneNumberPriv = words[9],
                        PhoneNumberMobile = words[10],
                        Birthday = Convert.ToDateTime(words[11]),
                        Gender = words[12],
                        Email = words[13],
                        Nationality = words[14],
                        AHVNumber = words[15],
                        Status = Convert.ToBoolean(words[16]),

                });
                }

                file.Close();
            }
        }
    }
}
