using Newtonsoft.Json;
using Sitecore.MAUI.RenderingEngine.Model;

namespace Sitecore.MAUI.RenderingEngine.Service
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
        public static async Task<SitecoreContext> GetSitecoreContext()
        {
            SitecoreContext result = new SitecoreContext();
            string url = ServiceSettings.AppSettings.GetSitecoreHeadlessServiceUrl(ServiceSettings.AppSettings);
            try
            {
                HttpClientHandler clientHandler = new HttpClientHandler();
                clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

                HttpClient client = new HttpClient(clientHandler);

                var messge = await client.GetStringAsync(url);
                string description = string.Empty;
                if (!string.IsNullOrEmpty(messge))
                {
                    //string resultResponse = messge.Content.ReadAsStringAsync().Result;
                    result = JsonConvert.DeserializeObject<SitecoreContext>(messge);
                }
            }
            catch (Exception ex)
            {
                throw ex;
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
            var result = new Dictionary<string, object>() { { ServiceSettings.AppSettings.Key_DynamicComponentModel, fields } };
            return result;
        }
    }
}
