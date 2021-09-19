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
            Customer c = new Customer();
            Employee e = new Employee();
            Apprentice a = new Apprentice();
            c.TxtToObject();
            e.TxtToObject();
            a.TxtToObject();
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
            /*foreach (DataGridViewRow row in DataGridEmployee.Rows)
            {
                if (row.Cells[10].Value.ToString() == "False")
                {
                    row.DefaultCellStyle.BackColor = Color.Gray;
                }
            }*/
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
            foreach (Employee employee in Employee.employee)
            {
                tbl.Rows.Add(new object[] {
                    employee.InstanceID,
                    employee.type,
                    employee.salutation,
                    employee.title,
                    employee.firstName,
                    employee.lastName,
                    employee.street,
                    employee.postcode,
                    employee.place,
                    employee.phoneNumberPriv,
                    employee.status
                });
            }

            foreach (Customer customer in Customer.customer)
            {
                tbl.Rows.Add(new object[] {
                    customer.InstanceID,
                    customer.type,
                    customer.salutation,
                    customer.title,
                    customer.firstName,
                    customer.lastName,
                    customer.street,
                    customer.postcode,
                    customer.place,
                    customer.phoneNumberPriv,
                    customer.status
                });
            }

            foreach (Apprentice apprentice in Apprentice.apprentice)
            {
                tbl.Rows.Add(new object[] {
                    apprentice.InstanceID,
                    apprentice.type,
                    apprentice.salutation,
                    apprentice.title,
                    apprentice.firstName,
                    apprentice.lastName,
                    apprentice.street,
                    apprentice.postcode,
                    apprentice.place,
                    apprentice.phoneNumberPriv,
                    apprentice.status
                });
            }

            //If status is inactive change row color to grey
            foreach (DataGridViewRow row in tbl.Rows)
            {
                if (row.Cells[10].Value.ToString() == "False")
                {
                    row.DefaultCellStyle.BackColor = Color.Gray;
                }
            }

            return tbl;
        }

        private void CmdDeleteEmployee_Click(object sender, EventArgs e)
        {
            string id = DataGridEmployee.SelectedRows[0].Cells[0].Value + string.Empty;
            string type = DataGridEmployee.SelectedRows[0].Cells[1].Value + string.Empty;

            if (type == "Mitarbeiter")
            {
                Employee employee = new Employee();
                employee.deletePerson(this);
            }
            else if (type == "Kunde")
            {
                Customer customer = new Customer();
                customer.deletePerson(this);
            }
            else
            {
                Apprentice apprentice = new Apprentice();
                apprentice.deletePerson(this);

            }
            //Person.deletePerson(this);
            Dashboard.tbl.Clear();
            Dashboard.LoadPeople();
        }

        private void CmdSaveExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void TxtSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            (DataGridEmployee.DataSource as DataTable).DefaultView.RowFilter = string.Format("Vorname LIKE '%{0}%' OR Nachname LIKE '%{0}%'", TxtSearchEmployee.Text);
        }

        private void CmbFilterEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CmbFilterEmployee.Text)
            {
                case ("Alle"):
                    (DataGridEmployee.DataSource as DataTable).DefaultView.RowFilter = string.Format("Typ LIKE '%'", CmbFilterEmployee.Text);
                    break;

                case ("Mitarbeiter"):
                    (DataGridEmployee.DataSource as DataTable).DefaultView.RowFilter = string.Format("Typ LIKE 'Mitarbeiter'", CmbFilterEmployee.Text);
                    break;

                case ("Kunde"):
                    (DataGridEmployee.DataSource as DataTable).DefaultView.RowFilter = string.Format("Typ LIKE 'Kunde'", CmbFilterEmployee.Text);
                    break;

                case ("Lernender"):
                    (DataGridEmployee.DataSource as DataTable).DefaultView.RowFilter = string.Format("Typ LIKE 'Lernender'", CmbFilterEmployee.Text);
                    break;
            }
        }
    }
}
