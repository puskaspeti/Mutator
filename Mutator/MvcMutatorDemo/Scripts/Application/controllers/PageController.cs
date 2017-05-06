using HtmlMutator.AngularMutator.NgElements;

namespace MvcMutatorDemo.Scripts.controllers
{
    public class PageController : NgController
    {
        #region Init
        public PageController() : base("PageController", null) { }
        public PageController(string alias = null) : base("PageController", alias) { }

        public string Name => ControllerAlias != null ? $"{ControllerAlias}" : "";

        private string _domName => Name != string.Empty ? $"{Name}." : Name;
        #endregion

        public string TabIndex => $"{_domName}tabIndex";
    }
}