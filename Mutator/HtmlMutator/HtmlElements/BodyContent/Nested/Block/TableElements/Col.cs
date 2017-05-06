using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlMutator.Helpers;
using HtmlMutator.HtmlElements;

namespace HtmlMutator.HtmlElements
{
    /// <summary>
    /// The HTML Table Column Element (<see cref="Col"/>) defines a column within a table and is used for defining common semantics on all common cells. 
    /// It is generally found within a <see cref="Colgroup"/> element.
    /// </summary>
    public class Col : EmptyHtmlElement
    {
        public override string Tag => "col";
    }
}
