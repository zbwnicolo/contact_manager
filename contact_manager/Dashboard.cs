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
        public Dashboard()
        {
            InitializeComponent();
            Person.LoadFromTxt();

        }
        private void CmdCreateEmployee_Click(object sender, EventArgs e)
        {
            if (DataGridEmployee.Rows != null && DataGridEmployee.Rows.Count > 0)
            {
                //MessageBox.Show("Es darf kein Mitarbeiter ausgewählt sein!");
                CreateEmployee Form = new CreateEmployee();
                Form.Show();
            }
            else
            {
                CreateEmployee Form = new CreateEmployee();
                Form.Show();
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //add columns to datatable
            Person.tbl.Columns.Add("Anrede", typeof(string));
            Person.tbl.Columns.Add("Titel", typeof(string));
            Person.tbl.Columns.Add("Vorname", typeof(string));
            Person.tbl.Columns.Add("Nachname", typeof(string));

            DataGridEmployee.DataSource = Person.tbl;
            Person.LoadPeople();
            DataGridEmployee.ClearSelection();
        }

        private void CmdInfoEmployee_Click(object sender, EventArgs e)
        {
            //if (DataGridEmployee.Rows != null && DataGridEmployee.Rows.Count != 0)
            //{
            EditEmployee Form = new EditEmployee();
            Form.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Es muss mindestens 1 Mitarbeiter ausgewählt werden!");
            //}
        }

        private void DataGridEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
