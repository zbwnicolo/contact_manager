using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contact_manager
{
    public partial class CreatePerson : Form
    {
        public CreatePerson()
        {
            InitializeComponent();
            //Set default Value for Dropdown options
            CmbPersonCreatSalut.SelectedIndex = 1;
            CmbPersonCreatType.SelectedIndex = 1;
            CmbPersonCreatGend.SelectedIndex = 1;
        }

        private void CmdCreatPersonSave_Click(object sender, EventArgs e)
        {
            switch(this.CmbPersonCreatType.Text)
            {
                case ("Mitarbeiter"):
                    Employee emp = new Employee(this);
                    emp.addPerson(this);
                    Employee.employee.Clear();
                    emp.TxtToObject();
                    Dashboard.tbl.Clear();
                    Dashboard.LoadPeople();
                    break;

                case ("Kunde"):
                    Customer c = new Customer(this);
                    c.addPerson(this);
                    Customer.customer.Clear();
                    c.TxtToObject();
                    Dashboard.tbl.Clear();
                    Dashboard.LoadPeople();
                    break;

                case ("Lernender"):
                    Apprentice a = new Apprentice(this);
                    a.addPerson(this);
                    Apprentice.apprentice.Clear();
                    a.TxtToObject();
                    Dashboard.tbl.Clear();
                    Dashboard.LoadPeople();
                    break;
            }
            this.Close();
        }

        private void CmdCreatPersonAbort_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmbPersonCreatType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.CmbPersonCreatType.Text)
            {
                case ("Mitarbeiter"):
                    LblCreatPerson.Visible = true;
                    
                    LblCreatSalut.Visible = true;
                    CmbPersonCreatSalut.Visible = true;
                    LblCreatTitel.Visible = true;
                    TxtPersonCreatTitle.Visible = true;
                    LblCreatFirstn.Visible = true;
                    TxtPersonCreatFirstn.Visible = true;
                    LblCreatLastn.Visible = true;
                    TxtPersonCreatLastn.Visible = true;
                    LblCreatBirth.Visible = true;
                    TxtPersonCreatBirth.Visible = true;
                    LblCreatTelPriv.Visible = true;
                    TxtPersonCreatMailPriv.Visible = true;
                    LblCreatTelMobile.Visible = true;
                    TxtPersonCreatMobile.Visible = true;
                    LblCreatNation.Visible = true;
                    TxtPersonCreatNation.Visible = true;
                    LblCreatGender.Visible = true;
                    CmbPersonCreatGend.Visible = true;
                    LblCreatAddr.Visible = true;
                    TxtPersonCreatAddr.Visible = true;
                    LblCreatPlace.Visible = true;
                    TxtPersonCreatResid.Visible = true;
                    LblCreatPlz.Visible = true;
                    TxtPersonCreatZipcode.Visible = true;
                    LblCreatMail.Visible = true;
                    TxtPersonCreatMailPriv.Visible = true;
                    LblCreatAHV.Visible = true;
                    TxtPersonCreatAhv.Visible = true;

                    LblCreatCusType.Visible = false;
                    CmbPersonCreatCustomerType.Visible = false;

                    LblCreatComp.Visible = true;

                    LblCreatCompName.Visible = true;
                    TxtPersonCreatCompName.Visible = true;
                    LblCreatCompAddr.Visible = true;
                    TxtPersonCreatCompAddr.Visible = true;
                    LblCreatCompPlace.Visible = true;
                    TxtPersonCreatCompRes.Visible = true;
                    LblCreatCompPlz.Visible = true;
                    TxtPersonCreatCompZipCode.Visible = true;
                    LblCreatCompTel.Visible = true;
                    TxtPersonCreatCompTel.Visible = true;
                    LblCreatCompFax.Visible = true;
                    TxtPersonCreatCompFax.Visible = true;
                    LblCreatDep.Visible = true;
                    TxtPersonCreatCompDepart.Visible = true;
                    LblCreatEmployLvl.Visible = true;
                    NumPersonCreatCompProcent.Visible = true;
                    LblCreatRole.Visible = true;
                    TxtPersonCreatCompRole.Visible = true;
                    LblCreatMgmtLvl.Visible = true;
                    TxtPersonCreatCompEmplLvl.Visible = true;
                    LblCreatEntryDate.Visible = true;
                    TxtPersonCreatCompEntryDate.Visible = true;
                    LblCreatExitDate.Visible = true;
                    TxtPersonCreatCompExitDate.Visible = true;

                    LblCreatAppYear.Visible = false;
                    NumPersonCreatYearsApprenticeship.Visible = false;
                    LblCreatAppCurrentYear.Visible = false;
                    NumPersonCreaCurrentYear.Visible = false;
                    break;

                case ("Kunde"):
                    LblCreatPerson.Visible = true;

                    LblCreatSalut.Visible = true;
                    CmbPersonCreatSalut.Visible = true;
                    LblCreatTitel.Visible = true;
                    TxtPersonCreatTitle.Visible = true;
                    LblCreatFirstn.Visible = true;
                    TxtPersonCreatFirstn.Visible = true;
                    LblCreatLastn.Visible = true;
                    TxtPersonCreatLastn.Visible = true;
                    LblCreatBirth.Visible = true;
                    TxtPersonCreatBirth.Visible = true;
                    LblCreatTelPriv.Visible = true;
                    TxtPersonCreatMailPriv.Visible = true;
                    LblCreatTelMobile.Visible = true;
                    TxtPersonCreatMobile.Visible = true;
                    LblCreatNation.Visible = true;
                    TxtPersonCreatNation.Visible = true;
                    LblCreatGender.Visible = true;
                    CmbPersonCreatGend.Visible = true;
                    LblCreatAddr.Visible = true;
                    TxtPersonCreatAddr.Visible = true;
                    LblCreatPlace.Visible = true;
                    TxtPersonCreatResid.Visible = true;
                    LblCreatPlz.Visible = true;
                    TxtPersonCreatZipcode.Visible = true;
                    LblCreatMail.Visible = true;
                    TxtPersonCreatMailPriv.Visible = true;
                    LblCreatAHV.Visible = true;
                    TxtPersonCreatAhv.Visible = true;

                    LblCreatCusType.Visible = true;
                    CmbPersonCreatCustomerType.Visible = true;

                    LblCreatComp.Visible = false;

                    LblCreatCompName.Visible = false;
                    TxtPersonCreatCompName.Visible = false;
                    LblCreatCompAddr.Visible = false;
                    TxtPersonCreatCompAddr.Visible = false;
                    LblCreatCompPlace.Visible = false;
                    TxtPersonCreatCompRes.Visible = false;
                    LblCreatCompPlz.Visible = false;
                    TxtPersonCreatCompZipCode.Visible = false;
                    LblCreatCompTel.Visible = false;
                    TxtPersonCreatCompTel.Visible = false;
                    LblCreatCompFax.Visible = false;
                    TxtPersonCreatCompFax.Visible = false;
                    LblCreatDep.Visible = false;
                    TxtPersonCreatCompDepart.Visible = false;
                    LblCreatEmployLvl.Visible = false;
                    NumPersonCreatCompProcent.Visible = false;
                    LblCreatRole.Visible = false;
                    TxtPersonCreatCompRole.Visible = false;
                    LblCreatMgmtLvl.Visible = false;
                    TxtPersonCreatCompEmplLvl.Visible = false;
                    LblCreatEntryDate.Visible = false;
                    TxtPersonCreatCompEntryDate.Visible = false;
                    LblCreatExitDate.Visible = false;
                    TxtPersonCreatCompExitDate.Visible = false;

                    LblCreatAppYear.Visible = false;
                    NumPersonCreatYearsApprenticeship.Visible = false;
                    LblCreatAppCurrentYear.Visible = false;
                    NumPersonCreaCurrentYear.Visible = false;
                    break;

                case ("Lernender"):
                    LblCreatPerson.Visible = true;

                    LblCreatSalut.Visible = true;
                    CmbPersonCreatSalut.Visible = true;
                    LblCreatTitel.Visible = true;
                    TxtPersonCreatTitle.Visible = true;
                    LblCreatFirstn.Visible = true;
                    TxtPersonCreatFirstn.Visible = true;
                    LblCreatLastn.Visible = true;
                    TxtPersonCreatLastn.Visible = true;
                    LblCreatBirth.Visible = true;
                    TxtPersonCreatBirth.Visible = true;
                    LblCreatTelPriv.Visible = true;
                    TxtPersonCreatMailPriv.Visible = true;
                    LblCreatTelMobile.Visible = true;
                    TxtPersonCreatMobile.Visible = true;
                    LblCreatNation.Visible = true;
                    TxtPersonCreatNation.Visible = true;
                    LblCreatGender.Visible = true;
                    CmbPersonCreatGend.Visible = true;
                    LblCreatAddr.Visible = true;
                    TxtPersonCreatAddr.Visible = true;
                    LblCreatPlace.Visible = true;
                    TxtPersonCreatResid.Visible = true;
                    LblCreatPlz.Visible = true;
                    TxtPersonCreatZipcode.Visible = true;
                    LblCreatMail.Visible = true;
                    TxtPersonCreatMailPriv.Visible = true;
                    LblCreatAHV.Visible = true;
                    TxtPersonCreatAhv.Visible = true;

                    LblCreatCusType.Visible = false;
                    CmbPersonCreatCustomerType.Visible = false;

                    LblCreatComp.Visible = true;

                    LblCreatCompName.Visible = true;
                    TxtPersonCreatCompName.Visible = true;
                    LblCreatCompAddr.Visible = true;
                    TxtPersonCreatCompAddr.Visible = true;
                    LblCreatCompPlace.Visible = true;
                    TxtPersonCreatCompRes.Visible = true;
                    LblCreatCompPlz.Visible = true;
                    TxtPersonCreatCompZipCode.Visible = true;
                    LblCreatCompTel.Visible = true;
                    TxtPersonCreatCompTel.Visible = true;
                    LblCreatCompFax.Visible = true;
                    TxtPersonCreatCompFax.Visible = true;
                    LblCreatDep.Visible = true;
                    TxtPersonCreatCompDepart.Visible = true;
                    LblCreatEmployLvl.Visible = true;
                    NumPersonCreatCompProcent.Visible = true;
                    LblCreatRole.Visible = true;
                    TxtPersonCreatCompRole.Visible = true;
                    LblCreatMgmtLvl.Visible = true;
                    TxtPersonCreatCompEmplLvl.Visible = true;
                    LblCreatEntryDate.Visible = true;
                    TxtPersonCreatCompEntryDate.Visible = true;
                    LblCreatExitDate.Visible = true;
                    TxtPersonCreatCompExitDate.Visible = true;

                    LblCreatAppYear.Visible = true;
                    NumPersonCreatYearsApprenticeship.Visible = true;
                    LblCreatAppCurrentYear.Visible = true;
                    NumPersonCreaCurrentYear.Visible = true;
                    break;
            }
        }

        private void CreatePerson_Load(object sender, EventArgs e)
        {

        }
    }
}
