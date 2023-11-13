using Microsoft.Extensions.Logging;
using PhilHealth.ViewModels;
using PhilHealth.ViewModels.Interfaces;

namespace PhilHealth
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                }).UseMauiCommunityToolkit(options => {
                    options.SetShouldSuppressExceptionsInConverters(false);
                    options.SetShouldSuppressExceptionsInBehaviors(false);
                    options.SetShouldSuppressExceptionsInAnimations(false);
                });



            builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);


            //Pages
            builder.Services.AddTransient<MainPage>();
          



            //View Models
            builder.Services.AddTransient<IBaseViewModel, BaseViewModel>();
            builder.Services.AddTransient<IMainPageViewModel, MainPageViewModel>();


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}