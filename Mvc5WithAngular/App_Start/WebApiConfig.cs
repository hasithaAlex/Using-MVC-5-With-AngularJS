using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Mvc5WithAngular.App_Start
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration configuration)
        {
            configuration.Routes.MapHttpRoute("API Defaults", "api/{controller}/{id}", 
                new { id = RouteParameter.Optional });

            var appXmlType = configuration.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml");
            configuration.Formatters.XmlFormatter.SupportedMediaTypes.Remove(appXmlType);
        }
    }
}