namespace Sitecore.MAUI.Service.Model.SCFields
{
    public class SCImage
    {
        public SCImageValue value { get; set; }
    }

    public class SCImageValue
    {
        public string src { get; set; }
        public string alt { get; set; }
        public string width { get; set; }
        public string height { get; set; }
    }

}
