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
    /// The HTML Table Body Element (<see cref="Tbody"/>) defines one or more <see cref="Tr"/> element data-rows to be the body of its parent <see cref="Table"/> element 
    /// (as long as no <see cref="Tr"/> elements are immediate children of that table element.)
    /// </summary>
    public class Tbody : HtmlElement, IChildElements<Tr, Tbody>
    {
        public override string Tag => "tbody";

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="HtmlElement.ChildElements"/> list.
        /// </summary>
        /// <param name="elements">Child elements</param>
        public Tbody Add(params Tr[] elements)
        {
            _childElements.AddRange(elements);
            return this;
        }
    }
}
