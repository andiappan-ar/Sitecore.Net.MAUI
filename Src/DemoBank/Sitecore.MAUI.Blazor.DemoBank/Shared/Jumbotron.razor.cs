﻿using Microsoft.AspNetCore.Components;
using Sitecore.MAUI.Blazor.DemoBank.Models.ViewModel;
using Sitecore.MAUI.RenderingEngine.Model.SCFields;

namespace Sitecore.MAUI.Blazor.DemoBank.Shared
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
