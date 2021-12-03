﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public interface ITimetableAdminView : IView
    {
        event Action TimetableСhoose;
        event Action TimetableExportAdmin;
        event Action TimetableImportAdmin;
        event Action<string> TimetableText;
    }
}
