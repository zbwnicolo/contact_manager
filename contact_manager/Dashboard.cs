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
            


            /*using (StreamReader sr = new StreamReader("Person.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    while (sr.Peek() > 0)
                    {

                        string[] fields;
                        fields = sr.ReadLine().Split(',');
                        if (fields.Count() == 2)
                        {
                            dr = dt.NewRow();
                            dr["name"] = fields[0];
                            dr["vorname"] = fields[1];

                        }
                    }
                }
            }*/
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
