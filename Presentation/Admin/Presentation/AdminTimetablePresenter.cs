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
        }

        public void Run()
        {
            _view.Show();
        }
    }
}
