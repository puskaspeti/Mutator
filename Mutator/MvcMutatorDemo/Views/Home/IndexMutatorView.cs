using System.Collections.Generic;
using HtmlMutator.Helpers;
using HtmlMutator.Contents;
using HtmlMutator;
using HtmlMutator.HtmlElements;
using HtmlMutator.AngularMutator;
using HtmlMutator.MvcMutator;
using MvcMutatorDemo.Scripts.controllers;
using MvcMutatorDemo.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace MvcMutatorDemo.Views.Home
{
    public class IndexMutatorView : MutatorCollectionModelView<TodoItem>
    {
        public override List<IHtml> CreateDom()
        {
            //Layout = LayoutMutatorView.EmptyLayout;

            // Eltároljuk a gyökérelemet, amin a controller is található
            var rootSection = new Section { Class = "todoapp" }.NgController<Section, TodoController>("todoCtrl");
            // Eltároljuk a konkrét controller-t is
            var todoController = rootSection.GetController<Section, TodoController>();

            var document = new List<IHtml>
            {
                rootSection.NgInit(t => todoController.Todos, JsonConvert.SerializeObject(Model, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() })).Add(
                    new Header().AddClass("header").Add(
                            new H1().Add("todos"),
                            new Form { Class = "todo-form", Parent = rootSection }
                            .NgSubmit(t => todoController.AddTodo()).Add(
                                new Input { Class="new-todo", ["placeholder"]="What needs to be done?", ["autofocus"]="", Parent = rootSection }.NgModel(t => todoController.NewTodo))
                    ),
                    
                    new Section { Class = "main", Parent = rootSection }.NgShow($"{todoController.Todos}.length").NgCloak().Add(
                        new Input { Class = "toggle-all", Type = InputTypeOptions.Checkbox, Parent = rootSection }
                        .NgModel(t => todoController.AllChecked)
                        .NgClick(t => todoController.MarkAll(todoController.AllChecked)),
                        new Label { ["for"]="toggle-all" }.Add("Mark all as complete"),
                        
                        new Ul().AddClass("todo-list").Add(
                            new Li { Parent = rootSection }
                            .NgRepeat(t => todoController.FilteredTodos, "todo", "$index")
                            .NgClass($"{{completed: todo.completed, editing: todo == {todoController.EditedTodo}}}").Add(
                                new Div { Class="view" }.Add(
                                    new Input { Class="toggle", Type=InputTypeOptions.Checkbox }.NgModel("todo.completed").NgClick(t => todoController.Mark("todo")),
                                    new Label { Parent = rootSection }.NgDblClick(t => todoController.EditTodo("todo")).Add("{{todo.title}}"),
                                    new Button { Class="destroy", Parent = rootSection }.NgClick(t => todoController.RemoveTodo("todo"))
                                ),
                                new Form { Parent = rootSection }.NgSubmit(t => todoController.DoneEditing("todo"))
                                    .Add(new Input { Class = "edit",
                                        ["todo-blur"] = todoController.DoneEditing("todo"),
                                        ["todo-focus"] = $"todo === {todoController.EditedTodo}",
                                        ["todo-escape"]= todoController.RevertEdits("todo")
                                    }.NgModel("todo.title"))
                                )
                            )
                    ),
                    new Footer { Class="footer" }.NgShow($"{todoController.Todos}.length").NgCloak().Add(
                        new Span { Class="todo-count" }.Add(
                            new Strong().Add($"{{{{ { todoController.RemainingCount } }}}}"),
                            new Span { ["ng-pluralize"]="", ["count"]=todoController.RemainingCount, ["when"]="{ one: ' item left', other: ' items left' }" })
                        )
                        .Add(new Ul { Class="filters" }.Add(
                            new Li().Add(
                                new A { Href="" }.NgClass($"{{selected: {todoController.TabIndex}==0}}").NgClick($"{todoController.TabIndex} = 0").Add("All")),
                            new Li().Add(
                                new A { Href="" }.NgClass($"{{selected: {todoController.TabIndex}==1}}").NgClick($"{todoController.TabIndex} = 1").Add("Active")),
                            new Li().Add(
                                new A { Href="" }.NgClass($"{{selected: {todoController.TabIndex}==2}}").NgClick($"{todoController.TabIndex} = 2").Add("Completed")))
                        )
                        .Add(new Button { Class="clear-completed", Parent = rootSection }.NgClick(t => todoController.ClearDoneTodos()).NgShow(todoController.DoneCount).Add("Clear completed"))
                    ),
                new Footer().AddClass("info").Add(
                    new P().Add("Double-click to edit todo"),
                    new P().Add("Credit: ").Add(
                        new A { Href="" }.Add("Péter Puskás"))
                )
            };

            return document;
        }
    }
}