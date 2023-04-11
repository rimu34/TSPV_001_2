namespace TSPV
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows;
    using Prism.DryIoc;
    using Prism.Ioc;
    using TSPV.Core;
    using TSPV.ViewModels;
    using TSPV.Views;

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        private const string _mainWindow = "Shell";

        protected override Window CreateShell() => Container.Resolve<MainWindow>();

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            /// Register Services
            containerRegistry.RegisterCoreServices();

            /// Register Views & ViewModels
            containerRegistry.RegisterForNavigation<MainWindow, MainWindowVM>(_mainWindow);
        }
    }
}
