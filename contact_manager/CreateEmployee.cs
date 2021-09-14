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
            CmbDropEmployeeCreatSalut.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbEmployeeCreatGend.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CmdEmployeeCreatEmployeeSave_Click(object sender, EventArgs e)
        {
            //Person.addPerson(this);
            Person.people.Clear();
            //Person.TxtToObject();
            Dashboard.tbl.Clear();
            Dashboard.LoadPeople();

            TxtEmployeeCreatTitle.Clear();
            TxtEmployeeCreatFirstn.Clear();
            TxtEmployeeCreatLastn.Clear();
            TxtEmployeeCreatBirth.Clear();
            TxtEmployeeCreatTel.Clear();
            TxtEmployeeCreatMobile.Clear();
            TxtEmployeeCreatNation.Clear();
            TxtEmployeeCreatAddr.Clear();
            TxtEmployeeCreatResid.Clear();
            TxtEmployeeCreatZipcode.Clear();
            TxtEmployeeCreatMailPriv.Clear();
            TxtEmployeeCreatAhv.Clear();
        }

        private void CreateEmployee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Person.addPerson(this);
                Person.people.Clear();
                //Person.TxtToObject();
                Dashboard.tbl.Clear();
                Dashboard.LoadPeople();

                TxtEmployeeCreatTitle.Clear();
                TxtEmployeeCreatFirstn.Clear();
                TxtEmployeeCreatLastn.Clear();
                TxtEmployeeCreatBirth.Clear();
                TxtEmployeeCreatTel.Clear();
                TxtEmployeeCreatMobile.Clear();
                TxtEmployeeCreatNation.Clear();
                TxtEmployeeCreatAddr.Clear();
                TxtEmployeeCreatResid.Clear();
                TxtEmployeeCreatZipcode.Clear();
                TxtEmployeeCreatMailPriv.Clear();
                TxtEmployeeCreatAhv.Clear();
            }
            
        }

        private void CmdEmployeeCreatEmployeeAbort_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
