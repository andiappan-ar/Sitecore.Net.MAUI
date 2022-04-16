namespace Sitecore.MAUI.RenderingEngine.Model.SCFields
{
    public class SCMultiList<T>
    {
        public string id { get; set; }
        public string url { get; set; }
        public string name { get; set; }
        public string displayName { get; set; }
        public T fields { get; set; }
    }

}
