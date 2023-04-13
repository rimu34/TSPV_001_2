namespace TSPV.ViewModels
{
    public sealed partial class MainWindowVM
    {
        #region UI Properties

        private string _title = $"{Core.Properties.Settings.Default.ApplicationName} Ver{Core.Properties.Settings.Default.ApplicationVersion:0.00}";

        public string Title
        {
            get { return _title; }
            set
            {
                SetProperty(ref _title, value);
            }
        }

        #endregion UI Properties
    }
}