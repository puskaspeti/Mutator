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
    /// The HTML element table row <see cref="Tr"/> defines a row of cells in a table. Those can be a mix of <see cref="Td"/> and <see cref="Th"/> elements.
    /// </summary>
    public class Tr : HtmlElement, IChildElements<ITrContent, Tr>
    {
        public override string Tag => "tr";

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="HtmlElement.ChildElements"/> list.
        /// </summary>
        /// <param name="elements">Child elements</param>
        public Tr Add(params ITrContent[] elements)
        {
            _childElements.AddRange(elements);
            return this;
        }
    }
}
