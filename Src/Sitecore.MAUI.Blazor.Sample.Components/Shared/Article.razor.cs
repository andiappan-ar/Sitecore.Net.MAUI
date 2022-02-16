using Microsoft.AspNetCore.Components;
using Sitecore.MAUI.Blazor.Sample.Components.Models.ViewModel;
using Sitecore.MAUI.Service.Model.SCFields;

namespace Sitecore.MAUI.Blazor.Sample.Components.Shared
{
    public partial class Article
    {
        [Parameter]
        public IDictionary<string,object> DynamicComponentModel { get; set; }

        public ArticleViewModel Model { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Model = SCComponentBaseExtensions<ArticleViewModel>.SerializeToModel(DynamicComponentModel);
        }
    }

}
