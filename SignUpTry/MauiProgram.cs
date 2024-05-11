using Microsoft.Extensions.Logging;
using SignUpTry.Interfaces;
using SignUpTry.Services;
using SignUpTry.ViewModels;
using SignUpTry.Views;
using CommunityToolkit.Maui;

namespace SignUpTry
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>().ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("montserrat.ttf", "mont");
            }).UseMauiCommunityToolkit();
#if DEBUG
            builder.Logging.AddDebug();
#endif
            builder.RegisterServices().RegisterViewModels().RegisterViews();
            return builder.Build();
        }

        public static MauiAppBuilder RegisterServices(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddTransient<IExampleService, ExampleService>();
            mauiAppBuilder.Services.AddTransient<IAlertDialogService, DefaultMauiAlertDialogService>();
            return mauiAppBuilder;
        }

        public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<SignupViewModel>();
            return mauiAppBuilder;
        }

        public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddTransient<SignupView>();
            return mauiAppBuilder;
        }
    }
}