using Microsoft.AspNetCore.Components;

namespace Sitecore.MAUI.RazorClassClient.Shared.Components.Fields
{
    public partial class SCImage
    {
        [Parameter]
        public Sitecore.MAUI.RenderingEngine.Model.SCFields.SCImage? scmodel { get; set; }

        [Parameter]
        public string? customClass { get; set; }

        [Parameter]
        public string? customStyle { get; set; }

    }


}
