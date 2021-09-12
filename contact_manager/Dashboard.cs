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

        //Dashboard constructor
        public Dashboard()
        {
            InitializeComponent();
            Person.TxtToObject();
        }

        private void CmdCreateEmployee_Click(object sender, EventArgs e)
        {
            CreatePerson Form = new CreatePerson();
            Form.Show();
        }

        //On Dashboard Load create Columns for table and load people from TXT file into table
        private void Dashboard_Load(object sender, EventArgs e)
        {
            tbl.Columns.Add("ID", typeof(string));
            tbl.Columns.Add("Typ", typeof(string));
            tbl.Columns.Add("Anrede", typeof(string));
            tbl.Columns.Add("Titel", typeof(string));
            tbl.Columns.Add("Vorname", typeof(string));
            tbl.Columns.Add("Nachname", typeof(string));
            tbl.Columns.Add("Adresse", typeof(string));
            tbl.Columns.Add("Postleitzahl", typeof(string));
            tbl.Columns.Add("Wohnort", typeof(string));
            tbl.Columns.Add("Telefonnummer", typeof(string));
            tbl.Columns.Add("Status", typeof(string));

            DataGridEmployee.DataSource = tbl;
            LoadPeople();
            DataGridEmployee.ClearSelection();

            //If status is inactive change row color to grey
            foreach (DataGridViewRow row in DataGridEmployee.Rows)
            {
                if (row.Cells[10].Value.ToString() == "False")
                {
                    row.DefaultCellStyle.BackColor = Color.Gray;
                }
            }
        }

        private void CmdInfoEmployee_Click(object sender, EventArgs e)
        {
            // make sure user select at least 1 row 
            if (DataGridEmployee.SelectedRows.Count > 0)
            {
                EditPerson ep = new EditPerson(this);
                ep.Show();
            }
            else
            {
                MessageBox.Show("Es muss mindestens eine Person ausgewählt werden!");
            }

            
        }
 
        //Load specified data of Persons into table
        public static DataTable LoadPeople()
        {
            foreach (Person person in Person.people)
            {
                tbl.Rows.Add(new object[] { 
                    person.InstanceID,
                    person.type,
                    person.salutation,
                    person.title,
                    person.firstName,
                    person.lastName,
                    person.street,
                    person.postcode,
                    person.place,
                    person.phoneNumberPriv,
                    person.status
                });
            }

            return tbl;
        }

        private void CmdDeleteEmployee_Click(object sender, EventArgs e)
        {
            Person.deletePerson(this);
            Dashboard.tbl.Clear();
            Dashboard.LoadPeople();
        }

        private void CmdSaveExit_Click(object sender, EventArgs e)
        {
            this.Close();        
        }

        private void TxtSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            (DataGridEmployee.DataSource as DataTable).DefaultView.RowFilter = string.Format("Vorname LIKE '%{0}%' OR Nachname LIKE '%{0}%'", TxtSearchEmployee.Text);
        }
    }
}
