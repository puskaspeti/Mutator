using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlMutator;
using HtmlMutator.Helpers;

namespace HtmlMutator.HtmlElements
{
    /// <summary>
    /// The HTML Table Column Group Element (<see cref="Colgroup"/>) defines a group of columns within a table.
    /// </summary>
    public class Colgroup : HtmlElement, IChildElements<Col, Colgroup>
    {
        public override string Tag => "colgroup";

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="HtmlElement.ChildElements"/> list.
        /// </summary>
        /// <param name="elements">Child elements</param>
        public Colgroup Add(params Col[] elements)
        {
            _childElements.AddRange(elements);
            return this;
        }
    }
}
