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
        public DataTable tbl = new DataTable();
        public List<Person> people = new List<Person>();
        public Dashboard()
        {
            InitializeComponent();
            string line;

            // Read the file and display it line by line.
            System.IO.StreamReader file =
                new System.IO.StreamReader("Person.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split(',');
                people.Add(new Person
                {
                    Salutation = words[0],
                    Title = words[1],
                    FirstName = words[2],
                    LastName = words[3]
                });
            }

            file.Close();
            Console.WriteLine(people);
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
            tbl.Columns.Add("Anrede", typeof(string));
            tbl.Columns.Add("Titel", typeof(string));
            tbl.Columns.Add("Vorname", typeof(string));
            tbl.Columns.Add("Nachname", typeof(string));

            DataGridEmployee.DataSource = tbl;
            //Load Rows into DataGridView
            foreach (Person person in people)
            {
                tbl.Rows.Add(new object[] { person.salutation, person.title, person.firstName, person.lastName });
            }
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
    }
}
