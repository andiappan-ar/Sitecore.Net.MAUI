using Microsoft.AspNetCore.Components;

namespace Sitecore.MAUI.RazorClassClient.Shared.Components.Fields
{
    public partial class SCLink
    {
        [Parameter]
        public Sitecore.MAUI.RenderingEngine.Model.SCFields.SCLink? scmodel { get; set; }

        [Parameter]
        public string? classAttr { get; set; }

    }


}
