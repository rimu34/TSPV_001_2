namespace TSPV.Core.MVVM
{
    using System;
    using Prism.Events;
    using Prism.Services.Dialogs;
    using TSPV.Core.Services.Interfaces;

    public abstract class DialogViewModelBase : ViewModelBase, IDialogAware
    {
        protected DialogViewModelBase(IEventAggregator eventAggregator, IDialogService dialogService, IApplicationLogger logger) : base(eventAggregator, dialogService, logger)
        {
        }

        public string Title { get; protected set; }

        public abstract event Action<IDialogResult> RequestClose;

        public virtual bool CanCloseDialog() => true;

        public virtual void OnDialogClosed()
        { }

        public virtual void OnDialogOpened(IDialogParameters parameters)
        { }
    }
}