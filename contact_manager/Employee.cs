using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contact_manager
{
    class Employee : Person
    {
        public Employee()
        {
            /*p.Street = TxtClientCreatAddr.Text;
            p.AhvNumber = TxtClientCreatAhv.Text;
            p.Birthday = Convert.ToDateTime(TxtClientCreatBirth.Text);
            p.CompanyStreet = TxtClientCreatCompAddr.Text;
            TxtClientCreatCompDepart.Text;
            TxtClientCreatCompEmplLvl.Text;
            TxtClientCreatCompEmployNr.Text;
            p.EntryDate = Convert.ToDateTime(TxtClientCreatCompEntryDate.Text);
            p.ExitDate = Convert.ToDateTime(TxtClientCreatCompExitDate.Text);
            p.FaxNumber = TxtClientCreatCompFax.Text;
            p.CompanyName = TxtClientCreatCompName.Text;
            p.TxtClientCreatCompProcent.Text;
            TxtClientCreatCompRes.Text;
            TxtClientCreatCompRole.Text;
            p TxtClientCreatCompTel.Text;
            p.TxtClientCreatCompZipCode.Text;
            p.FirstName = TxtClientCreatFirstn.Text;
            p.LastName = TxtClientCreatLastn.Text;
            p.Email = TxtClientCreatMailPriv.Text;
            p.PhoneNumberMobile = TxtClientCreatMobile.Text;
            p.Nationality = TxtClientCreatNation.Text;
            p.TxtClientCreatResid.Text;
            p.TxtClientCreatTel.Text;
            p.Title = TxtClientCreatTitle.Text;
            p.TxtClientCreatZipcode.Text; */
        }
        public string Department
        {
            get;
            set;
        }

        public string Role
        {
            get;
            set;
        }

        public int EmploymentLevel
        {
            get;
            set;
        }

        public string ManagementLevel
        {
            get;
            set;
        }

        public DateTime EntryDate
        {
            get;
            set;
        }

        public DateTime ExitDate
        {
            get;
            set;
        }

        public string AhvNumber
        {
            get;
            set;
        }

        public string CompanyName
        {
            get;
            set;
        }

        public string CompanyStreet
        {
            get;
            set;
        }

        public string CompanyPlace
        {
            get;
            set;
        }

        public string CompanyPostcode
        {
            get;
            set;
        }
    }
}
