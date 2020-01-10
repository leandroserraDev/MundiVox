[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(TorneiroMataMata.UI.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(TorneiroMataMata.UI.App_Start.NinjectWebCommon), "Stop")]

namespace TorneiroMataMata.UI.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using TorneiroMataMata.Application;
    using TorneiroMataMata.Application.Interfaces;
    using TorneiroMataMata.Domain.Interfaces.Repositories;
    using TorneiroMataMata.Domain.Interfaces.Services;
    using TorneiroMataMata.Domain.Services;
    using TorneiroMataMata.Infra.Repositories;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            kernel.Bind<ITimeRepository>().To<TimeRepository>();
            kernel.Bind<IGrupoRepository>().To<GrupoRepository>();

            kernel.Bind(typeof(IServiceBase<>)).To(typeof(IServiceBase<>));
            kernel.Bind<ITimeService>().To<TimeService>();
            kernel.Bind<IGrupoService>().To<GrupoService>();

            kernel.Bind(typeof(IAppBase<>)).To(typeof(AppBase<>));
            kernel.Bind<IAppTime>().To<AppTime>();
            kernel.Bind<IAppGrupo>().To<AppGrupo>();
        }        
    }
}
