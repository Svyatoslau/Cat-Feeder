﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Model1;

namespace Presentation
{
    public class FirstPagePresenter
    {
        private readonly IKernel _kernel;
        private IFirstPageView _view;
        private IFirstPageService _service;

        public FirstPagePresenter(IKernel kernel, IFirstPageView view, IFirstPageService service)
        {
            _kernel = kernel;

            _view = view;
            _view.ShowAdminPageView += ShowAdminPageView;
            _view.ShowUserMainPageView += ShowUserMainPageView;
            

            _service = service;
            _service.UserEvent += UserEvent;
        }

        private void ShowAdminPageView()
        {
            _service.createAdmin(_view.login, _view.password);
            _kernel.Get<AdminPagePresenter>().Run();
            _view.Close();
        }
        private void ShowUserMainPageView()
        {
            _service.createCustormer(_view.login, _view.password);
            _kernel.Get<UserMainPagePresenter>().Run();
            _view.Close();
        }

        private void UserEvent()
        {

        }

        public void Run()
        {
            _view.Show();
        }
    }
}
