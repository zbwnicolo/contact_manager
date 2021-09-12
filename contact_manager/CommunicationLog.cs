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
    public partial class CommunicationLog : Form
    {
        public CommunicationLog()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CmdLogSend_Click(object sender, EventArgs e)
        {
            string data = null;
            string datepicker = DtpLog.ToString();

            if (TxtLogInput.TextLength > 0)
            {
                data += "[" + datepicker + "]" + TxtLogInput.Text;

            }
            else
            {
                MessageBox.Show("Das Input Feld dar nicht leer sein");
            }
        }
    }
}
