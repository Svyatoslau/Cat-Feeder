using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Presentation
{
    public class AdminPagePresenter
    {
        private readonly IKernel _kernel;
        private IAdminPageView _view;

        public AdminPagePresenter(IKernel kernel, IAdminPageView view)
        {
            _kernel = kernel;

            _view = view;
            _view.ShowAdminRegFormView += ShowAdminRegFormView;
            _view.ShowAdminLogsFormView += ShowAdminLogsFormView;


        }

        private void ShowAdminRegFormView()
        {
            _kernel.Get<AdminRegFormPresenter>().Run();
            _view.Close();
        }

        private void ShowAdminLogsFormView()
        {
            _kernel.Get<AdminLogsFormPresenter>().Run();
            _view.Close();
        }

        public void Run()
        {
            _view.Show();
        }
    }
}
