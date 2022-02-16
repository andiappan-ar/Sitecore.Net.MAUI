using Microsoft.AspNetCore.Components;
using Sitecore.MAUI.Blazor.Sample.Components.Models.ViewModel;
using Sitecore.MAUI.Service.Model.SCFields;

namespace Sitecore.MAUI.Blazor.Sample.Components.Shared
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
