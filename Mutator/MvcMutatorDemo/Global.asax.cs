using MvcMutatorDemo.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MvcMutatorDemo
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public Stopwatch Stopwatch { get; set; }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var formatters = GlobalConfiguration.Configuration.Formatters;
            var jsonFormatter = formatters.JsonFormatter;
            var settings = jsonFormatter.SerializerSettings;
            settings.Formatting = Formatting.Indented;
            settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            Stopwatch = Stopwatch.StartNew();
        }

        protected void Application_EndRequest(object sender, EventArgs e)
        {
            Stopwatch.Stop();
            var elapsed = Stopwatch.ElapsedMilliseconds;

            //using (var aFile = new FileStream("C:\\Users\\puska\\Desktop\\Meresek\\mutator.txt", FileMode.Append, FileAccess.Write))
            //using (StreamWriter sw = new StreamWriter(aFile))
            //{
            //    sw.WriteLine(elapsed);
            //}
        }
    }
}
