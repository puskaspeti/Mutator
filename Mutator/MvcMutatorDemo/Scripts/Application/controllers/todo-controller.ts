module Todo {
    export class TodoController {
        static register = (appModule: ng.IModule, name = "TodoController") => appModule.controller(name, ["$scope", "todoService", "filterFilter", TodoController]);

        todos: ITodoItem[];

        newTodo: string;
        editedTodo: ITodoItem;
        originalTodo: ITodoItem;
        remainingCount: number;
        doneCount: number;
        allChecked: boolean;
        reverted: boolean;
        tabIndex: number;

        constructor(private $scope: ng.IScope, private todoService: TodoService, private filterFilter: ng.IFilterFilter) {
            this.newTodo = "";
            this.editedTodo = null;
            this.tabIndex = 0;

            this.$scope.$watch(
                () => this.todos,
                (newValue, oldValue) => {
                    if (newValue)
                        this.onTodos()
                },
                true
            );

            //this.todoService.getTodos().then(response => {
            //    this.todos = response.data;
            //});
        }

        get filteredTodos() {
            return (this.tabIndex == 1) ?
                _.select(this.todos, t => t.completed == false) : (this.tabIndex == 2) ?
                    _.select(this.todos, t => t.completed == true) : this.todos;
        }

        onTodos = () => {
            this.remainingCount = _.select(this.todos, t => !t.completed).length;
            this.doneCount = this.todos.length - this.remainingCount;
            this.allChecked = !this.remainingCount;
        }

        addTodo = () => {
            var newTodo: string = this.newTodo.trim();
            if (!newTodo.length) {
                return;
            }

            let newTodoModel = <ITodoItem>{ title: newTodo, completed: false };

            this.todoService.addTodo(newTodoModel).then(response => {
                newTodoModel.id = response.data;
                this.todos.push(newTodoModel);
                this.newTodo = '';
            })

        }

        editTodo = (todoItem: ITodoItem) => {
            this.editedTodo = todoItem;

            // Clone the original todo in case editing is cancelled.
            this.originalTodo = angular.extend({}, todoItem);
        }

        revertEdits = (todoItem: ITodoItem) => {
            this.todos[this.todos.indexOf(todoItem)] = this.originalTodo;
            this.reverted = true;
        }

        doneEditing = (todoItem: ITodoItem) => {
            this.editedTodo = null;
            this.originalTodo = null;
            if (this.reverted) {
                // Todo edits were reverted, don't save.
                this.reverted = null;
                return;
            }
            todoItem.title = todoItem.title.trim();
            if (!todoItem.title) {
                this.removeTodo(todoItem);
            }
            else
                this.todoService.updateTodo(todoItem);
        }

        removeTodo = (todoItem: ITodoItem) => {
            this.todoService.removeTodo(todoItem.id).then(() => {
                this.todos.splice(this.todos.indexOf(todoItem), 1);
            });
        }

        clearDoneTodos = () => {
            this.todoService.clearDoneTodos().then(() => {
                this.todos = this.todos.filter(todoItem => !todoItem.completed);
            });
        }

        mark = (todoItem: ITodoItem) => {
            this.todoService.updateTodo(todoItem);
        }

        markAll = (completed: boolean) => {
            this.todoService.markAll(completed).then(() => {
                this.todos.forEach(todoItem => { todoItem.completed = completed; });
            });
        }
    }
}