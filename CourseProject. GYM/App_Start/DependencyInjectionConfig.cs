using Data;
using Data.Abstractions;

using Microsoft.Web.Infrastructure.DynamicModuleHelper;

using Ninject;
using Ninject.Modules;
using Ninject.Web.Common;
using Ninject.Web.Common.WebHost;
using Ninject.Web.Mvc;

using Service;
using Service.Abstraction;

using System.Configuration;
using System.Web.Mvc;

namespace CourseProject.GYM.App_Start
{
    public class DependencyInjectionConfig
    {
        public static void RegisterDependencies()
        {
            var module = new Module();
            var kernel = new StandardKernel(module);
            var resolver = new NinjectDependencyResolver(kernel);

            DependencyResolver.SetResolver(resolver);
        }

        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
        }

        private static string GetDefaultConnection()
        {
            return ConfigurationManager.AppSettings.Get("defaultConnection");
        }

        private class Module : NinjectModule
        {
            public override void Load()
            {
                Bind<IDataUnitOfWork>()
                    .To<DataUnitOfWork>()
                    .InRequestScope()
                    .WithConstructorArgument("connectionString", GetDefaultConnection());

                Bind<IUserService>()
                    .To<UserService>()
                    .InRequestScope();

                Bind<IRoleService>()
                    .To<RoleService>()
                    .InRequestScope();

                Bind<IHallService>()
                    .To<HallService>()
                    .InRequestScope();

                Bind<ITrainingService>()
                    .To<TrainingService>()
                    .InRequestScope();

                Bind<ISessionService>()
                    .To<SessionService>()
                    .InRequestScope();

                Bind<ISpecializationService>()
                    .To<SpecializationService>()
                    .InRequestScope();

                Bind<IHallSpecializationService>()
                    .To<HallSpecializationService>()
                    .InRequestScope();

                Bind<IWorkSpecializationService>()
                    .To<WorkSpecializationService>()
                    .InRequestScope();
            }
        }
    }
}