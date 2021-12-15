using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Presentation
{
    public class UserTimetablePresenter
    {
        private readonly IKernel _kernel;
        private IUserTimetableView _view;

        public UserTimetablePresenter(IKernel kernel, IUserTimetableView view)
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
