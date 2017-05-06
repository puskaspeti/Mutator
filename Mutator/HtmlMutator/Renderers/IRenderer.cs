using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using HtmlMutator;
using HtmlMutator.HtmlElements;

namespace HtmlMutator.Renderers
{
    /// <summary>
    /// Renderer interface for the HTML Mutator.
    /// Different implementations of the Render method can result different formatted HTML string with the same conent.  
    /// </summary>
    public interface IRenderer
    {
        /// <summary>
        /// Renders the HTML element
        /// </summary>
        /// <param name="element">Randerable HTML element</param>
        /// <returns>Rendered HTML element</returns>
        MvcHtmlString Render(IHtml element);
    }
}
