using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    interface ILogsFormView : IView
    {
        event Action<string> ShowAllLogs;
        event Action<string> ExportLogs;
        event Action<string> ChooseLog;
    }
}
