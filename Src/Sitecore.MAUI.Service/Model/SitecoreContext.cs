using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore.MAUI.Service.Model
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Site
    {
        public string name { get; set; }
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

    public class PageTitle
    {
        public string value { get; set; }
    }

    public class Fields
    {
        public PageTitle pageTitle { get; set; }
        public Heading heading { get; set; }
        public Content content { get; set; }
        public Title Title { get; set; }
    }

    public class Params
    {
    }

    public class Heading
    {
        public string value { get; set; }
    }

    public class Content
    {
        public string value { get; set; }
    }

    public class Title
    {
        public string value { get; set; }
    }

    public class MyprojectMain
    {
        public string uid { get; set; }
        public string componentName { get; set; }
        public string dataSource { get; set; }
        public Params @params { get; set; }
        public Fields fields { get; set; }
    }

    public class Placeholders
    {
        [JsonProperty("jss-main1")]
        public List<object> JssMain1 { get; set; }

        [JsonProperty("myproject-main")]
        public List<MyprojectMain> MyprojectMain { get; set; }
    }

    public class Route
    {
        public string name { get; set; }
        public string displayName { get; set; }
        public Fields fields { get; set; }
        public string databaseName { get; set; }
        public string deviceId { get; set; }
        public string itemId { get; set; }
        public string itemLanguage { get; set; }
        public int itemVersion { get; set; }
        public string layoutId { get; set; }
        public string templateId { get; set; }
        public string templateName { get; set; }
        public Placeholders placeholders { get; set; }
    }

    public class Sitecore
    {
        public Context context { get; set; }
        public Route route { get; set; }
    }

    public class SitecoreContext
    {
        public Sitecore sitecore { get; set; }
    }


}
