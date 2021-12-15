using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Presentation
{
    public class AdminMonitorFeedPresenter
    {
        private readonly IKernel _kernel;
        private IAdminMonitorFeedView _view;

        public AdminMonitorFeedPresenter(IKernel kernel, IAdminMonitorFeedView view)
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
