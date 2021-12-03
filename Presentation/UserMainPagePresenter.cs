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
        private IUserMainPageView _veiw;

        private void ShowMakeMarkFormView()
        {
            var presenter = _kernel.Get<UserMakeMarkFormPresenter>;

        }
    }
}
