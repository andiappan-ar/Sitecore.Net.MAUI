using MvvmHelpers;
using Sitecore.MAUI.RenderingEngine.Model;
using Sitecore.MAUI.RenderingEngine.Service;

namespace Sitecore.MAUI.DemoBank.Model.ViewModel
{
    internal class IndexViewModel : BaseViewModel
    {
        public string? CurrentContextUrlPath { get; set; }

        public SitecoreContext sitecoreContext;
        public bool IsPostBack;

        public async Task InitializeAsync()
        {
            CurrentContextUrlPath = CurrentContextUrlPath ?? ServiceSettings.AppSettings.DefaultPage;
            ServiceSettings.AppSettings.SetCurrentContextUrlPath(CurrentContextUrlPath);
            sitecoreContext = await ServiceContext.GetSitecoreContext();
            IsPostBack = true;
        }

    }
}
