
using PhilHealth.ViewModels.Interfaces;


namespace PhilHealth.ViewModels
{
    public partial class MainPageViewModel : BaseViewModel, IMainPageViewModel, IQueryAttributable
    {

        public WebNavigatedEventArgs webNavigatedEventArgs;

        public MainPageViewModel(IConnectivity connectivity) : base(connectivity)
        {
            CheckInternetConnectivity();
        }


        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            throw new NotImplementedException();
        }
    }
}
