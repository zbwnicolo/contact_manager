﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Reflection;

namespace contact_manager
{
    public class Person
    {
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
        
        public string phoneNumberWork;
        public string faxNumer;
        
        
        public Boolean status;
        
        
        
        
        public static List<Person> people = new List<Person>();

        //Constructor class Person
        public Person(CreateEmployee ce)
        {
            this.InstanceID = Guid.NewGuid();
            this.Salutation = Convert.ToString(ce.CmbDropEmployeeCreatSalut.Text);
            this.Title = ce.TxtEmployeeCreatTitle.Text;
            this.FirstName = ce.TxtEmployeeCreatFirstn.Text;
            this.LastName = ce.TxtEmployeeCreatLastn.Text;
            this.Birthday = DateTime.Now;
            this.PhoneNumberPriv = ce.TxtEmployeeCreatTel.Text;
            this.PhoneNumberMobile = ce.TxtEmployeeCreatMobile.Text;
            this.Nationality = ce.TxtEmployeeCreatNation.Text;
            this.Gender = ce.CmbEmployeeCreatGend.Text;
            this.Street = ce.TxtEmployeeCreatAddr.Text;
            this.Place = ce.TxtEmployeeCreatResid.Text;
            this.Postcode = ce.TxtEmployeeCreatZipcode.Text;
            this.Email = ce.TxtEmployeeCreatMailPriv.Text;
            this.AHVNumber = ce.TxtEmployeeCreatAhv.Text;


            this.PhoneNumberWork = ce.TxtEmployeeCreatCompTel.Text;
            this.FaxNumber = ce.TxtEmployeeCreatCompFax.Text;
            
            
            this.Status = ce.GrbEmployeeStatus.Enabled;
            
            
            
            
        }

        public Person()
        {

        }

        public Guid InstanceID { get; private set; }
  
        public static void addPerson(CreateEmployee createEmployee)
        {
            string dir = Convert.ToString(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\ContactManagerData");
            Directory.CreateDirectory(dir);
            StreamWriter sw = new StreamWriter("Person.txt", append: true);
            Person p = new Person(createEmployee);
            sw.WriteLine(p);
            sw.Close();
        }

        public void deletePerson()
        {
            //DELETE PERSON CODE
        }

        public void editPerson()
        {
            //DELETE PERSON CODE
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

        public string AHVNumber
        {
            get { return ahvNumber; }
            set { ahvNumber = value; }
        }

        /*public override string ToString()
        {
            string output = string.Empty;

            output += string.Format("{0}, {1}, {2}, {3}, {4}", InstanceID, Salutation, Title, FirstName, LastName);

            return output;
        }*/

        private PropertyInfo[] _PropertyInfos = null;

        //turn Properties into Strings to write them into the file
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

        public static void TxtToObject()
        {
            string line;

            //Check if file is empty
            if (new FileInfo("Person.txt").Length != 0)
            {
                // Read the file and display it line by line.
                System.IO.StreamReader file =
                    new System.IO.StreamReader("Person.txt");
                while ((line = file.ReadLine()) != null)
                {
                    string[] words = line.Split(',');
                    Person.people.Add(new Person
                    {
                        InstanceID = Guid.Parse(words[0]),
                        Salutation = words[1],
                        Title = words[2],
                        FirstName = words[3],
                        LastName = words[4],

                    });
                }

                file.Close();
            }
        }
    }
}
