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
            Person.LoadFromTxt();
        }

        private void CmdCreateEmployee_Click(object sender, EventArgs e)
        {
            CreateEmployee Form = new CreateEmployee();
            Form.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        { 
            //add columns to datatable
            tbl.Columns.Add("Anrede", typeof(string));
            tbl.Columns.Add("Titel", typeof(string));
            tbl.Columns.Add("Vorname", typeof(string));
            tbl.Columns.Add("Nachname", typeof(string));

            DataGridEmployee.DataSource = tbl;
            LoadPeople();
            DataGridEmployee.ClearSelection();
        }

        private void CmdInfoEmployee_Click(object sender, EventArgs e)
        {
            EditEmployee Form = new EditEmployee();
            Form.Show();
        }

        public static DataTable LoadPeople()
        {
            foreach (Person person in Person.people)
            {
                tbl.Rows.Add(new object[] { person.salutation, person.title, person.firstName, person.lastName });
            }

            return tbl;
        }
    }
}
