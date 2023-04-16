namespace TSPV.Core.MVVM
{
    using System;
    using Prism.Events;
    using Prism.Regions;
    using Prism.Services.Dialogs;
    using TSPV.Core.Services.Interfaces;

    public abstract class RegionViewModelBase : ViewModelBase, IConfirmNavigationRequest
    {
        protected RegionViewModelBase(IEventAggregator eventAggregator, IDialogService dialogService, IApplicationLogger logger) : base(eventAggregator, dialogService, logger)
        {
        }

        public virtual void ConfirmNavigationRequest(NavigationContext navigationContext, Action<bool> continuationCallback) => continuationCallback?.Invoke(true);

        public virtual bool IsNavigationTarget(NavigationContext navigationContext) => true;

        public virtual void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }

        public virtual void OnNavigatedTo(NavigationContext navigationContext)
        {
        }
    }
}