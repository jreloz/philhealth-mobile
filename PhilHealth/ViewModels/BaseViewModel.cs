
using PhilHealth.ViewModels.Interfaces;

namespace PhilHealth.ViewModels
{
    public partial class BaseViewModel : ObservableObject, IBaseViewModel
    {
        [ObservableProperty] private bool isBusy;
        [ObservableProperty] private bool isEnabled = true;

        IConnectivity connectivity;

        public BaseViewModel(IConnectivity connectivity) 
        {
            this.connectivity = connectivity;
        }

        public bool IsAppBusy
        {
            get { return IsBusy; }
            set
            {
                if (IsBusy != value)
                {
                    IsBusy = value;
                    IsEnabled = !value;
                }
                else
                {
                    IsBusy = !value;
                    IsEnabled = value;
                }
            }
        }



        public void CheckInternetConnectivity()
        {
            if (connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                Shell.Current.DisplayAlert("No connectivity!",
                    $"Please check internet and try again.", "OK");
                return;
            }
        }

    }
}
