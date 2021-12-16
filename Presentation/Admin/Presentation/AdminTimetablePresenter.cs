using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Presentation
{
    public class AdminTimetablePresenter
    {
        private readonly IKernel _kernel;
        private IAdminTimetableView _view;

        public AdminTimetablePresenter(IKernel kernel, IAdminTimetableView view)
        {
            _kernel = kernel;

            _view = view;
            _view.TimetableExportAdmin += TimetableExportAdmin;
            _view.TimetableImportAdmin += TimetableImportAdmin;
            _view.TimetableСhoose += TimetableСhoose;
            _view.TimetableText += TimetableText;
        }

        private void TimetableExportAdmin()
        {

        }

        private void TimetableImportAdmin()
        {

        }

        private void TimetableСhoose(int timetable)
        {

        }

        private void TimetableText(string timetableText)
        {

        }

        public void Run()
        {
            _view.Show();
        }
    }
}
