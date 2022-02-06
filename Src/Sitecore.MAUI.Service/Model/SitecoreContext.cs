using Newtonsoft.Json;

namespace Sitecore.MAUI.Service.Model
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

    public class Sitecore
    {
        public Context context { get; set; }
        public Route route { get; set; }
    }

    public class SitecoreContext
    {
        public Sitecore sitecore { get; set; }
    }

    public class Context
    {
        public long visitorIdentificationTimestamp { get; set; }
        public bool pageEditing { get; set; }
        public Site site { get; set; }
        public string pageState { get; set; }
        public string language { get; set; }
        public string itemPath { get; set; }
    }

    public class Site
    {
        public string name { get; set; }
    }


    public class Route
    {
        public string name { get; set; }
        public string displayName { get; set; }
        public Dictionary<string, object> fields { get; set; }
        public string databaseName { get; set; }
        public string deviceId { get; set; }
        public string itemId { get; set; }
        public string itemLanguage { get; set; }
        public int itemVersion { get; set; }
        public string layoutId { get; set; }
        public string templateId { get; set; }
        public string templateName { get; set; }

        public IDictionary<string,List<JsonRendering>> placeholders { get; set; }
    }

    public class JsonRendering
    {
        public string uid { get; set; }
        public string componentName { get; set; }
       
        public string dataSource { get; set; }
        public IDictionary<string, object> @params { get; set; }
        public IDictionary<string, object> fields { get; set; }
        public Type componentType { get; set; }
        
    }

 






}
