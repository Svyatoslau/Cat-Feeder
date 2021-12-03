using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject;

using Presentation;

namespace Cat_Feeder
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Ninject.StandardKernel kernel = new StandardKernel();
            kernel.Bind<ApplicationContext>().ToConstant(new ApplicationContext());
            kernel.Bind<IAdminPageView>().To<AdminPageView>();
            kernel.Bind<IUserFeederChoiseView>().To<UserFeederChoiseView>();
            kernel.Bind<IUserFeedView>().To<UserFeedView>();
            kernel.Bind<IFirstPageView>().To<FirstPageView>();
            kernel.Bind<IAdminLogsFormView>().To<AdminLogsFormView>();
            kernel.Bind<IUserMakeMarkFormView>().To<UserMakeMarkFormView>();
            kernel.Bind<IAdminMonitorFeedView>().To<AdminMonitorFeedView>();
            kernel.Bind<IAdminRegFormView>().To<AdminRegFormView>();
            kernel.Bind<IAdminTimetableView>().To<AdminTimetableView>();
            kernel.Bind<IUserTimetableView>().To<UserTimetableView>();
            kernel.Bind<IUserLogsFormView2>().To<UserLogsFormView>();
            kernel.Bind<IUserMainPageView>().To<UserMainPageView>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //kernel.Get<FirstPageView>().Run();
            //Application.Run(kernel.Get<ApplicationContext>);
        }
    }
}
