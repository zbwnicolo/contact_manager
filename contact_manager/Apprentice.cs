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
        public Apprentice(CreatePerson cp) :base(cp)
        {
            
            this.YearsApprenticeship = Convert.ToInt32(cp.TxtPersonCreatYearsApprenticeship.Text);
            this.CurrentYear = Convert.ToInt32(cp.TxtPersonCreaCurrentYear.Text);
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
            if (new FileInfo("Apprentice.txt").Length != 0)
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
                        Department = (words[2]),
                        Role = (words[3]),
                        EmploymentLevel = Convert.ToInt32((words[4])),
                        ManagementLevel = (words[5]),
                        EntryDate = Convert.ToDateTime((words[6])),
                        ExitDate = Convert.ToDateTime((words[7])),
                        CompanyName = (words[8]),
                        CompanyStreet = (words[9]),
                        CompanyPlace = (words[10]),
                        CompanyPostcode = (words[11]),
                        PhoneNumberWork = (words[12]),
                        FaxNumber = (words[13]),
                        InstanceID = Guid.Parse(words[14]),
                        Type = (words[15]),
                        Salutation = words[16],
                        Title = words[17],
                        FirstName = words[18],
                        LastName = words[19],
                        Street = words[20],
                        Postcode = words[21],
                        Place = words[22],
                        PhoneNumberPriv = words[23],
                        PhoneNumberMobile = words[24],
                        Birthday = Convert.ToDateTime(words[25]),
                        Gender = words[26],
                        Email = words[27],
                        Nationality = words[28],
                        AHVNumber = words[29],
                        Status = Convert.ToBoolean(words[30]),
                    });
                }

                file.Close();
            }
        }
    }
}
