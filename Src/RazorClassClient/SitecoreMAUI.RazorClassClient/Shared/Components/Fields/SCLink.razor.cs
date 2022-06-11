using Microsoft.AspNetCore.Components;

namespace SitecoreMAUI.RazorClassClient.Shared.Components.Fields
{
    public partial class SCLink
    {
        [Parameter]
        public SitecoreMAUI.RenderingEngine.Model.SCFields.SCLink? scmodel { get; set; }

        [Parameter]
        public string? customDescription { get; set; }

        [Parameter]
        public string? customClass { get; set; }

    }


}
