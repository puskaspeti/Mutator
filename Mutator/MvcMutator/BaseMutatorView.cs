using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using HtmlMutator;
using HtmlMutator.HtmlElements;

namespace HtmlMutator.MvcMutator
{
    /// <summary>
    /// Mutator view base class.
    /// </summary>
    public abstract class BaseMutatorView
    {
        public Controller Controller { get; set; }

        /// <summary>
        /// Supports the rendering of HTML controls in a view.
        /// </summary>
        public HtmlHelper Html { get; set; }

        /// <summary>
        /// Contains methods to build URLs for ASP.NET MVC within an application. 
        /// </summary>
        public UrlHelper Url { get; set; }

        /// <summary>
        /// Viewbag of the Controller base.
        /// </summary>
        public dynamic ViewBag { get; set; }
        public ViewDataDictionary ViewData { get; set; }
    }
}
