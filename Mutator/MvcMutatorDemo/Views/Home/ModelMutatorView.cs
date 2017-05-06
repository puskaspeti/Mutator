using System.Collections.Generic;
using System.Web.Mvc.Html;
using HtmlMutator;
using HtmlMutator.MvcMutator;
using MvcMutatorDemo.Models;
using MvcMutatorDemo.Views.Shared;
using HtmlMutator.BootstrapMutator.BootstrapElements;

namespace MvcMutatorDemo.Views.Home
{
    public class ModelMutatorView : MutatorModelView<TodoItem>
    {
        public override List<IHtml> CreateDom()
        {
            Layout = new _Layout();

            var document = new List<IHtml>
            {
                new Row().Add(
                    Html.LabelFor(m => m.Title),
                    Html.TextBoxFor(m => m.Title)
                )
            };

            return document;
        }
    }
}