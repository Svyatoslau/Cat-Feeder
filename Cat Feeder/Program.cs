using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cat_Feeder
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FirstPage());
            //Application.Run(new Feed());
            //Application.Run(new Timetable());
            //Application.Run(new TimetableAdmin());
            //Application.Run(new UserMainPage()); 
            //Application.Run(new MonitorFeedAdmin()); 
            //Application.Run(new AdminPage());
            //Application.Run(new LogsForm());
            //Application.Run(new MakeMarkForm());
            Application.Run(new RegForm());
            //Application.Run(new UserLogsForm());
        }
    }
}
