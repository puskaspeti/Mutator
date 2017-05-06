using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace HtmlMutator.MvcMutator
{
    /// <summary>
    /// Extension methods for the HTML helper.
    /// </summary>
    public static class HtmlExtensions
    {
        /// <summary>
        /// Renders the specified partial mutator view as an HTML-encoded string.
        /// </summary>
        /// <param name="html">The HTML helper instance that this method extends.</param>
        /// <param name="mutatorView">The partial mutator view.</param>
        /// <param name="url">Url helper</param>
        /// <returns>The partial mutator view that is rendered as an HTML-encoded string.</returns>
        public static MvcHtmlString Partial(this HtmlHelper html, MutatorView mutatorView, UrlHelper url)
        {
            mutatorView.Html = html;
            mutatorView.Url = url;
            return mutatorView.Render();
        }

        public static MvcHtmlString Partial<TModel>(this HtmlHelper html, MutatorModelView<TModel> mutatorView, TModel model, UrlHelper url)
        {
            mutatorView.Url = url;
            mutatorView.Model = model;
            return mutatorView.Render();
        }
    }
}
