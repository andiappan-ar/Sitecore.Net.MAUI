using Newtonsoft.Json;
using Sitecore.MAUI.RenderingEngine.Model;
using Sitecore.MAUI.RenderingEngine.Model.SCFields;

namespace Sitecore.MAUI.RenderingEngine.Service
{
    public static class ServiceContext
    {
        ////TODO:Override
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
                throw;
            }

            return result;
        }

        public static IDictionary<string, object> GetDynamicComponentModel(IDictionary<string, object> fields)
        {
            var result = new Dictionary<string, object>() { { ServiceSettings.AppSettings.Key_DynamicComponentModel, fields } };
            return result;
        }

        public static List<JsonRendering> GetComponent(SitecoreContext sitecoreContext, string placeholderKey, string componentName)
        {
            List<JsonRendering> results = null;

            try
            {
                if(!string.IsNullOrEmpty(placeholderKey) && !string.IsNullOrEmpty(componentName))
                {
                    
                    var dynamicComponent = sitecoreContext.sitecore.route.placeholders.Where(x => x.Key == placeholderKey)?.FirstOrDefault()
                        .Value?.Where(x=>x.componentName == componentName);
                    if (dynamicComponent != null)
                    {
                        results = new List<JsonRendering>();
                        foreach (var item in dynamicComponent)
                        {
                            results.Add(item);
                        }
                    }
                    
                    
                }
                
                
                
            }
            catch(Exception ex)
            {
                throw;
            }

            return results;

        }
    }
}
