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
    /// The HTML Table Head Element (<see cref="Thead"/>) defines a set of rows defining the head of the columns of the table.
    /// </summary>
    public class Thead : HtmlElement, IChildElements<Tr, Thead>
    {
        public override string Tag => "thead";

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="HtmlElement.ChildElements"/> list.
        /// </summary>
        /// <param name="elements">Child elements</param>
        public Thead Add(params Tr[] elements)
        {
            _childElements.AddRange(elements);
            return this;
        }
    }
}
