using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Model;

namespace Presentation
{
    public class FirstPagePresenter
    {
        private readonly IKernel _kernel;
        private IFirstPageView _view;
        // Поле сервиса

        public FirstPagePresenter(IKernel kernel, IFirstPageView view)
        {
            _kernel = kernel;

            _view = view;
            _view.ShowAdminPageView += ShowAdminPageView;
            _view.ShowUserMainPageView += ShowUserMainPageView;


        }

        private void ShowAdminPageView()
        {
            _kernel.Get<AdminPagePresenter>().Run();
            _view.Close();
        }
        private void ShowUserMainPageView()
        {
            _kernel.Get<UserMainPagePresenter>().Run();
            _view.Close();
        }

        public void Run()
        {
            _view.Show();
        }
    }
}
