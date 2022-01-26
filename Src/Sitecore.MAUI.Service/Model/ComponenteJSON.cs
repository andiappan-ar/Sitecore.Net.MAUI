namespace Sitecore.MAUI.Service.Model
{

    public class JSONComponent
    {
        public string Component { get; set; }
        public IDictionary<string, object> Parameters { get; set; }
    }

    public class DynamicComponentModel
    {
        public string Component { get; set; }
        public IDictionary<string, object> parameters { get; set; }
    }
}
