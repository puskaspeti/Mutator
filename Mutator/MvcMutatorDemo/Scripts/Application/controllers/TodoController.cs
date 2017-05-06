using HtmlMutator.AngularMutator.NgElements;

namespace MvcMutatorDemo.Scripts.controllers
{
    public class TodoController : NgController
    {
        #region Init
        public TodoController() : base("TodoController", null) { }
        public TodoController(string alias = null) : base("TodoController", alias) { }

        public string Name => ControllerAlias != null ? $"{ControllerAlias}" : "";

        private string _domName => Name != string.Empty ? $"{Name}." : Name;
        #endregion

        public string Todos => $"{_domName}todos";
        public string FilteredTodos => $"{_domName}filteredTodos";
        public string NewTodo => $"{_domName}newTodo";
        public string EditedTodo => $"{_domName}editedTodo";
        public string OriginalTodo => $"{_domName}originalTodo";
        public string RemainingCount => $"{_domName}remainingCount";
        public string DoneCount => $"{_domName}doneCount";
        public string AllChecked => $"{_domName}allChecked";
        public string Reverted => $"{_domName}reverted";
        public string TabIndex => $"{_domName}tabIndex";


        public string OnTabindex() => $"{_domName}onTabindex()";
        public string OnTodos() => $"{_domName}onTodos()";
        public string AddTodo() => $"{_domName}addTodo()";
        public string EditTodo(string todoItem) => $"{_domName}editTodo({todoItem})";
        public string RevertEdits(string todoItem) => $"{_domName}revertEdits({todoItem})";
        public string DoneEditing(string todoItem) => $"{_domName}doneEditing({todoItem})";
        public string RemoveTodo(string todoItem) => $"{_domName}removeTodo({todoItem})";
        public string ClearDoneTodos() => $"{_domName}clearDoneTodos()";
        public string Mark(string todo) => $"{_domName}mark({todo})";
        public string MarkAll(string completed) => $"{_domName}markAll({completed})";
    }
}