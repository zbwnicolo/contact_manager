﻿using System;
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
            CmbPersonCreatSalut.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbPersonCreatType.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbPersonCreatGend.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CmdCreatPersonSave_Click(object sender, EventArgs e)
        {
            Person.addPerson(this);
            Person.people.Clear();
            Person.TxtToObject();
            Dashboard.tbl.Clear();
            Dashboard.LoadPeople();

            TxtPersonCreatTitle.Clear();
            TxtPersonCreatFirstn.Clear();
            TxtPersonCreatLastn.Clear();
            TxtPersonCreatBirth.Clear();
            TxtPersonCreatTel.Clear();
            TxtPersonCreatMobile.Clear();
            TxtPersonCreatNation.Clear();
            TxtPersonCreatAddr.Clear();
            TxtPersonCreatResid.Clear();
            TxtPersonCreatZipcode.Clear();
            TxtPersonCreatMailPriv.Clear();
            TxtPersonCreatAhv.Clear();
        }

        private void CmdCreatPersonAbort_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
