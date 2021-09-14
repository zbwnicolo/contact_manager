using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace contact_manager
{
    
    public class Apprentice : Employee
    {
        public int yearApprenticeship;
        public int currentYear;
        public Apprentice(CreatePerson cp)
        {
            
            this.YearsApprenticeship = Convert.ToInt32(cp.TxtPersonCreatCompAddr.Text);
            this.CurrentYear = Convert.ToInt32(cp.TxtPersonCreatCompAddr.Text);
        }

        public Apprentice()
        {

        }
        public Guid ApprenticeID { get; private set; }
        public int YearsApprenticeship
        {
            get { return yearApprenticeship; }
            set { yearApprenticeship = value; }
        }
        public int CurrentYear
        {
            get { return currentYear; }
            set { currentYear = value; }
        }
        public override void addPerson(CreatePerson cp)
        {
            StreamWriter sw = new StreamWriter("Person.txt", append: true);
            Apprentice a = new Apprentice(cp);
            sw.WriteLine(a);
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
                    Person.people.Add(new Apprentice
                    {
                        ApprenticeID = Guid.Parse(words[0]),
                        YearsApprenticeship = Convert.ToInt32((words[30])),
                        CurrentYear = Convert.ToInt32((words[31])),
                    });
                }

                file.Close();
            }
        }
    }
}
