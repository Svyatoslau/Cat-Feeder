using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    interface ITimetableView : IView
    {
        event Action<string> ChooseTimetable;
        event Action<string> ExportTimetable;
        event Action<string> ImportTimetable;
        event Action<string> SaveTimetable;
        event Action<string> ChooseFeed;
    }
}
