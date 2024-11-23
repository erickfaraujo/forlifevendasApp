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

            var endpointServicos = "https://5b2deycovpevjqpdzngtdozt2u0veglf.lambda-url.us-east-1.on.aws/v1";
            //var endpointServicos = "https://localhost:50001/v1";

            builder.Services
            .AddRefitClient<IForlifeVendasApi>()
            .ConfigureHttpClient(client => client.BaseAddress = new Uri(endpointServicos));

            builder.Services.AddScoped<IForlifeService, ForlifeService>();

            return builder.Build();
        }
    }
}