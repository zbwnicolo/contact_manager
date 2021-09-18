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
        public CommunicationLog(EditPerson ep)
        {
            InitializeComponent();

            string id = ep.TxtInstanceID.Text;
            var item = Person.employee.FirstOrDefault(o => Convert.ToString(o.InstanceID) == id);
            TxtInstanceID.Text = id;

            
            
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

                string[] row = new string[] { TxtInstanceID.Text, DtpLog.Text, TxtLogInput.Text };
                DgvLogOutput.Rows.Add(row);

            using (TextWriter tw = new StreamWriter("ComLog.txt", append: true))
            {
                tw.WriteLine(TxtInstanceID.Text + ";" + DtpLog.Text + ";" + TxtLogInput.Text);
                tw.Close();
            }
            TxtLogInput.Clear();
            DgvLogOutput.Rows.Clear();
            DgvLogOutput.Refresh();
            ComLog.ReadFromTxt(this);
        }

        private void CommunicationLog_Load(object sender, EventArgs e)
        {
            ComLog.ReadFromTxt(this);
        }
    }
}
