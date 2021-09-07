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
    public partial class Dashboard : Form
    {
        public static DataTable tbl = new DataTable();
        public Dashboard()
        {
            InitializeComponent();
            Person.TxtToObject();
        }

        private void CmdCreateEmployee_Click(object sender, EventArgs e)
        {
            CreateEmployee Form = new CreateEmployee();
            Form.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //add columns to datatable
            tbl.Columns.Add("ID", typeof(string));
            tbl.Columns.Add("Anrede", typeof(string));
            tbl.Columns.Add("Titel", typeof(string));
            tbl.Columns.Add("Vorname", typeof(string));
            tbl.Columns.Add("Nachname", typeof(string));
            tbl.Columns.Add("Adresse", typeof(string));
            tbl.Columns.Add("Postleitzahl", typeof(string));
            tbl.Columns.Add("Wohnort", typeof(string));
            tbl.Columns.Add("Telefonnummer", typeof(string));

            DataGridEmployee.DataSource = tbl;
            LoadPeople();
            DataGridEmployee.ClearSelection();
        }

        private void CmdInfoEmployee_Click(object sender, EventArgs e)
        {
            if (DataGridEmployee.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                EditEmployee ep = new EditEmployee();
                ep.Show();

                string salut = DataGridEmployee.SelectedRows[0].Cells[0].Value + string.Empty;
                string title = DataGridEmployee.SelectedRows[0].Cells[1].Value + string.Empty;
                string firstn = DataGridEmployee.SelectedRows[0].Cells[2].Value + string.Empty;
                string lastn = DataGridEmployee.SelectedRows[0].Cells[3].Value + string.Empty;


                ep.CmbDropEmployeeMgmtSalut.Text = salut;
                ep.TxtEmployeeMgmtTitle.Text = title;
                ep.TxtEmployeeMgmtFirstn.Text = firstn;
                ep.TxtEmployeeMgmtLastn.Text = lastn;
            }
            else
            {
                MessageBox.Show("Es muss mindestens eine Person ausgewählt werden!");
            }

            
        }

        public static DataTable LoadPeople()
        {
            foreach (Person person in Person.people)
            {
                tbl.Rows.Add(new object[] { person.InstanceID, person.salutation, person.title, person.firstName, person.lastName });
            }

            return tbl;
        }
    }
}
