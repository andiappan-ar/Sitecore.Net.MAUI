using Newtonsoft.Json;
using Sitecore.MAUI.Service.Model;

namespace Sitecore.MAUI.Service.Service
{
    public static class ServiceContext
    {
        public static string ContextUrlPath = "/";

        public static void SetContextUrlPath(string path)
        {
            ContextUrlPath = path;
        }

        /// <summary>
        /// GetSitecoreContext : Consume sitecore headless service and return sitecore context
        /// </summary>
        /// <returns>SitecoreContext</returns>
        public static SitecoreContext GetSitecoreContext()
        {
            SitecoreContext result = new SitecoreContext();
            string url = ServiceSettings.SitecoreHeadlessServiceUrl;
            try
            {
                HttpClient client = new HttpClient();

                HttpResponseMessage messge = client.GetAsync(url).Result;
                string description = string.Empty;
                if (messge.IsSuccessStatusCode)
                {
                    string resultResponse = messge.Content.ReadAsStringAsync().Result;
                    result = JsonConvert.DeserializeObject<SitecoreContext>(resultResponse);
                }
            }
            catch (Exception ex)
            {
                result = null;
            }

            return result;
        }

        public static async Task<DynamicComponentRoot> GetComponentJson()
        {

            DynamicComponentRoot result = null;
            JsonRoot resultJson = null;

            try
            {
                HttpClient client = new HttpClient();


                string description = string.Empty;
                var sitecoreLayoutContext = GetSitecoreContext();

                if (sitecoreLayoutContext != null)
                {
                    string resultResponse = await File.ReadAllTextAsync(@"C:\ARC\jss\MAUI\GIT-Sitecore.Net.MAUI\Src\Sitecore.Net.MAUI.Blazor.Client\wwwroot\data.json");
                    resultJson = JsonConvert.DeserializeObject<JsonRoot>(resultResponse);

                    foreach (var _placeholders in sitecoreLayoutContext.sitecore.route.placeholders)
                    {
                        foreach (var _placeholdersList in _placeholders.Value)
                        {

                        }

                    }

                    if (resultJson != null && resultJson.componenets != null)
                    {
                        result = new DynamicComponentRoot() { componenets = new List<DynamicComponentModel>() };

                        foreach (var _component in resultJson.componenets)
                        {
                            DynamicComponentModel _dynamicComponentModel = new DynamicComponentModel()
                            {
                                ComponentType = _component.component
                            };

                            _dynamicComponentModel.Parameters = _component.Parameters;

                            result.componenets.Add(_dynamicComponentModel);
                        }
                    }
                }



            }
            catch (Exception ex)
            {
                result = null;
            }

            return result;
        }

        public static IDictionary<string, object> GetDynamicComponentModel(IDictionary<string, object> fields)
        {
            var result = new Dictionary<string, object>() { { ServiceSettings.Key_DynamicComponentModel, fields } };
            return result;
        }
    }
}
