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


        public Customer(CreatePerson cp) : base()
        {
            this.CustomerID = Guid.NewGuid();
            this.CustomerType = cp.TxtPersonCreatCompAddr.Text;
        }
        public Customer()
        {

        }
        public Guid CustomerID { get; private set; }
        public string CustomerType
        {
            get { return customerType; }
            set { customerType = value; }
        }
        public override void addPerson(CreatePerson cp)
        {
            StreamWriter sw = new StreamWriter("Person.txt", append: true);
            Customer c = new Customer(cp);
            sw.WriteLine(c);
            sw.Close();
        }
        public override void TxtToObject()
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
                    Person.people.Add(new Customer
                    {
                        CustomerID = Guid.Parse(words[0]),
                        CustomerType = (words[29]),
                    });
                }

                file.Close();
            }
        }
    }
}
