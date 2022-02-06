using Microsoft.AspNetCore.Components;
using Sitecore.MAUI.Client.Models.ViewModel;
using Sitecore.MAUI.Service.Model.SCFields;

namespace Sitecore.MAUI.Client.Shared
{
    public partial class ContentBlock
    {
        [Parameter]
        public IDictionary<string,object> DynamicComponentModel { get; set; }

        public ContentBlockViewModel Model { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Model = SCComponentBaseExtensions<ContentBlockViewModel>.SerializeToModel(DynamicComponentModel);
        }
    }

}
