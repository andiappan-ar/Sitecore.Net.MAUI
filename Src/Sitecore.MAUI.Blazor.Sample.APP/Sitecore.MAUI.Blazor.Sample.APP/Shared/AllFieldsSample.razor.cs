using Microsoft.AspNetCore.Components;
using Sitecore.MAUI.Blazor.Sample.APP.Models.ViewModel;
using Sitecore.MAUI.RenderingEngine.Model.SCFields;

namespace Sitecore.MAUI.Blazor.Sample.APP.Shared
{
    public partial class AllFieldsSample
    {
        [Parameter]
        public IDictionary<string,object> DynamicComponentModel { get; set; }

        public AllFieldsSampleViewModel Model1 { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Model1 = SCComponentBaseExtensions<AllFieldsSampleViewModel>.SerializeToModel(DynamicComponentModel);
        }
    }

}
