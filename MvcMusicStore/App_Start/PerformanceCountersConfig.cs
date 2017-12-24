using System;
using System.Web.Mvc;
using MvcMusicStore.PerformanceCounters;
using PerformanceCounterHelper;

namespace MvcMusicStore
{
    public class PerformanceCountersConfig
    {
        public static void ConfigureCounters()
        {
            var controllerCounters = DependencyResolver.Current.GetService(typeof(CounterHelper<ControllersCounters>)) as CounterHelper<ControllersCounters>;
            foreach (ControllersCounters counter in Enum.GetValues(typeof(ControllersCounters)))
            {
                controllerCounters.Reset(counter);
            }
        }
    }
}