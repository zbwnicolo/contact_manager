using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace contact_manager
{
    public partial class CreateEmployee : Form
    {
        public CreateEmployee( )
        {
            InitializeComponent();

        }

        private void CmdEmployeeCreatEmployeeSave_Click(object sender, EventArgs e)
        {
            Person.addPerson(this);
            Person.people.Clear();
            Person.TxtToObject();
            Dashboard.tbl.Clear();
            Dashboard.LoadPeople();
            
        }
    }
}
