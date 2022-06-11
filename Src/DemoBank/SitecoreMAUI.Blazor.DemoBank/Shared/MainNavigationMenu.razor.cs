using Microsoft.AspNetCore.Components;
using SitecoreMAUI.Blazor.DemoBank.Models.ViewModel;
using SitecoreMAUI.RenderingEngine.Model.SCFields;

namespace SitecoreMAUI.Blazor.DemoBank.Shared
{
    public partial class MainNavigationMenu
    {
        [Parameter]
        public IDictionary<string,object> DynamicComponentModel { get; set; }

        public MainNavigationMenuViewModel Model { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Model = SCComponentBaseExtensions<MainNavigationMenuViewModel>.SerializeToModel(DynamicComponentModel);
        }
    }

}
