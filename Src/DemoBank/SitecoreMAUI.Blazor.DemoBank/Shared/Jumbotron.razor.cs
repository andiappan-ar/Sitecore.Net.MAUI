using Microsoft.AspNetCore.Components;
using SitecoreMAUI.Blazor.DemoBank.Models.ViewModel;
using SitecoreMAUI.RenderingEngine.Model.SCFields;

namespace SitecoreMAUI.Blazor.DemoBank.Shared
{
    public partial class Jumbotron
    {
        [Parameter]
        public IDictionary<string,object> DynamicComponentModel { get; set; }

        public JumbotronViewModel Model { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Model = SCComponentBaseExtensions<JumbotronViewModel>.SerializeToModel(DynamicComponentModel);
        }
    }

}
