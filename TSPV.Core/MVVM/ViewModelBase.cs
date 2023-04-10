namespace TSPV.Core.MVVM
{
    using System;
    using NLog;
    using Prism.Events;
    using Prism.Mvvm;
    using Prism.Navigation;
    using Prism.Services.Dialogs;
    using TSPV.Core.Services.Interfaces;

    public abstract class ViewModelBase : BindableBase, IDestructible
    {
        protected readonly IEventAggregator _eventAggregator;
        protected readonly IDialogService _dialogService;
        protected readonly IApplicationLogger _logger;

        protected ViewModelBase(IEventAggregator eventAggregator, IDialogService dialogService, IApplicationLogger logger)
        {
            _eventAggregator = eventAggregator;
            _dialogService = dialogService;
            _logger = logger;
        }

        protected abstract void InitializeEvents();

        protected abstract void InitializeProperties();

        protected virtual void InitializeViewModel()
        {
            InitializeEvents();
            InitializeProperties();
        }

        protected virtual void HandleExceptions(Exception ex) => _logger.LogException(LogLevel.Error, ex);

        public virtual void Destroy()
        {
        }
    }
}