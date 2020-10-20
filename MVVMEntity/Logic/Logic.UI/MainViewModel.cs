using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Windows.Input;

namespace MVVMEntity.ViewModel
{ 
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            if (IsInDesignMode)
            {
                // Code runs in Blend --> create design time data.
                
            }
            else
            {
                // Code runs "for real"
                text = "Beispieltext";
            }
        }

        private string _Text;
        public string text
        {
            get
            {
                return _Text;
            }
            set
            {
                _Text = value;
                RaisePropertyChanged("text");
            }
        }
        private ICommand _Change;
        public ICommand Change
        {
            get
            {
                if(_Change == null)
                {
                    _Change = new RelayCommand(() =>
                    {
                        text = "Jetzt steht hier neuer Text";
                    });
                }
                return _Change;
            }
        }
    }
}