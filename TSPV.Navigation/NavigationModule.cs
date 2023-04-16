using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Ioc;
using Prism.Regions;
using TSPV.Core;
using TSPV.Core.MVVM;
using TSPV.Navigation.ViewModels.HomeHeader;
using TSPV.Navigation.Views;

namespace TSPV.Navigation
{
    public class NavigationModule : ModuleBase
    {
        public NavigationModule(IRegionManager regionManager) : base(regionManager)
        {
        }

        public override void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RequestNavigate(RegionNames.NavigationMenuHeaderRegion, "Home");
        }

        public override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<HomeHeader, HomeHeaderRVM>("Home");
        }
    }
}
