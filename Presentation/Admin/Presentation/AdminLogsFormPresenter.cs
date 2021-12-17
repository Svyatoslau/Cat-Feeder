using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Presentation
{
    public class AdminLogsFormPresenter
    {
        private readonly IKernel _kernel;
        private IAdminLogsFormView _view;

        public AdminLogsFormPresenter(IKernel kernel, IAdminLogsFormView view)
        {
            _kernel = kernel;

            _view = view;
            _view.ChooseUser += ChooseUser;
            _view.ChooseLog += ChooseLog;
            _view.PrintAllLogs += PrintAllLogs;
            _view.ExportLogs += ExportLogs;
        }

        private void ChooseUser()
        {

        }

        private void ChooseLog()
        {

        }

        private void PrintAllLogs()
        {

        }

        private void ExportLogs()
        {

        }

        public void Run()
        {
            _view.Show();
        }
    }
}
