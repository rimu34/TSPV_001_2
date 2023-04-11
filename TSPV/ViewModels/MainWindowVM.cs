namespace TSPV.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Prism.Events;
    using Prism.Services.Dialogs;
    using TSPV.Core.MVVM;
    using TSPV.Core.Services.Interfaces;

    public sealed partial class MainWindowVM : ViewModelBase
    {
        public MainWindowVM(IEventAggregator eventAggregator, IDialogService dialogService, IApplicationLogger logger) 
            : base(eventAggregator, dialogService, logger)
        {
        }

        protected override void InitializeEvents()
        {
            throw new NotImplementedException();
        }

        protected override void InitializeProperties()
        {
            throw new NotImplementedException();
        }
    }
}
