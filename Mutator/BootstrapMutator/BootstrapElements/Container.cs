using HtmlMutator.HtmlElements;
using HtmlMutator.Helpers;

namespace HtmlMutator.BootstrapMutator.BootstrapElements
{
    public class Container : Div
    {
        public Container()
        {
            this.AddClass("container");
        }
    }
}
