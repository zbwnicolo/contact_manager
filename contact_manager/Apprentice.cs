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
        public static List<Apprentice> apprentice = new List<Apprentice>();
        public Apprentice(CreatePerson cp)
        {
            
            this.YearsApprenticeship = Convert.ToInt32(cp.TxtPersonCreatCompAddr.Text);
            this.CurrentYear = Convert.ToInt32(cp.TxtPersonCreatCompAddr.Text);
        }

        public Apprentice()
        {

        }
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
            StreamWriter sw = new StreamWriter("Apprentice.txt", append: true);
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
                System.IO.StreamReader file = new System.IO.StreamReader("Apprentice.txt");
                while ((line = file.ReadLine()) != null)
                {
                    string[] words = line.Split(',');
                    Apprentice.apprentice.Add(new Apprentice
                    {
                        YearsApprenticeship = Convert.ToInt32((words[0])),
                        CurrentYear = Convert.ToInt32((words[1])),
                        InstanceID = Guid.Parse(words[2]),
                        Type = (words[3]),
                        Salutation = words[4],
                        Title = words[5],
                        FirstName = words[6],
                        LastName = words[7],
                        Street = words[8],
                        Postcode = words[9],
                        Place = words[10],
                        PhoneNumberPriv = words[11],
                        PhoneNumberMobile = words[12],
                        Birthday = Convert.ToDateTime(words[13]),
                        Gender = words[14],
                        Email = words[15],
                        Nationality = words[16],
                        AHVNumber = words[17],
                        Status = Convert.ToBoolean(words[18]),
                    });
                }

                file.Close();
            }
        }
    }
}
