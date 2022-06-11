namespace SitecoreMAUI.RenderingEngine.Model
{

    public class DynamicComponentModel
    {
        public string ComponentType { get; set; }
        public IDictionary<string, object> Parameters { get; set; }
    }

    public class DynamicComponentRoot
    {
        public List<DynamicComponentModel> componenets { get; set; }
    }


    public class JsonComponenet
    {
        public string component { get; set; }
        public IDictionary<string, object> Parameters { get; set; }
    }

    public class JsonRoot
    {
        public List<JsonComponenet> componenets { get; set; }
    }


}
