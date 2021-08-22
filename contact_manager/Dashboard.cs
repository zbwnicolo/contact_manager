using System;
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
                MessageBox.Show("Es darf kein Mitarbeiter ausgewählt sein!");
            }
            else
            {
                CreateEmployee Form = new CreateEmployee();
                Form.Show();
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //DataSet Employee = new DataSet();
            //Employee.ReadXml(@"Test.xml");

            //DataSet Customer = new DataSet();
            //Customer.ReadXml(@"C:\Users\joels\Documents\GitHub\contact_manager\contact_manager\Customer.xml");

            //DataGridEmployee.DataSource = Employee.Tables[0];
            //DataGridCustomer.DataSource = Customer.Tables[0];

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
