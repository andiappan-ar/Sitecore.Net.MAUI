using Microsoft.AspNetCore.Components;

namespace SitecoreMAUI.RazorClassClient.Shared.Placeholder
{
    public partial class SCPlaceholder
    {
        [Parameter]
        public RenderingEngine.Model.SitecoreContext scmodel { get; set; }

        [Parameter]
        public string placeholderKey { get; set; }

    }


}
