using System.Collections.Generic;
using Microsoft.Owin;
using MvcMutatorDemo.Models;
using Owin;
using HtmlMutator.MvcMutator;
using MvcMutatorDemo.Views.Shared;

[assembly: OwinStartupAttribute(typeof(MvcMutatorDemo.Startup))]
namespace MvcMutatorDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            // Set the default layout for the website.
            MutatorStartPage.Layout = new _Layout();

            TodoDbContext.Users = new List<User>();
            TodoDbContext.Todos = new List<TodoItem> {
                new TodoItem {Id = 1, Completed = false, Title = "Todo 1"},
                //new TodoItem {Id = 2, Completed = true, Title = "Todo 2"},
                //new TodoItem {Id = 3, Completed = false, Title = "Todo 3"},
            };
        }
    }
}
