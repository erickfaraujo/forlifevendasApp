using ForlifeApplication.Web;
using ForlifeApplication.Web.Services;
using Microsoft.Extensions.Logging;
using Refit;

namespace ForlifeApp.Web
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            //Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NHaF1cWWhIfEx3THxbf1xzZFRHal5TTnJXUiweQnxTdEZiW35ccXVXRGRUU0x/WQ==");
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            builder.Services
            .AddRefitClient<IForlifeVendasApi>()
            .ConfigureHttpClient(client => client.BaseAddress = new Uri("https://cjqhqfldai7t4ilg332oggchdu0mpaca.lambda-url.us-east-1.on.aws/v1"));

            //builder.Services.AddSyncfusionBlazor();

            return builder.Build();
        }
    }
}