﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    interface ITimetableChoiseUserView : IView
    {
        event Action FeedСhoose;
    }
}
