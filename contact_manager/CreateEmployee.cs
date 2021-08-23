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
        public CreateEmployee()
        {
            InitializeComponent();

        }

        private void CmdEmployeeCreatEmployeeSave_Click(object sender, EventArgs e)
        {
            /*Person p = new Person();
            p.FirstName = TxtEmployeeCreatFirstn.Text;
            p.LastName = TxtEmployeeCreatLastn.Text;
            LstOutput.Items.Add(p.ToString());*/
            Person.addPerson(this);
            Person.Write();
            Person.Read();
            Person.Display(this);
            Person.ClearForm(this);
        }

        private void CreateEmployee_Load(object sender, EventArgs e)
        {
            Person.Read();
            Person.Display(this);
        }
    }
}
