using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public interface ITimetableView : IView
    {
        event Action ChooseTimetable;
        event Action ExportTimetable;
        event Action ImportTimetable;
        event Action SaveTimetable;
        event Action ChooseFeed;
    }
}
