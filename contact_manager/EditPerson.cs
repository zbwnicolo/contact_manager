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
            var item = Person.people.FirstOrDefault(o => Convert.ToString(o.InstanceID) == id);
            TxtInstanceID.Text = id;
            Console.WriteLine(item);

            CmbPersonMgmtType.Text = item.type;
            CmbDropPersonMgmtSalut.Text = item.salutation;
            TxtPersonMgmtTitle.Text = item.title;
            TxtPersonMgmtFirstn.Text = item.firstName;
            TxtPersonMgmtLastn.Text = item.lastName;
            TxtPersonMgmtBirth.Text = Convert.ToString(item.birthday);
            TxtPersonMgmtTel.Text = item.phoneNumberPriv;
            TxtPersonMgmtMobile.Text = item.phoneNumberMobile;
            TxtPersonMgmtNation.Text = item.nationality;
            CmbPersonMgmtGend.Text = item.gender;
            TxtPersonMgmtAddr.Text = item.street;
            TxtPersonMgmtResid.Text = item.place;
            TxtPersonMgmtZipcode.Text = item.postcode;
            TxtPersonMgmtMailPriv.Text = item.email;
            TxtPersonMgmtAhv.Text = item.ahvNumber;
        }

        private void CmdPersonMgmtSave_Click(object sender, EventArgs e)
        {
            Person.editPerson(this);
            Dashboard.tbl.Clear();
            Dashboard.LoadPeople();
            this.Close();
        }

        private void CmdPersonMgmtAbort_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditPerson_Load(object sender, EventArgs e)
        {

        }
    }
}
