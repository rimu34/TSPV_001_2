namespace TSPV.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Prism.Ioc;
    using TSPV.Core.Services;
    using TSPV.Core.Services.Interfaces;

    public static class DependencyInjection
    {
        public static IContainerRegistry RegisterCoreServices(this IContainerRegistry registry)
        {
            /// Register Core Services
            registry.Register<IApplicationLogger, ApplicationLogger>();

            return registry;
        }
    }
}
