using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    interface IMonitorFeedAdminView : IView
    {
        string name { get; }
        string typeOfFeeder { get; }

        event Action ChoiseFeeder;
        event Action ChoiseUser;

    }
}
