module Todo {
    export class TodoService {
        static register(angularModule: ng.IModule, name = "todoService"): void {
            angularModule.service(name, ["$http", TodoService]);
        }

        constructor(private $http: ng.IHttpService) { }

        getTodos = () => this.$http.get<ITodoItem[]>("api/todoapi/GetTodos");
        addTodo = (todoItem: ITodoItem) => this.$http.post<number>("api/todoapi/AddTodo", todoItem);
        updateTodo = (todoItem: ITodoItem) => this.$http.post<void>("api/todoapi/UpdateTodo", todoItem);
        removeTodo = (id: number) => this.$http.delete<void>("api/todoapi/RemoveTodo", { params: { id } });
        clearDoneTodos = () => this.$http.post<void>("api/todoapi/ClearDoneTodos", null);
        markAll = (isCompleted: boolean) => this.$http.post<void>("api/todoapi/MarkAll", null, { params: { isCompleted } });
    }
}