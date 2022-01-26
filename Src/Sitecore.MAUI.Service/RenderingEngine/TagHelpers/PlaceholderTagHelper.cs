using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Sitecore.MAUI.Service.RenderingEngine.TagHelpers
{
    [HtmlTargetElement("sc-placeholder")]
    public class PlaceholderTagHelper : TagHelper
    {       
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Content.SetContent("Custom sc component");
        }
    }
}
