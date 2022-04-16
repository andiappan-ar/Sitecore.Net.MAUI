using Sitecore.MAUI.RenderingEngine.Model.SCFields;

namespace Sitecore.MAUI.Blazor.Sample.Components.Models.ViewModel
{
    public class AllFieldsSampleViewModel
    {
      
        public SCSingleLineText Field_SIngleLineText { get; set; }
        public SCCheckbox Field_Checkbox { get; set; }
        public SCDateTime Field_DateTime { get; set; }
        public SCImage Field_Image { get; set; }
        public SCInteger Field_Integer { get; set; }
        public SCMultiline Field_Multiline { get; set; }
        public SCNumber Field_Number { get; set; }
        public SCRichText Field_RichText { get; set; }
        public SCDropList Field_DropList { get; set; }
        public List<SCMultiList<FrequencyMultiList>> Field_MultiList { get; set; }
        public SCLink Field_Link { get; set; }

      
    }
    public class FrequencyMultiList
    {
        public SCSingleLineText Key { get; set; }
        public SCSingleLineText AdditionalField { get; set; }
    }
}
