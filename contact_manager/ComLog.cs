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
        public string txtid;
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
            string instanceid = cl.TxtInstanceID.Text;
            string txtid;
            List<string> ids = new List<string>();

            using(var sr = new StreamReader("ComLog.txt"))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    var value = line.Split(';');

                    ids.Add(value[0]);
                }
            }
            
            string[] lines = File.ReadAllLines("ComLog.txt");
            string[] values;

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split(';');
                string[] row = new string[values.Length];

                for(int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                cl.DgvLogOutput.Rows.Add(row);
            }
        }
    }
}
