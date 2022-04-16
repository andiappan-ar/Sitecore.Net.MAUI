using Microsoft.AspNetCore.Components.WebView.Maui;


namespace Sitecore.MAUI.Blazor.Sample.Components
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();            

            return builder.Build();
        }
    }
}