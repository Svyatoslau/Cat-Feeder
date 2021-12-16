using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Presentation
{
    public class AdminRegFormPresenter
    {
        private readonly IKernel _kernel;
        private IAdminRegFormView _view;

        public AdminRegFormPresenter(IKernel kernel, IAdminRegFormView view)
        {
            _kernel = kernel;

            _view = view;
            _view.AddUser += AddUser;
        }

        private void AddUser(string login, string password)
        {
            _view.Close();
        }

        public void Run()
        {
            _view.Show();
        }
    }
}
