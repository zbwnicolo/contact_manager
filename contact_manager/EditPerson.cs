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
    public partial class EditPerson : Form
    {
        public EditPerson(Dashboard db)
        {
            InitializeComponent();

            string id = db.DataGridEmployee.SelectedRows[0].Cells[0].Value + string.Empty;
            string type = db.DataGridEmployee.SelectedRows[0].Cells[1].Value + string.Empty;

            if (type == "Mitarbeiter")
            {
                LblMgmtPerson.Visible = true;

                LblMgmtSalut.Visible = true;
                CmbDropPersonMgmtSalut.Visible = true;
                LblMgmtTitel.Visible = true;
                TxtPersonMgmtTitle.Visible = true;
                LblMgmtFirstn.Visible = true;
                TxtPersonMgmtFirstn.Visible = true;
                LblMgmtLastn.Visible = true;
                TxtPersonMgmtLastn.Visible = true;
                LblMgmtBirth.Visible = true;
                TxtPersonMgmtBirth.Visible = true;
                LblMgmtTelPriv.Visible = true;
                TxtPersonMgmtMailPriv.Visible = true;
                LblMgmtTelMobile.Visible = true;
                TxtPersonMgmtMobile.Visible = true;
                LblMgmtNation.Visible = true;
                TxtPersonMgmtNation.Visible = true;
                LblMgmtGender.Visible = true;
                CmbPersonMgmtGend.Visible = true;
                LblMgmtAddr.Visible = true;
                TxtPersonMgmtAddr.Visible = true;
                LblMgmtPlace.Visible = true;
                TxtPersonMgmtResid.Visible = true;
                LblMgmtPlz.Visible = true;
                TxtPersonMgmtZipcode.Visible = true;
                LblMgmtMail.Visible = true;
                TxtPersonMgmtMailPriv.Visible = true;
                LblMgmtAHV.Visible = true;
                TxtPersonMgmtAhv.Visible = true;

                LblMgmtCusType.Visible = false;
                CmbPersonMgmtCustomerType.Visible = false;

                LblMgmtComp.Visible = true;

                LblMgmtCompName.Visible = true;
                TxtPersonMgmtCompName.Visible = true;
                LblMgmtCompAddr.Visible = true;
                TxtPersonMgmtCompAddr.Visible = true;
                LblMgmtCompPlace.Visible = true;
                TxtPersonMgmtCompRes.Visible = true;
                LblMgmtCompPlz.Visible = true;
                TxtPersonMgmtCompZipCode.Visible = true;
                LblMgmtCompTel.Visible = true;
                TxtPersonMgmtCompTel.Visible = true;
                LblMgmtCompFax.Visible = true;
                TxtPersonMgmtCompFax.Visible = true;
                LblMgmtDep.Visible = true;
                TxtPersonMgmtCompDepart.Visible = true;
                LblMgmtEmployLvl.Visible = true;
                NumPersonMgmtCompProcent.Visible = true;
                LblMgmtRole.Visible = true;
                TxtPersonMgmtCompRole.Visible = true;
                LblMgmtMgmtLvl.Visible = true;
                TxtPersonMgmtCompEmplLvl.Visible = true;
                LblMgmtEntryDate.Visible = true;
                DtpPersonMgmtCompEntryDate.Visible = true;
                LblMgmtExitDate.Visible = true;
                DtpPersonMgmtCompExitDate.Visible = true;

                LblMgmtAppYear.Visible = false;
                NumPersonMgmtYearsApprenticeship.Visible = false;
                LblMgmtAppCurrentYear.Visible = false;
                NumPersonMgmtCurrentYear.Visible = false;

                foreach (Employee employee in Employee.employee)
                {
                    var eitem = Employee.employee.FirstOrDefault(o => Convert.ToString(o.InstanceID) == id);

                    TxtInstanceID.Text = id;
                    CmbDropPersonMgmtSalut.Text = eitem.salutation;
                    TxtPersonMgmtTitle.Text = eitem.title;
                    TxtPersonMgmtFirstn.Text = eitem.firstName;
                    TxtPersonMgmtLastn.Text = eitem.lastName;
                    TxtPersonMgmtBirth.Text = Convert.ToString(eitem.birthday);
                    TxtPersonMgmtTel.Text = eitem.phoneNumberPriv;
                    TxtPersonMgmtMobile.Text = eitem.phoneNumberMobile;
                    TxtPersonMgmtNation.Text = eitem.nationality;
                    CmbPersonMgmtGend.Text = eitem.gender;
                    TxtPersonMgmtAddr.Text = eitem.street;
                    TxtPersonMgmtResid.Text = eitem.place;
                    TxtPersonMgmtZipcode.Text = eitem.postcode;
                    TxtPersonMgmtMailPriv.Text = eitem.email;
                    TxtPersonMgmtAhv.Text = eitem.ahvNumber;
                    CmbPersonMgmtType.Text = eitem.type;
                    TxtPersonMgmtCompName.Text = eitem.companyName;
                    TxtPersonMgmtCompAddr.Text = eitem.companyStreet;
                    TxtPersonMgmtCompRes.Text = eitem.companyPlace;
                    TxtPersonMgmtCompZipCode.Text = eitem.companyPostcode;
                    TxtPersonMgmtCompTel.Text = eitem.phoneNumberWork;
                    TxtPersonMgmtCompFax.Text = eitem.faxNumer;
                    TxtPersonMgmtCompDepart.Text = eitem.department;
                    NumPersonMgmtCompProcent.Value = eitem.employmentLevel;
                    TxtPersonMgmtCompRole.Text = eitem.role;
                    TxtPersonMgmtCompEmplLvl.Text = eitem.managementLevel;
                    DtpPersonMgmtCompEntryDate.Text = Convert.ToString(eitem.entryDate);
                    DtpPersonMgmtCompExitDate.Text = Convert.ToString(eitem.exitDate);
                }
            }
            else if(type == "Kunde")
            {
                LblMgmtPerson.Visible = true;

                LblMgmtSalut.Visible = true;
                CmbDropPersonMgmtSalut.Visible = true;
                LblMgmtTitel.Visible = true;
                TxtPersonMgmtTitle.Visible = true;
                LblMgmtFirstn.Visible = true;
                TxtPersonMgmtFirstn.Visible = true;
                LblMgmtLastn.Visible = true;
                TxtPersonMgmtLastn.Visible = true;
                LblMgmtBirth.Visible = true;
                TxtPersonMgmtBirth.Visible = true;
                LblMgmtTelPriv.Visible = true;
                TxtPersonMgmtMailPriv.Visible = true;
                LblMgmtTelMobile.Visible = true;
                TxtPersonMgmtMobile.Visible = true;
                LblMgmtNation.Visible = true;
                TxtPersonMgmtNation.Visible = true;
                LblMgmtGender.Visible = true;
                CmbPersonMgmtGend.Visible = true;
                LblMgmtAddr.Visible = true;
                TxtPersonMgmtAddr.Visible = true;
                LblMgmtPlace.Visible = true;
                TxtPersonMgmtResid.Visible = true;
                LblMgmtPlz.Visible = true;
                TxtPersonMgmtZipcode.Visible = true;
                LblMgmtMail.Visible = true;
                TxtPersonMgmtMailPriv.Visible = true;
                LblMgmtAHV.Visible = true;
                TxtPersonMgmtAhv.Visible = true;

                LblMgmtCusType.Visible = true;
                CmbPersonMgmtCustomerType.Visible = true;

                LblMgmtComp.Visible = false;

                LblMgmtCompName.Visible = false;
                TxtPersonMgmtCompName.Visible = false;
                LblMgmtCompAddr.Visible = false;
                TxtPersonMgmtCompAddr.Visible = false;
                LblMgmtCompPlace.Visible = false;
                TxtPersonMgmtCompRes.Visible = false;
                LblMgmtCompPlz.Visible = false;
                TxtPersonMgmtCompZipCode.Visible = false;
                LblMgmtCompTel.Visible = false;
                TxtPersonMgmtCompTel.Visible = false;
                LblMgmtCompFax.Visible = false;
                TxtPersonMgmtCompFax.Visible = false;
                LblMgmtDep.Visible = false;
                TxtPersonMgmtCompDepart.Visible = false;
                LblMgmtEmployLvl.Visible = false;
                NumPersonMgmtCompProcent.Visible = false;
                LblMgmtRole.Visible = false;
                TxtPersonMgmtCompRole.Visible = false;
                LblMgmtMgmtLvl.Visible = false;
                TxtPersonMgmtCompEmplLvl.Visible = false;
                LblMgmtEntryDate.Visible = false;
                DtpPersonMgmtCompEntryDate.Visible = false;
                LblMgmtExitDate.Visible = false;
                DtpPersonMgmtCompExitDate.Visible = false;

                LblMgmtAppYear.Visible = false;
                NumPersonMgmtYearsApprenticeship.Visible = false;
                LblMgmtAppCurrentYear.Visible = false;
                NumPersonMgmtCurrentYear.Visible = false;

                foreach (Customer customer in Customer.customer)
                {
                    var citem = Customer.customer.FirstOrDefault(o => Convert.ToString(o.InstanceID) == id);
                    TxtInstanceID.Text = id;
                    CmbPersonMgmtType.Text = citem.type;
                    CmbDropPersonMgmtSalut.Text = citem.salutation;
                    TxtPersonMgmtTitle.Text = citem.title;
                    TxtPersonMgmtFirstn.Text = citem.firstName;
                    TxtPersonMgmtLastn.Text = citem.lastName;
                    TxtPersonMgmtBirth.Text = Convert.ToString(citem.birthday);
                    TxtPersonMgmtTel.Text = citem.phoneNumberPriv;
                    TxtPersonMgmtMobile.Text = citem.phoneNumberMobile;
                    TxtPersonMgmtNation.Text = citem.nationality;
                    CmbPersonMgmtGend.Text = citem.gender;
                    TxtPersonMgmtAddr.Text = citem.street;
                    TxtPersonMgmtResid.Text = citem.place;
                    TxtPersonMgmtZipcode.Text = citem.postcode;
                    TxtPersonMgmtMailPriv.Text = citem.email;
                    TxtPersonMgmtAhv.Text = citem.ahvNumber;
                    CmbPersonMgmtCustomerType.Text = citem.customerType;
                }
            }
            else
            {
                LblMgmtPerson.Visible = true;

                LblMgmtSalut.Visible = true;
                CmbDropPersonMgmtSalut.Visible = true;
                LblMgmtTitel.Visible = true;
                TxtPersonMgmtTitle.Visible = true;
                LblMgmtFirstn.Visible = true;
                TxtPersonMgmtFirstn.Visible = true;
                LblMgmtLastn.Visible = true;
                TxtPersonMgmtLastn.Visible = true;
                LblMgmtBirth.Visible = true;
                TxtPersonMgmtBirth.Visible = true;
                LblMgmtTelPriv.Visible = true;
                TxtPersonMgmtMailPriv.Visible = true;
                LblMgmtTelMobile.Visible = true;
                TxtPersonMgmtMobile.Visible = true;
                LblMgmtNation.Visible = true;
                TxtPersonMgmtNation.Visible = true;
                LblMgmtGender.Visible = true;
                CmbPersonMgmtGend.Visible = true;
                LblMgmtAddr.Visible = true;
                TxtPersonMgmtAddr.Visible = true;
                LblMgmtPlace.Visible = true;
                TxtPersonMgmtResid.Visible = true;
                LblMgmtPlz.Visible = true;
                TxtPersonMgmtZipcode.Visible = true;
                LblMgmtMail.Visible = true;
                TxtPersonMgmtMailPriv.Visible = true;
                LblMgmtAHV.Visible = true;
                TxtPersonMgmtAhv.Visible = true;

                LblMgmtCusType.Visible = false;
                CmbPersonMgmtCustomerType.Visible = false;

                LblMgmtComp.Visible = true;

                LblMgmtCompName.Visible = true;
                TxtPersonMgmtCompName.Visible = true;
                LblMgmtCompAddr.Visible = true;
                TxtPersonMgmtCompAddr.Visible = true;
                LblMgmtCompPlace.Visible = true;
                TxtPersonMgmtCompRes.Visible = true;
                LblMgmtCompPlz.Visible = true;
                TxtPersonMgmtCompZipCode.Visible = true;
                LblMgmtCompTel.Visible = true;
                TxtPersonMgmtCompTel.Visible = true;
                LblMgmtCompFax.Visible = true;
                TxtPersonMgmtCompFax.Visible = true;
                LblMgmtDep.Visible = true;
                TxtPersonMgmtCompDepart.Visible = true;
                LblMgmtEmployLvl.Visible = true;
                NumPersonMgmtCompProcent.Visible = true;
                LblMgmtRole.Visible = true;
                TxtPersonMgmtCompRole.Visible = true;
                LblMgmtMgmtLvl.Visible = true;
                TxtPersonMgmtCompEmplLvl.Visible = true;
                LblMgmtEntryDate.Visible = true;
                DtpPersonMgmtCompEntryDate.Visible = true;
                LblMgmtExitDate.Visible = true;
                DtpPersonMgmtCompExitDate.Visible = true;

                LblMgmtAppYear.Visible = true;
                NumPersonMgmtYearsApprenticeship.Visible = true;
                LblMgmtAppCurrentYear.Visible = true;
                NumPersonMgmtCurrentYear.Visible = true;

                foreach (Apprentice apprentice in Apprentice.apprentice)
                {
                    var aitem = Apprentice.apprentice.FirstOrDefault(o => Convert.ToString(o.InstanceID) == id);
                    TxtInstanceID.Text = id;
                    CmbPersonMgmtType.Text = aitem.type;
                    CmbDropPersonMgmtSalut.Text = aitem.salutation;
                    TxtPersonMgmtTitle.Text = aitem.title;
                    TxtPersonMgmtFirstn.Text = aitem.firstName;
                    TxtPersonMgmtLastn.Text = aitem.lastName;
                    TxtPersonMgmtBirth.Text = Convert.ToString(aitem.birthday);
                    TxtPersonMgmtTel.Text = aitem.phoneNumberPriv;
                    TxtPersonMgmtMobile.Text = aitem.phoneNumberMobile;
                    TxtPersonMgmtNation.Text = aitem.nationality;
                    CmbPersonMgmtGend.Text = aitem.gender;
                    TxtPersonMgmtAddr.Text = aitem.street;
                    TxtPersonMgmtResid.Text = aitem.place;
                    TxtPersonMgmtZipcode.Text = aitem.postcode;
                    TxtPersonMgmtMailPriv.Text = aitem.email;
                    TxtPersonMgmtAhv.Text = aitem.ahvNumber;
                    TxtPersonMgmtCompName.Text = aitem.companyName;
                    TxtPersonMgmtCompAddr.Text = aitem.companyStreet;
                    TxtPersonMgmtCompRes.Text = aitem.companyPlace;
                    TxtPersonMgmtCompZipCode.Text = aitem.companyPostcode;
                    TxtPersonMgmtCompTel.Text = aitem.phoneNumberWork;
                    TxtPersonMgmtCompFax.Text = aitem.faxNumer;
                    TxtPersonMgmtCompDepart.Text = aitem.department;
                    NumPersonMgmtCompProcent.Value = aitem.employmentLevel;
                    TxtPersonMgmtCompRole.Text = aitem.role;
                    TxtPersonMgmtCompEmplLvl.Text = aitem.managementLevel;
                    DtpPersonMgmtCompEntryDate.Text = Convert.ToString(aitem.entryDate);
                    DtpPersonMgmtCompExitDate.Text = Convert.ToString (aitem.exitDate);
                    NumPersonMgmtCurrentYear.Value = Convert.ToInt32(aitem.currentYear);
                    NumPersonMgmtYearsApprenticeship.Value = Convert.ToInt32(aitem.yearsApprenticeship);

                }
            }
        }

        private void CmdPersonMgmtSave_Click(object sender, EventArgs e)
        {
            switch (this.CmbPersonMgmtType.Text)
            {
                case ("Mitarbeiter"):
                    Employee ep = new Employee();
                    ep.editPerson(this);
                    Dashboard.tbl.Clear();
                    Dashboard.LoadPeople();
                    this.Close();
                    break;

                case ("Kunde"):
                    Customer ec = new Customer();
                    ec.editPerson(this);
                    Dashboard.tbl.Clear();
                    Dashboard.LoadPeople();
                    this.Close();
                    break;

                case ("Lernender"):
                    Apprentice ea = new Apprentice();
                    ea.editPerson(this);
                    Dashboard.tbl.Clear();
                    Dashboard.LoadPeople();
                    this.Close();
                    break;
            }
            this.Close();
        }

        private void CmdPersonMgmtAbort_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
