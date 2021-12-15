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
        public IFirstPageView _view;
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
            var presenter = _kernel.Get<AdminPagePresenter>();
            //presenter.Run();
        }
        private void ShowUserMainPageView()
        {

        }

        public void Run()
        {
            _view.Show();
        }
    }
}
