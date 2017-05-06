using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcMutatorDemo
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute("API Default", "api/{controller}/{action}/{id}",
            new { id = RouteParameter.Optional });
        }
    }
}
