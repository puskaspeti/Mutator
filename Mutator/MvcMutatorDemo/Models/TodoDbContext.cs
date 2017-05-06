using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MvcMutatorDemo.Models
{
    public static class TodoDbContext
    {
        public static List<User> Users { get; set; }
        public static List<TodoItem> Todos { get; set; }
    }
}