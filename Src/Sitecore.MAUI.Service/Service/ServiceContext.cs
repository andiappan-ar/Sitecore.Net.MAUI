using Newtonsoft.Json;
using Sitecore.MAUI.Service.Model;

namespace Sitecore.MAUI.Service.Service
{
    public class ServiceContext
    {
        /// <summary>
        /// GetSitecoreContext : Consume sitecore headless service and return sitecore context
        /// </summary>
        /// <returns>SitecoreContext</returns>
        public SitecoreContext GetSitecoreContext()
        {
            SitecoreContext result = new SitecoreContext();
            string url = "http://a-custom-route.com/sitecore/api/layout/render/jss?item=/&sc_lang=en&sc_apikey=%7B20CC82CD-F3EA-4905-85AA-44CDEE3B5F0A%7D";
            try
            {
                HttpClient client = new HttpClient();

                HttpResponseMessage messge = client.GetAsync(url).Result;
                string description = string.Empty;
                if (messge.IsSuccessStatusCode)
                {
                    string resultResponse = messge.Content.ReadAsStringAsync().Result;
                    result = JsonConvert.DeserializeObject<SitecoreContext>(resultResponse);

                    foreach (var _placeholders in result.sitecore.route.placeholders)
                    {
                        
                        foreach (var _placeholdersList in _placeholders.Value)
                        {
                            _placeholdersList.componentType = Type.GetType("Sitecore.MAUI.Client.Shared." + _placeholdersList.componentName);

                            //foreach (var _placeholdersListField in _placeholdersList.fields)
                            //{
                            //    _placeholdersList.Parameters.Add(_placeholdersListField.Key, _placeholdersListField.Value.ToString());
                            //}
                               
                        }
                    }

                }

            
            }
            catch(Exception ex)
            {
                result = null;
            }

            return result;
        }

public async Task<DynamicComponentRoot> GetComponentJson()
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
    }
}
