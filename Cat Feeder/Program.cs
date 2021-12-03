﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject;
using Presentation;
using View;



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
            kernel.Bind<IFeederChoiseUserView>().To<FeederChoiseUserView>();
            kernel.Bind<IFeedVeiw>().To<FeedView>();
            kernel.Bind<IFirstPageView>().To<FirstPageView>();
            kernel.Bind<ILogsFormView>().To<LogsFormView>();
            kernel.Bind<IMakeMarkFormView>().To<MakeMarkFormView>();
            kernel.Bind<IMonitorFeedAdminView>().To<MonitorFeedAdminView>();
            kernel.Bind<IRegFormView>().To<RegFormView>();
            kernel.Bind<ITimetableAdminView>().To<TimetableAdminView>();
            kernel.Bind<ITimetableView>().To<TimetableView>();
            kernel.Bind<IUserLogsFormVeiw>().To<UserLogsFormView>();
            kernel.Bind<IUserMainPageView>().To<UserMainPageView>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //kernel.Get<FirstPageView>().Run();
            //Application.Run(kernel.Get<ApplicationContext>);
        }
    }
}
