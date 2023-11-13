using PhilHealth.ViewModels.Interfaces;
using PhilHealth.JScriptEvaluation;

namespace PhilHealth
{
    public partial class MainPage : ContentPage
    {
        string currentUrl = "";

        public MainPage(IMainPageViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }


        private void PhilHealthSite_Navigating(object sender, WebNavigatingEventArgs e)
        {
            PhilHealthSite.IsVisible = false;
            currentUrl = e.Url.ToString();

            PhilHealthSite.Navigated += PhilHealthSite_Navigated;
            PhilHealthSite.IsVisible = true;

        }


        private async void PhilHealthSite_Navigated(object sender, WebNavigatedEventArgs e)
        {
            if (e.Result == WebNavigationResult.Success)
            {
                
                switch (currentUrl)
                {
                    case "https://memberinquiry.philhealth.gov.ph/member/login.xhtml":
                        await PhilHealthSite.EvaluateJavaScriptAsync(LoginPage.loginScript);
                        break;
                    case "https://memberinquiry.philhealth.gov.ph/member/logout.xhtml":
                        await PhilHealthSite.EvaluateJavaScriptAsync(LogoutPage.logoutScript);
                        break;
                    default:
                        break;
                }
            }
        }



    }
}