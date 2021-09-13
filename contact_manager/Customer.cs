using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contact_manager
{
    class Customer : Person
    {

        public Customer(CreatePerson cp)
        {
            this.CustomerType = cp.TxtEmployeeCreatCompAddr.Text;
        }
        public string CustomerType
        {
            get;
            set;
        }
    }
}
