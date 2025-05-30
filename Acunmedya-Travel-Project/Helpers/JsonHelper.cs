using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace Acunmedya_Travel_Project.Helpers
{
    public static class JsonHelper
    {
        public static HtmlString ToJson(this object obj)
        {
            var settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                Formatting = Formatting.None
            };

            return new HtmlString(JsonConvert.SerializeObject(obj, settings));
        }
    }
}
