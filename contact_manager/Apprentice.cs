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
        public int yearsApprenticeship;
        public int currentYear;
        public static List<Apprentice> apprentice = new List<Apprentice>();
        public Apprentice(CreatePerson cp) :base(cp)
        {
            
            this.YearsApprenticeship = Convert.ToInt32(cp.NumPersonCreatYearsApprenticeship.Text);
            this.CurrentYear = Convert.ToInt32(cp.NumPersonCreaCurrentYear.Text);
        }

        public Apprentice()
        {

        }
        public int YearsApprenticeship
        {
            get { return yearsApprenticeship; }
            set { yearsApprenticeship = value; }
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
        public override void editPerson(EditPerson ep)
        {
            string id = ep.TxtInstanceID.Text;

            //Find person with selected ID and assign new values to object
            var obj = apprentice.FirstOrDefault(x => Convert.ToString(x.InstanceID) == id);

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

                obj.companyName = ep.TxtPersonMgmtCompName.Text;
                obj.companyStreet = ep.TxtPersonMgmtCompAddr.Text;
                obj.companyPlace = ep.TxtPersonMgmtResid.Text;
                obj.companyPostcode = ep.TxtPersonMgmtCompZipCode.Text;
                obj.phoneNumberWork = ep.TxtPersonMgmtCompTel.Text;
                obj.faxNumer = ep.TxtPersonMgmtCompFax.Text;
                obj.department = ep.TxtPersonMgmtCompDepart.Text;
                obj.employmentLevel = Convert.ToInt32(ep.NumPersonMgmtCompProcent.Value);
                obj.role = ep.TxtPersonMgmtCompRole.Text;
                obj.managementLevel = ep.TxtPersonMgmtCompEmplLvl.Text;
                obj.entryDate = Convert.ToDateTime(ep.DtpPersonMgmtCompEntryDate.Text);
                obj.exitDate = Convert.ToDateTime(ep.DtpPersonMgmtCompExitDate.Text);

                obj.yearsApprenticeship = Convert.ToInt32(ep.NumPersonMgmtYearsApprenticeship.Value);
                obj.currentYear = Convert.ToInt32(ep.NumPersonMgmtCurrentYear.Value);
            }

            //write new list of Persons into file
            StreamWriter sw = new StreamWriter("Apprentice.txt");
            foreach (var person in apprentice)
            {
                sw.WriteLine(person);
            }
            sw.Close();

        }
        public override void deletePerson(Dashboard db)
        {
            string id = db.DataGridEmployee.SelectedRows[0].Cells[0].Value.ToString();

            //Loop through all Persons and compare IDs with selected ID
            for (int i = apprentice.Count - 1; i >= 0; i--)
            {
                if (Convert.ToString(apprentice[i].InstanceID) == id)
                {
                    apprentice.RemoveAt(i);
                }
            }

            //write remaining Persons into file
            StreamWriter sw = new StreamWriter("Apprentice.txt");
            foreach (var person in apprentice)
            {
                sw.WriteLine(person);
            }
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
