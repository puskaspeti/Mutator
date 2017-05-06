using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using HtmlMutator;
using HtmlMutator.HtmlElements;
using System.Web.Mvc.Html;

namespace HtmlMutator.MvcMutator
{
    /// <summary>
    /// Mutator view class with <see cref="Document"/> and optional <see cref="Layout"/>.
    /// </summary>
    public abstract class MutatorView : BaseMutatorView
    {
        /// <summary>
        /// Optional layout view.
        /// </summary>
        public LayoutMutatorView Layout { get; set; }

        /// <summary>
        /// The DOM of the view.
        /// </summary>
        private List<IHtml> Document { get; set; }

        /// <summary>
        /// Mutator view with <see cref="HtmlHelper"/> and <see cref="UrlHelper"/>.
        /// Creates the <see cref="Document"/> list to create the view.
        /// </summary>
        protected MutatorView()
        {
            Document = new List<IHtml>();
        }

        /// <summary>
        /// Renders the <see cref="Document"/> element.
        /// </summary>
        /// <returns>Rendered MVC HTML string</returns>
        public MvcHtmlString Render()
        {
            Document = CreateDom();
            var sb = new StringBuilder();
            Document.ForEach(element => sb.Append(element.Render()));
            var documentHtmlString = new MvcHtmlString(sb.ToString());

            if(Layout == null && MutatorStartPage.Layout != null)
            {
                Layout = MutatorStartPage.Layout;
            }

            if (Layout != null)
            {
                Layout.Html = Html;
                Layout.Url = Url;
                Layout.Controller = Controller;
                return Layout.Render(documentHtmlString);
            }

            return documentHtmlString;
        }

        /// <summary>
        /// Renders the specified partial view as an HTML-encoded string.
        /// </summary>
        /// <param name="partialViewName">The name of the partial view to render.</param>
        /// <returns>The partial view that is rendered as an HTML-encoded string.</returns>
        private MvcHtmlString Partial(string partialViewName) => Html.Partial(partialViewName);

        /// <summary>
        /// Renders the specified partial mutator view as an HTML-encoded string.
        /// </summary>
        /// <param name="mutatorView">The partial mutator view.</param>
        /// <returns>The partial mutator view that is rendered as an HTML-encoded string.</returns>
        private MvcHtmlString Partial(MutatorView mutatorView)
        {
            mutatorView.Html = Html;
            mutatorView.Url = Url;
            mutatorView.Controller = Controller;
            return mutatorView.Render();
        }

        /// <summary>
        /// Creates the DOM, and returns the current view.
        /// </summary>
        public abstract List<IHtml> CreateDom();

        /// <summary>
        /// Implicit operator to create from <see cref="MutatorView"/> to <see cref="MutatorActionResult"/>.
        /// </summary>
        /// <param name="mutatorView"></param>
        public static implicit operator MutatorActionResult(MutatorView mutatorView) => new MutatorActionResult(mutatorView);
    }

    /// <summary>
    /// Mutator view base class with the given model.
    /// </summary>
    /// <typeparam name="TModel">Model of the view</typeparam>
    public abstract class MutatorModelView<TModel> : MutatorView
    {
        /// <summary>
        /// Supports the rendering of HTML controls in a view.
        /// </summary>
        public new HtmlHelper<TModel> Html { get; set; }

        /// <summary>
        /// Model of the <see cref="MutatorView"/>.
        /// </summary>
        public TModel Model { get; set; }
    }

    /// <summary>
    /// Mutator view base class with the given model collection.
    /// </summary>
    /// <typeparam name="TModel">Model of the view</typeparam>
    public abstract class MutatorCollectionModelView<TModel> : MutatorView
    {
        /// <summary>
        /// Supports the rendering of HTML controls in a view.
        /// </summary>
        public new HtmlHelper<TModel> Html { get; set; }

        /// <summary>
        /// Model of the <see cref="MutatorView"/>.
        /// </summary>
        public ICollection<TModel> Model { get; set; }
    }
}
