using HtmlMutator.HtmlElements;
using HtmlMutator.BootstrapMutator;
using HtmlMutator.BootstrapMutator.BootstrapElements;
using System.Web.Mvc;
using HtmlMutator;

namespace MvcMutatorDemo.Models
{
    /// <summary>
    /// Navigation bar of the website
    /// </summary>
    public class Navbar : Nav
    {
        public Navbar(UrlHelper url)
        {
            this.AddClass(Bootstrap.NavbarNav, Bootstrap.NavbarInverse, Bootstrap.NavbarFixedTop);

            Add(new Container().Add(
                new Div { Class = Bootstrap.NavbarHeader }.Add(
                    new A { Class = Bootstrap.NavbarBrand, Href = url.Action("Index", "Home") }.Add("Mutator Demo website")),
                new Div { Id = "navbar" }.AddClass(Bootstrap.Collapse, Bootstrap.NavbarCollapse).Add(
                    new Ul().AddClass(Bootstrap.Nav, Bootstrap.NavbarNav, Bootstrap.NavbarRight).Add(
                        new Li().Add(
                            new A { Href = url.Action("Register", "Account") }.Add("Register")),
                        new Li().Add(
                            new A { Href = url.Action("Login", "Account") }.Add("Login"))
                    ),
                    new Ul().AddClass(Bootstrap.Nav, Bootstrap.NavbarNav).Add(
                        new Li().Add(
                            new A { Href = url.Action("Index", "Home") }.Add("Todo MVC")),
                        new Li().Add(
                            new A { Href = url.Action("TodoList", "Home") }.Add("List Todos")))
                    )
                )
            );
        }
    }
}