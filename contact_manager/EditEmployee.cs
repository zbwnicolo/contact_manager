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
    public partial class EditEmployee : Form
    {
        public EditEmployee(Dashboard db)
        {
            InitializeComponent();

            string id = db.DataGridEmployee.SelectedRows[0].Cells[0].Value + string.Empty;
            var item = Person.people.FirstOrDefault(o => Convert.ToString(o.InstanceID) == id);
            TxtInstanceID.Text = id;
            Console.WriteLine(item);
            CmbDropEmployeeMgmtSalut.Text = item.salutation;
            TxtEmployeeMgmtTitle.Text = item.title;
            TxtEmployeeMgmtFirstn.Text = item.firstName;
            TxtEmployeeMgmtLastn.Text = item.lastName;
        }

        private void CmdEmployeeMgmtEmployeeSave_Click(object sender, EventArgs e)
        {
            Person.editPerson(this);
            Dashboard.tbl.Clear();
            Dashboard.LoadPeople();
            this.Close();
        }
    }
}
