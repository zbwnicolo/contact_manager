using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contact_manager
{
    
    public class Apprentice : Employee
    {
        public Apprentice(CreatePerson cp)
        {
            //CHANGE
            this.YearsApprenticeship = Convert.ToInt32(cp.TxtEmployeeCreatCompAddr.Text);
            this.CurrentYear = Convert.ToInt32(cp.TxtEmployeeCreatCompAddr.Text);
        }

        public Apprentice()
        {

        }

        public int YearsApprenticeship
        {
            get;
            set;
        }

        public int CurrentYear
        {
            get;
            set;
        }
    }
}
