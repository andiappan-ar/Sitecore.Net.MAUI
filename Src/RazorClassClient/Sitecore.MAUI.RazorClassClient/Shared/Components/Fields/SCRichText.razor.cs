using Microsoft.AspNetCore.Components;

namespace Sitecore.MAUI.RazorClassClient.Shared.Components.Fields
{
    public partial class SCRichText
    {
        [Parameter]
        public Sitecore.MAUI.RenderingEngine.Model.SCFields.SCRichText? scmodel { get; set; }     

    }


}
