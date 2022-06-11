using Microsoft.AspNetCore.Components;

namespace SitecoreMAUI.RazorClassClient.Shared.Components.Fields
{
    public partial class SCImage
    {
        [Parameter]
        public SitecoreMAUI.RenderingEngine.Model.SCFields.SCImage? scmodel { get; set; }

        [Parameter]
        public string? customClass { get; set; }

        [Parameter]
        public string? customStyle { get; set; }

    }


}
