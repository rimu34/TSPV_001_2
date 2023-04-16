namespace TSPV.ViewModels
{
    public sealed partial class MainWindowVM
    {
        #region UI Properties

        private string _title = $"{Core.Properties.Settings.Default.ApplicationName} Ver{Core.Properties.Settings.Default.ApplicationVersion:0.00}";

        private int _menuIndex;

        public string Title
        {
            get { return _title; }
            set
            {
                SetProperty(ref _title, value);
            }
        }

        public int MenuIndex
        {
            get { return _menuIndex; }
            set
            {
                SetProperty(ref _menuIndex, value);
            }
        }

        #endregion UI Properties
    }
}