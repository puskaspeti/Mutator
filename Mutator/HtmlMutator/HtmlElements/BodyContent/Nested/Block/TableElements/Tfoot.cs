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
    /// The HTML Table Foot Element (<see cref="Tfoot"/>) defines a set of rows summarizing the columns of the table.
    /// </summary>
    public class Tfoot : HtmlElement, IChildElements<Tr, Tfoot>
    {
        public override string Tag => "tfoot";

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="HtmlElement.ChildElements"/> list.
        /// </summary>
        /// <param name="elements">Child elements</param>
        public Tfoot Add(params Tr[] elements)
        {
            _childElements.AddRange(elements);
            return this;
        }
    }
}
