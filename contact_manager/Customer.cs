using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace contact_manager
{
    class Customer : Person
    {
        public string customerType;
        public static List<Customer> customer = new List<Customer>();


        public Customer(CreatePerson cp) : base(cp)
        {
            this.CustomerType = cp.CmbPersonCreatCustomerType.Text;
        }
        public Customer()
        {

        }
        public string CustomerType
        {
            get { return customerType; }
            set { customerType = value; }
        }
        public override void addPerson(CreatePerson cp)
        {
            StreamWriter sw = new StreamWriter("Customer.txt", append: true);
            Customer c = new Customer(cp);
            sw.WriteLine(c);
            sw.Close();
        }
        public override void editPerson(EditPerson ep)
        {
            string id = ep.TxtInstanceID.Text;

            //Find person with selected ID and assign new values to object
            var obj = customer.FirstOrDefault(x => Convert.ToString(x.InstanceID) == id);

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
                obj.type = ep.CmbPersonMgmtType.Text;

                obj.customerType = ep.CmbPersonMgmtCustomerType.Text;
            }

            //write new list of Persons into file
            StreamWriter sw = new StreamWriter("Customer.txt");
            foreach (var person in customer)
            {
                sw.WriteLine(person);
            }
            sw.Close();

        }
        public override void deletePerson(Dashboard db)
        {
            string id = db.DataGridEmployee.SelectedRows[0].Cells[0].Value.ToString();

            //Loop through all Persons and compare IDs with selected ID
            for (int i = customer.Count - 1; i >= 0; i--)
            {
                if (Convert.ToString(customer[i].InstanceID) == id)
                {
                    customer.RemoveAt(i);
                }
            }

            //write remaining Persons into file
            StreamWriter sw = new StreamWriter("Customer.txt");
            foreach (var person in customer)
            {
                sw.WriteLine(person);
            }
            sw.Close();

        }
        public override void TxtToObject()
        {
            string line;

            //Check if file is empty
            if (new FileInfo("Customer.txt").Length != 0)
            {
                // Read the file and display it line by line.
                System.IO.StreamReader file = new System.IO.StreamReader("Customer.txt");
                while ((line = file.ReadLine()) != null)
                {
                    string[] words = line.Split(',');
                    Customer.customer.Add(new Customer
                    {
                        CustomerType = (words[0]),
                        InstanceID = Guid.Parse(words[1]),
                        Type = (words[2]),
                        Salutation = words[3],
                        Title = words[4],
                        FirstName = words[5],
                        LastName = words[6],
                        Street = words[7],
                        Postcode = words[8],
                        Place = words[9],
                        PhoneNumberPriv = words[10],
                        PhoneNumberMobile = words[11],
                        Birthday = Convert.ToDateTime(words[12]),
                        Gender = words[13],
                        Email = words[14],
                        Nationality = words[15],
                        AHVNumber = words[16],
                        Status = Convert.ToBoolean(words[17]),

                    });
                }

                file.Close();
            }
        }
    }
}
