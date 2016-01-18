using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace EfTestWebApi
{
    using EfTestWebApi.App_Start;

    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //var json = config.Formatters.JsonFormatter;
            //json.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.None; 
            //// returns 500 error if "None", returns unwanted data and format if "Objects"
            //config.Formatters.Remove(config.Formatters.XmlFormatter);

            //GlobalConfiguration.Configuration.Formatters.Clear();
            //GlobalConfiguration.Configuration.Formatters.Add(json);
        }
    }
}
