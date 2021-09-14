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
    public partial class CommunicationLog : Form
    {
        public CommunicationLog(Dashboard db)
        {
            InitializeComponent();

            string id = db.DataGridEmployee.SelectedRows[0].Cells[0].Value + string.Empty;
            var item = Person.people.FirstOrDefault(o => Convert.ToString(o.InstanceID) == id);
            TxtInstanceID.Text = id;
            Console.WriteLine(item);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CmdLogSend_Click(object sender, EventArgs e)
        {

        }

        private void CmdLogSend_Click_1(object sender, EventArgs e)
        {
            string datepicker = DtpLog.ToString();

            string path = "MyTest.txt";
            if (!File.Exists(path))
            {
                // Create a file to write to.

                {

                    //sw.WriteLine("Hello");
                    //sw.WriteLine("And");
                    //sw.WriteLine("Welcome");

                }
            }

            if (TxtLogInput.TextLength != 0)
            {

                string[] row = new string[] { "[" + DtpLog.Text + "]", TxtLogInput.Text };
                DgvLogOutput.Rows.Add(row);
                TxtLogInput.Clear();

            }
            else
            {
                MessageBox.Show("Das Input Feld dar nicht leer sein");
            }


            //new idea



        }
    }
}
