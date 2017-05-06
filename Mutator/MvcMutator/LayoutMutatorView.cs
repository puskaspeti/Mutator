using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using HtmlMutator;
using HtmlMutator.HtmlElements;

namespace HtmlMutator.MvcMutator
{
    /// <summary>
    /// Mutator layout view class with <see cref="Document"/> and <see cref="Body"/>.
    /// </summary>
    public abstract class LayoutMutatorView : BaseMutatorView
    {
        /// <summary>
        /// Sets an empty layout for the view.
        /// </summary>
        public static readonly LayoutMutatorView EmptyLayout = new EmptyLayoutView();

        /// <summary>
        /// The DOM of the view.
        /// </summary>
        private IHtml Document { get; set; }

        /// <summary>
        /// Rendered body of the view.
        /// </summary>
        private MvcHtmlString Body { get; set; }

        /// <summary>
        /// Returns the rendered body.
        /// </summary>
        /// <returns>Rendered body</returns>
        public MvcHtmlString RenderBody() => Body;

        /// <summary>
        /// Renders the document layout and the body.
        /// </summary>
        /// <param name="body">Body content</param>
        /// <returns>Rendered HTML string.</returns>
        public MvcHtmlString Render(MvcHtmlString body)
        {
            Body = body;
            Document = CreateDom();
            return Document.Render();
        }

        /// <summary>
        /// Creates the DOM, and returns the current view.
        /// </summary>
        public abstract IHtml CreateDom();
    }

    internal sealed class EmptyLayoutView : LayoutMutatorView
    {
        public override IHtml CreateDom()
        {
            return new PhrasingContent(RenderBody());
        }
    }
}
