using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace contact_manager
{
    class Credentials
    {
        public string username;
        public string password;
        public static List<Credentials> credentials = new List<Credentials>();

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        //Gets Credentials From TXT File
        public static void GetCredential()
        {
            string line;

            //Check if file is empty
            if (new FileInfo("Credentials.txt").Length != 0)
            {
                // Read the file and display it line by line.
                System.IO.StreamReader file = new System.IO.StreamReader("Credentials.txt");
                while ((line = file.ReadLine()) != null)
                {
                    string[] words = line.Split(',');
                    Credentials.credentials.Add(new Credentials
                    {
                        Username = (words[0]),
                        Password = (words[1]),
                    });
                }

                file.Close();
            }
        }
    }
}   
