using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Data;

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
        public static DataTable tbl = new DataTable();

        //Constructor class Person
        public Person(CreateEmployee ce)
        {
            this.FirstName = ce.TxtEmployeeCreatFirstn.Text;
            this.LastName = ce.TxtEmployeeCreatLastn.Text;
            this.Salutation = Convert.ToString(ce.CmbDropEmployeeCreatSalut.Text);
            this.PhoneNumber = ce.TxtEmployeeCreatTel.Text;
            this.Birthday = DateTime.Now;
            this.Gender = ce.CmbEmployeeCreatGend.Text;
            this.Title = ce.TxtEmployeeCreatTitle.Text;
            this.PhoneNumberPriv = ce.TxtEmployeeCreatCompTel.Text;
            this.PhoneNumberWork = ce.TxtEmployeeCreatCompTel.Text;
            this.FaxNumber = ce.TxtEmployeeCreatCompFax.Text;
            this.PhoneNumberMobile = ce.TxtEmployeeCreatMobile.Text;
            this.Email = ce.TxtEmployeeCreatMailPriv.Text;
            this.Status = ce.GrbEmployeeStatus.Enabled;
            this.Place = ce.TxtEmployeeCreatResid.Text;
            this.Nationality = ce.TxtEmployeeCreatNation.Text;
            this.Street = ce.TxtEmployeeCreatAddr.Text;
            this.Postcode = ce.TxtEmployeeCreatZipcode.Text;

            /*Employee p = new Employee();
            p.Street = TxtClientCreatAddr.Text;
            p.AhvNumber = TxtClientCreatAhv.Text;
            p.Birthday = Convert.ToDateTime(TxtClientCreatBirth.Text);
            p.CompanyStreet = TxtClientCreatCompAddr.Text;
            TxtClientCreatCompDepart.Text;
            TxtClientCreatCompEmplLvl.Text;
            TxtClientCreatCompEmployNr.Text;
            p.EntryDate = Convert.ToDateTime(TxtClientCreatCompEntryDate.Text);
            p.ExitDate = Convert.ToDateTime(TxtClientCreatCompExitDate.Text);
            p.FaxNumber = TxtClientCreatCompFax.Text;
            p.CompanyName = TxtClientCreatCompName.Text;
            p.TxtClientCreatCompProcent.Text;
            TxtClientCreatCompRes.Text;
            TxtClientCreatCompRole.Text;
            p TxtClientCreatCompTel.Text;
            p.TxtClientCreatCompZipCode.Text;
            p.FirstName = TxtClientCreatFirstn.Text;
            p.LastName = TxtClientCreatLastn.Text;
            p.Email = TxtClientCreatMailPriv.Text;
            p.PhoneNumberMobile = TxtClientCreatMobile.Text;
            p.Nationality = TxtClientCreatNation.Text;
            p.TxtClientCreatResid.Text;
            p.TxtClientCreatTel.Text;
            p.Title = TxtClientCreatTitle.Text;
            p.TxtClientCreatZipcode.Text; */
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

            sw.WriteLine(p);

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

        public string Salutation
        {
            get { return salutation; }
            set { salutation = value; } 
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
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
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string PhoneNumberPriv
        {
            get { return phoneNumberPriv; }
            set { phoneNumberPriv = value; }
        }
        public string PhoneNumberWork
        {
            get { return phoneNumberWork ; }
            set { phoneNumberWork = value; }
        }
        public string FaxNumber
        {
            get { return faxNumer; }
            set { faxNumer = value; }
        }
        public string PhoneNumberMobile
        {
            get { return phoneNumberMobile; }
            set { phoneNumberMobile = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public Boolean Status
        {
            get { return status; }
            set { status = value; }
        }
        public string Place
        {
            get { return place; }
            set { place = value; }
        }
        public string Nationality
        {
            get { return nationality; }
            set { nationality = value; }
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

        public static DataTable ConvertToDataTable(string filePath, int numberOfColumns)
        {
            //DataTable tbl = new DataTable();

            for (int col = 0; col < numberOfColumns; col++)
                tbl.Columns.Add(new DataColumn("Column" + (col + 1).ToString()));


            string[] lines = System.IO.File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                var cols = line.Split(',');

                DataRow dr = tbl.NewRow();
                for (int cIndex = 0; cIndex < numberOfColumns; cIndex++)
                {
                    dr[cIndex] = cols[cIndex];
                }
                tbl.Rows.Add(dr);
            }

            return tbl;
        }
    }
}
