using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Events;
using Prism.Services.Dialogs;
using TSPV.Core.MVVM;
using TSPV.Core.Services.Interfaces;

namespace TSPV.Navigation.ViewModels.HomeHeader
{
    public class HomeHeaderRVM : RegionViewModelBase
    {
        public HomeHeaderRVM(IEventAggregator eventAggregator, IDialogService dialogService, IApplicationLogger logger) : base(eventAggregator, dialogService, logger)
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
