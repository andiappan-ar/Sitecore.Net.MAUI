using Microsoft.AspNetCore.Components;

namespace SitecoreMAUI.RazorClassClient.Shared.Components.Fields
{
    public partial class SCRichText
    {
        [Parameter]
        public SitecoreMAUI.RenderingEngine.Model.SCFields.SCRichText? scmodel { get; set; }        

    }


}
