using Microsoft.AspNetCore.Components;

namespace Sitecore.MAUI.RazorClassClient.Shared.Placeholder
{
    public partial class SCPlaceholder
    {
        [Parameter]
        public RenderingEngine.Model.SitecoreContext scmodel { get; set; }

        [Parameter]
        public string placeholderKey { get; set; }

    }


}
