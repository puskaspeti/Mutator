using System.Collections.Generic;
using System.Web.Mvc.Html;
using HtmlMutator.Contents;
using HtmlMutator;
using HtmlMutator.MvcMutator;
using MvcMutatorDemo.Models;
using MvcMutatorDemo.Views.Shared;

namespace MvcMutatorDemo.Views.Home
{
    public class TodoListMutatorView : MutatorCollectionModelView<TodoItem>
    {
        public override List<IHtml> CreateDom()
        {
            //Layout = LayoutMutatorView.EmptyLayout;

            var document = new List<IHtml>
            {
                new PhrasingContent(Html.Partial("~/Views/Home/TodoList.cshtml", Model))
            };

            return document;
        }
    }
}