using Newtonsoft.Json;

namespace Sitecore.MAUI.Service.Model.SCFields
{
    public class SCComponentBase<T>
    {     
       
    }

    public static class SCComponentBaseExtensions<T>
    {
        public static T SerializeToModel(IDictionary<string, object> dynamicComponentModel)
        {
            return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(dynamicComponentModel));
        }
    }
}
