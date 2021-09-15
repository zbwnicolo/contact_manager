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
                    TxtPersonMgmtResid.Text = eitem.place;
                    TxtPersonMgmtCompZipCode.Text = eitem.postcode;
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
                    TxtPersonMgmtCustomerType.Text = citem.customerType;
                }
            }
            else
            {
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
                    TxtPersonMgmtResid.Text = aitem.place;
                    TxtPersonMgmtCompZipCode.Text = aitem.postcode;
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
