using Newtonsoft.Json;
using Sitecore.MAUI.Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore.MAUI.Service.Service
{
    public static class ServiceContext
    {
        /// <summary>
        /// GetSitecoreContext : Consume sitecore headless service and return sitecore context
        /// </summary>
        /// <returns>SitecoreContext</returns>
        public static SitecoreContext GetSitecoreContext()
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
                }
            }
            catch(Exception ex)
            {
                result = null;
            }

            return result;
        }
    }
}
