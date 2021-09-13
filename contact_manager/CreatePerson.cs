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
                    break;

                case ("Kunde"):
                    Customer c = new Customer(this);
                    c.addPerson(this);
                    break;

                case ("Lernender"):
                    Apprentice a = new Apprentice(this);
                    a.addPerson(this);
                    break;
            }

            Person.people.Clear();
            Person.TxtToObject();
            Dashboard.tbl.Clear();
            Dashboard.LoadPeople();

            this.Close();
        }

        private void CmdCreatPersonAbort_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
