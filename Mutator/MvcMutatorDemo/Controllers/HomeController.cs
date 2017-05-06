using System.Linq;
using System.Web.Mvc;
using HtmlMutator.MvcMutator;
using MvcMutatorDemo.Models;
using MvcMutatorDemo.Views.Home;

namespace MvcMutatorDemo.Controllers
{
    public class HomeController : MutatorController
    {
        public ActionResult Index()
        {
            var todos = TodoDbContext.Todos.ToList();
            return View<IndexMutatorView, TodoItem>(todos);
        }

        public ActionResult Test() => View<Test>();
        public ActionResult Test2() => View<Test2>();

        public ActionResult TodoList()
        {
            var todos = TodoDbContext.Todos.ToList();
            return View<TodoListMutatorView, TodoItem>(todos);
        }
    }
}