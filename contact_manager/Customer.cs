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
            this.CustomerType = cp.TxtPersonCreatAddr.Text;
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
