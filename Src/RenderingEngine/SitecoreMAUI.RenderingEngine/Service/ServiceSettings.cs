namespace SitecoreMAUI.RenderingEngine.Service
{

    public static class ServiceSettings
    {
        public static AppSettings AppSettings;                   
    }

    public class AppSettings
    {
        public bool EnableExperienceEditor { get; set; }
        public string sc_site { get; set; }
        public string SitecoreHeadlessServiceApiKey { get; set; }        
        public string DefaultPage { get; set; }
        public string NotFoundPage { get; set; }
        public string SitecoreHeadlessServiceUrl { get; set; }
        public string ClientComponentNamespace { get; set; }
       

        public string CurrentContextUrlPath = "/";
        
        public string Key_DynamicComponentModel = "DynamicComponentModel";

        public Func<AppSettings, string> GetSitecoreHeadlessServiceUrl = (app) => { return $"{app.SitecoreHeadlessServiceUrl}{app.CurrentContextUrlPath}&sc_lang=en&sc_apikey={app.SitecoreHeadlessServiceApiKey}&sc_site={app.sc_site}"; };

        public Action<string> SetCurrentContextUrlPath = (url) => { ServiceSettings.AppSettings.CurrentContextUrlPath = url; };
    }
}
