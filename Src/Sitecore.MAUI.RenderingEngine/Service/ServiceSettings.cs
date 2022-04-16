namespace Sitecore.MAUI.RenderingEngine.Service
{
    public static class ServiceSettings
    {
        static ServiceSettings()
        {
            IsExperienceEditor = true;
            SitecoreHeadlessServiceApiKey = "%7B20CC82CD-F3EA-4905-85AA-44CDEE3B5F0A%7D";
            CurrentContextUrlPath = "/";
            SitecoreHeadlessServiceUrl = "http://a-custom-route.com/sitecore/api/layout/render/jss?item=";
            ClientComponentNamespace = "Sitecore.MAUI.Blazor.Sample.APP.Shared.{0}, Sitecore.MAUI.Blazor.Sample.APP";
            Key_DynamicComponentModel = "DynamicComponentModel";
        }
        public static bool IsExperienceEditor { get; set; }

        public static string SitecoreHeadlessServiceApiKey { get; set; }
        public static string CurrentContextUrlPath { get; set; }
        public static string SitecoreHeadlessServiceUrl { get; set; }

        public static Func<string> GetSitecoreHeadlessServiceUrl =()=> { return $"{SitecoreHeadlessServiceUrl}{CurrentContextUrlPath}&sc_lang=en&sc_apikey={SitecoreHeadlessServiceApiKey}"; };    
        public static string ClientComponentNamespace { get; set; }    
        public static string Key_DynamicComponentModel { get; set; }    
        

    }
}
