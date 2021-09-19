using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace contact_manager
{
    class ComLog
    {
        public ComLog Datepicker { get; set; }
       
        //Aktueller Timestamp
        public DateTime Timestamp { get; private set; }

        public ComLog(double value, DateTime timestamp)
        {
            Timestamp = timestamp;
        }

        public string value { get; set; }


        public static void ReadFromTxt(CommunicationLog cl)
        {
            string line;
            string instanceid = cl.TxtInstanceID.Text;

            //Check if file is empty
            if (new FileInfo("ComLog.txt").Length != 0)
            {
                // Read the file and display it line by line.
                System.IO.StreamReader file = new System.IO.StreamReader("ComLog.txt");
                while ((line = file.ReadLine()) != null)
                {
                    string[] words = line.Split(';');
                    Console.WriteLine(words[0]);
                    if (words[0] == instanceid)
                    {
                        cl.DgvLogOutput.Rows.Add(words);

                    }
                }

                file.Close();
            }
        }
    }
}
