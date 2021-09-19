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
    public partial class Login : Form
    {
        Double count = 0;
        string user, pass;
        public Login()
        {
            InitializeComponent();
            TxtLoginPassword.PasswordChar = '*';
            Credentials credentials = new Credentials();
            Credentials.GetCredential();
            
        }

        private void CmdLoginLogin_Click(object sender, EventArgs e)
        {
            foreach (Credentials credentials in Credentials.credentials)
            {
                user = credentials.username;
                pass = credentials.password;
            }

            if ((TxtLoginUsername.Text == user) && (TxtLoginPassword.Text == pass))
            {
                Dashboard Form = new Dashboard();
                Form.Show();
                this.Close();
            }
            else
            {

                count = count + 1;
                double maxcount = 3;
                double remain;
                remain = maxcount - count;
                MessageBox.Show("Falscher Benutzername oder Passwort" + "\t" + remain + "" + " versuche übrig");
                TxtLoginPassword.Clear();
                TxtLoginUsername.Clear();
                TxtLoginUsername.Focus();
                if (count == maxcount)
                {
                    MessageBox.Show("Maximale Anzahl Versuche überschritten. Programm wird geschlossen.");
                    Application.Exit();
                }

            }
        }

        private void CmdLoginReset_Click(object sender, EventArgs e)
        {
            TxtLoginPassword.Clear();
            TxtLoginUsername.Clear();
            TxtLoginUsername.Focus();
        }

        private void CmdLoginExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.AcceptButton = CmdLoginLogin;
        }
    }
}
