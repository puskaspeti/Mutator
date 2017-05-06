using HtmlMutator.MvcMutator;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace HtmlMutator.MvcMutator
{
    /// <summary>
    /// Mutator controller base class. Contains View methods.
    /// </summary>
    public class MutatorController : Controller
    {
        /// <summary>
        /// Returns <see cref="ActionResult"/> from the HTML based view and <see cref="LayoutMutatorView"/> layout (or without layout). 
        /// Use this method, if you have HTML based view and <see cref="LayoutMutatorView"/> layout.
        /// </summary>
        /// <param name="path">Path of the HTML view</param>
        /// <param name="model">Model of the HTML view</param>
        /// <param name="layout"><see cref="LayoutMutatorView"/> of the HTML view</param>
        /// <returns></returns>
        public ActionResult CshtmlView(string path, object model = null, LayoutMutatorView layout = null)
        {
            var view = new CshtmlViewClass(path, model);

            view.Html = new HtmlHelper(new ViewContext(ControllerContext, new WebFormView(ControllerContext, "mutator"), 
                new ViewDataDictionary(), new TempDataDictionary(), new StringWriter()), new ViewPage());
            view.Url = new UrlHelper(Request.RequestContext);
            view.Controller = this;
            view.ViewBag = ViewBag;
            view.ViewData = ViewData;
            if (layout != null)
            {
                view.Layout = layout;
            }

            return view;
        }

        /// <summary>
        /// Returns the <see cref="ActionResult"/> from the <see cref="MutatorView"/>.
        /// </summary>
        /// <typeparam name="T">Mutator view</typeparam>
        /// <returns>ActionResult from the view</returns>
        public ActionResult View<T>() where T : MutatorView, new()
        {
            return new T
            {
                Html = new HtmlHelper(new ViewContext(ControllerContext, new WebFormView(ControllerContext, "mutator"),
                    new ViewDataDictionary(), new TempDataDictionary(), new StringWriter()), new ViewPage()),
                Url = new UrlHelper(Request.RequestContext),
                Controller = this,
                ViewBag = ViewBag,
                ViewData = ViewData
            };
        }

        /// <summary>
        /// Returns the <see cref="ActionResult"/> from the <see cref="MutatorView"/> with the given model.
        /// </summary>
        /// <typeparam name="T">Mutator view</typeparam>
        /// <typeparam name="TModel">Model of the <see cref="MutatorView"/></typeparam>
        /// <param name="model"></param>
        /// <returns>ActionResult from the view</returns>
        public ActionResult View<T, TModel>(TModel model) where T : MutatorModelView<TModel>, new()
        {
            return new T
            {
                Model = model,
                Html = new HtmlHelper<TModel>(new ViewContext(ControllerContext, new WebFormView(ControllerContext, "mutator"),
                    new ViewDataDictionary(), new TempDataDictionary(), new StringWriter()), new ViewPage()),
                Url = new UrlHelper(Request.RequestContext),
                Controller = this,
                ViewBag = ViewBag,
                ViewData = ViewData
            };
        }

        public ActionResult View<T, TModel>(ICollection<TModel> model) where T : MutatorCollectionModelView<TModel>, new()
        {
            return new T
            {
                Model = model,
                Html = new HtmlHelper<TModel>(new ViewContext(ControllerContext, new WebFormView(ControllerContext, "mutator"),
                    new ViewDataDictionary(), new TempDataDictionary(), new StringWriter()), new ViewPage()),
                Url = new UrlHelper(Request.RequestContext),
                Controller = this,
                ViewBag = ViewBag,
                ViewData = ViewData
            };
        }

        private sealed class CshtmlViewClass : MutatorView
        {
            private string _path;
            private object _model;

            public CshtmlViewClass()
            {

            }

            public CshtmlViewClass(string path, object model)
            {
                _path = path;
                _model = model;
            }

            public override List<IHtml> CreateDom()
            {
                return new List<IHtml>
                {
                    new PhrasingContent(Html.Partial(_path, _model, ViewData))
                };
            }
        }
    }
}
