using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    internal interface ITimetableChoiseUserView
    {
        event Action<string> FeedСhoose;
    }
}
