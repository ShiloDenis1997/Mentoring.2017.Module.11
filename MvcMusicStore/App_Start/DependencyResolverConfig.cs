using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using MusicStore.Infrastructure;
using MvcMusicStore.PerformanceCounters;
using PerformanceCounterHelper;

namespace MvcMusicStore
{
    public class DependencyResolverConfig
    {
        public static IDependencyResolver GetConfiguredDependencyResolver()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            ConfigureBindings(builder);
            var container = builder.Build();
            return new AutofacDependencyResolver(container);
        }

        private static void ConfigureBindings(ContainerBuilder builder)
        {
            builder.Register(c => PerformanceHelper.CreateCounterHelper<ControllersCounters>()).SingleInstance().As<CounterHelper<ControllersCounters>>();
            builder.RegisterType<Logger>().As<ILogger>();
        }
    }
}