using HtmlMutator.HtmlElements;
using HtmlMutator;
using HtmlMutator.MvcMutator;
using HtmlMutator.AngularMutator;
using MvcMutatorDemo.Models;

namespace MvcMutatorDemo.Views.Shared
{
    public class _Layout : LayoutMutatorView
    {
        public override IHtml CreateDom()
        {
            var document = new Html
            {
                Head = new Head { Title = "TODO MVC - MUTATOR" }.Add(
                    // Scripts
                    new Script { Src = "~/Scripts/Application/libs/angular-1.6.1/angular.js", Type = "text/javascript" },
                    new Script { Src = "~/Scripts/Application/libs/underscore-1.8.3/underscore-1.8.3.js", Type = "text/javascript" },
                    new Script { Src = "~/Scripts/todomvc.js", Type = "text/javascript" },

                    // Styles
                    new Link { Href = "~/Content/bootstrap.css", Rel = "stylesheet" },
                    new Link { Href = "~/Content/base.css", Rel = "stylesheet" },
                    new Link { Href = "~/Content/index.css", Rel = "stylesheet" }
                ),

                Body = new Body().NgApp("TodoApp").Add(
                    new Navbar(Url))
                    .Add(RenderBody())
            };

            return document;
        }
    }
}