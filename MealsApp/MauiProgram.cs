

using MealsApp.Authentication;
using MealsAppLibrary.Data;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.Logging;

namespace MealsApp
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
            builder.Services.AddAuthorizationCore();
            builder.Services.AddCascadingAuthenticationState();
            builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();
    		builder.Logging.AddDebug();
#endif    
            builder.Services.AddTransient<IMealsService, MealsService>();

            return builder.Build();
        }
    }
}
