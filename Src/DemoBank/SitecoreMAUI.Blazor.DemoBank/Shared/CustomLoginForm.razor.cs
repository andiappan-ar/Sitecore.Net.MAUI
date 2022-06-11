using Microsoft.AspNetCore.Components;
using SitecoreMAUI.Blazor.DemoBank.Models.ViewModel;
using SitecoreMAUI.RenderingEngine.Model.SCFields;

namespace SitecoreMAUI.Blazor.DemoBank.Shared
{
    public partial class CustomLoginForm
    {
        [Parameter]
        public IDictionary<string,object> DynamicComponentModel { get; set; }

        public CustomLoginFormViewModel Model { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Model = SCComponentBaseExtensions<CustomLoginFormViewModel>.SerializeToModel(DynamicComponentModel);
        }
    }

}
