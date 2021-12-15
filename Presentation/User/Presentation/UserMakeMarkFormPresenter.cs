﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Presentation
{
    public class UserMakeMarkFormPresenter
    {
        private readonly IKernel _kernel;
        private IUserMakeMarkFormView _view;

        public UserMakeMarkFormPresenter(IKernel kernel, IUserMakeMarkFormView view)
        {
            _kernel = kernel;

            _view = view;
        }

        public void Run()
        {
            _view.Show();
        }

    }
}
