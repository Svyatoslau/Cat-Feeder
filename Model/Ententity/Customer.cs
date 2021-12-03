using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Ententity
{
    abstract class Customer
    {
        private string name;

        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        internal List<Timetable> Timetables { get => timetables; set => timetables = value; }
        internal List<Log> Logs { get => logs; set => logs = value; }

        private string password;

        private List<Timetable> timetables;

        private List<Log> logs;

        
    }
}
