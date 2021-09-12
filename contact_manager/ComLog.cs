using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
