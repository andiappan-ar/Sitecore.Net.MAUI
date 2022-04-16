using Microsoft.AspNetCore.Components;
using Sitecore.MAUI.Blazor.Sample.APP.Models.ViewModel;
using Sitecore.MAUI.RenderingEngine.Model.SCFields;

namespace Sitecore.MAUI.Blazor.Sample.APP.Shared
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
