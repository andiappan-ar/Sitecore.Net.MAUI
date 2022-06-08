using Microsoft.Extensions.Configuration;
using Sitecore.MAUI.RenderingEngine.Service;
using System.Reflection;

namespace Sitecore.MAUI.DemoBank
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
                });

            var a = Assembly.GetExecutingAssembly();
            using var stream = a.GetManifestResourceStream("Sitecore.MAUI.DemoBank.appsettings.json");
            var config = new ConfigurationBuilder()
                        .AddJsonStream(stream)
                        .Build();
            builder.Configuration.AddConfiguration(config);

            ServiceSettings.AppSettings = config.GetRequiredSection("Sitecore").Get<AppSettings>();
            ServiceSettings.AppSettings.CurrentContextUrlPath = ServiceSettings.AppSettings.DefaultPage;


            return builder.Build();
        }
    }
}