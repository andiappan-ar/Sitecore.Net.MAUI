namespace SitecoreMAUI.RenderingEngine.Model.SCFields
{
    public class SCLink
    {
        public SCLinkValue value { get; set; }
    }

    public class SCLinkValue
    {
        public string href { get; set; }
        public string text { get; set; }
        public string anchor { get; set; }
        public string linktype { get; set; }
        public string @class { get; set; }
        public string cls 
        { get{ return @class; } }
        public string title { get; set; }
        public string querystring { get; set; }
        public string id { get; set; }
    }
}
