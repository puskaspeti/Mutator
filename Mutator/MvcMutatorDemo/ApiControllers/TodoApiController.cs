using MvcMutatorDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcMutatorDemo.ApiControllers
{
    public class TodoApiController : ApiController
    {
        [HttpGet]
        public List<TodoItem> GetTodos()
        {
            return TodoDbContext.Todos;
        }

        /// <summary>
        /// Adds the new Todo to the database.
        /// </summary>
        /// <param name="todoItem"></param>
        [HttpPost]
        public int AddTodo(TodoItem todoItem)
        {
            todoItem.Id = TodoDbContext.Todos.Count + 1;
            TodoDbContext.Todos.Add(todoItem);
            return todoItem.Id;
        }

        /// <summary>
        /// Updates the todo with the given id.
        /// </summary>
        /// <param name="todoItem"></param>
        [HttpPost]
        public void UpdateTodo(TodoItem todoItem)
        {
            var todo = TodoDbContext.Todos.Single(t => t.Id == todoItem.Id);
            todo.Title = todoItem.Title;
            todo.Completed = todoItem.Completed;
        }

        /// <summary>
        /// Removes the todo with the given id from the database.
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete]
        public void RemoveTodo(int id)
        {
            TodoDbContext.Todos.RemoveAll(t => t.Id == id);
        }

        /// <summary>
        /// Removes the done Todos from the database.
        /// </summary>
        [HttpPost]
        public void ClearDoneTodos()
        {
            TodoDbContext.Todos.RemoveAll(t => t.Completed);
        }

        /// <summary>
        /// Marks all the Todos with the given value.
        /// </summary>
        [HttpPost]
        public void MarkAll(bool isCompleted)
        {
            TodoDbContext.Todos.ForEach(t => t.Completed = isCompleted);
        }
    }
}