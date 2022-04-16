using Microsoft.AspNetCore.Components;
using Sitecore.MAUI.Blazor.Sample.APP.Models.ViewModel;
using Sitecore.MAUI.RenderingEngine.Model.SCFields;

namespace Sitecore.MAUI.Blazor.Sample.APP.Shared
{
    public partial class ContentBlock
    {
        [Parameter]
        public IDictionary<string, object> DynamicComponentModel { get; set; }

        public ContentBlockViewModel Model { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Model = SCComponentBaseExtensions<ContentBlockViewModel>.SerializeToModel(DynamicComponentModel);
        }

        Frame frame = new Frame
        {
            BorderColor = Colors.Gray,
            CornerRadius = 10,
            Content = new Label { Text = "Frame wrapped around a Label" }
        };
    }

}
