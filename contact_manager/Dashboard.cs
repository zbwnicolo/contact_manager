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

            List<Person> people = new List<Person>();
            string line;

            // Read the file and display it line by line.
            System.IO.StreamReader file =
                new System.IO.StreamReader("Person.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split(',');
                people.Add(new Person
                {
                    FirstName = words[0],
                    LastName = words[1],
                    Salutation = words[2],
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
            // add columns to datatable
            //Person.tbl.Columns.Add("Id", typeof(string));
            //Person.tbl.Columns.Add("First Name", typeof(string));
            //Person.tbl.Columns.Add("Last Name", typeof(string));
            DataGridEmployee.DataSource = Person.tbl;
            Person.ConvertToDataTable("Person.Txt", 3);
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
