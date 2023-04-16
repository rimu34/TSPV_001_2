namespace TSPV
{
    using System.Windows;
    using Prism.DryIoc;
    using Prism.Ioc;
    using Prism.Modularity;
    using TSPV.Core;
    using TSPV.Navigation;
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

        protected override IModuleCatalog CreateModuleCatalog()
        {
            var catalog = base.CreateModuleCatalog();

            catalog.AddModule<NavigationModule>();

            return catalog;
        }
    }
}