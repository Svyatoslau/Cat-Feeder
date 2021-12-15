using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Presentation
{
    public class UserMainPagePresenter
    {
        private readonly IKernel _kernel;
        private IUserMainPageView _view;

        public UserMainPagePresenter(IKernel kernel, IUserMainPageView view)
        {
            _kernel = kernel;

            _view = view;
            _view.ShowFeedVeiw += ShowFeedVeiw;
            _view.ShowMakeMarkFormView += ShowMakeMarkFormView;
            _view.ShowLogsFormView += ShowLogsFormView;
            _view.ShowTimetableView += ShowTimetableView;

        }


        private void ShowFeedVeiw()
        {
            //var presenter = _kernel.Get<UserMakeMarkFormPresenter>;

        }
        private void ShowMakeMarkFormView()
        {
            //var presenter = _kernel.Get<UserMakeMarkFormPresenter>;

        }
        private void ShowLogsFormView()
        {
            //var presenter = _kernel.Get<UserMakeMarkFormPresenter>;

        }
        private void ShowTimetableView()
        {
            //var presenter = _kernel.Get<UserMakeMarkFormPresenter>;

        }

        public void Run()
        {
            _view.Show();
        }
    }
}
