namespace Sitecore.MAUI.Blazor.Client
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
           

            builder.Services.AddMauiBlazorWebView();

            

            return builder.Build();
        }
    }
}