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
            kernel.Bind<IFeederChoiseUserView>().To<UserFeederChoiseView>();
            kernel.Bind<IFeedVeiw>().To<UserFeedView>();
            kernel.Bind<IFirstPageView>().To<FirstPageView>();
            kernel.Bind<ILogsFormView>().To<AdminLogsFormView>();
            kernel.Bind<IMakeMarkFormView>().To<UserMakeMarkFormView>();
            kernel.Bind<IMonitorFeedAdminView>().To<AdminMonitorFeedView>();
            kernel.Bind<IRegFormView>().To<AdminRegFormView>();
            kernel.Bind<ITimetableAdminView>().To<AdminTimetableView>();
            kernel.Bind<ITimetableView>().To<UserTimetableView>();
            kernel.Bind<IUserLogsFormVeiw>().To<UserLogsFormView>();
            kernel.Bind<IUserMainPageView>().To<UserMainPageView>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //kernel.Get<FirstPageView>().Run();
            //Application.Run(kernel.Get<ApplicationContext>);
        }
    }
}
