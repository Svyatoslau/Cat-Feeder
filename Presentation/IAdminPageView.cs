using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    interface IAdminPageView: IView
    {
        event Action<string> ClickToAddUser;
        event Action<string> MonitorFeeders;
        event Action<string> ShowAdminLogs;
        event Action<string> WatchAllShedules;
    }
}
