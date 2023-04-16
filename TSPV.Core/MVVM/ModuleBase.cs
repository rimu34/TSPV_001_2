namespace TSPV.Core.MVVM
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Prism.Ioc;
    using Prism.Modularity;
    using Prism.Regions;

    public abstract class ModuleBase : IModule
    {
        protected readonly IRegionManager _regionManager;

        protected ModuleBase(IRegionManager regionManager) => _regionManager = regionManager;

        public abstract void OnInitialized(IContainerProvider containerProvider);
        public abstract void RegisterTypes(IContainerRegistry containerRegistry);
    }
}
