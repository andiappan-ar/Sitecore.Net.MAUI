using Microsoft.AspNetCore.Components;

namespace Sitecore.MAUI.RazorClassClient.Shared.Components.Fields
{
    public partial class SCCheckbox
    {
        [Parameter]
        public Sitecore.MAUI.RenderingEngine.Model.SCFields.SCCheckbox? scmodel { get; set; }

    }


}
