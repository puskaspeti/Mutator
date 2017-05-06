/// <reference path="controllers/page-controller.ts" />
/// <reference path="controllers/todo-controller.ts" />
/// <reference path="directives/todoblur.ts" />
/// <reference path="directives/todoescape.ts" />
/// <reference path="directives/todofocus.ts" />
/// <reference path="services/todo-service.ts" />

module Todo {
    export class TodoApp {
        static instance: TodoApp;
        constructor(
            public appModule = angular.module("TodoApp", [])
        ) {

            var components = [
                // Controllers
                PageController,
                TodoController,

                // Directives
                TodoBlurDirective,
                TodoEscapeDirective,
                TodoFocusDirective,

                // Services
                TodoService
            ];

            for (let i = 0; i < components.length; i++)
                components[i].register(appModule);
        }
    }
    TodoApp.instance = new TodoApp();
}