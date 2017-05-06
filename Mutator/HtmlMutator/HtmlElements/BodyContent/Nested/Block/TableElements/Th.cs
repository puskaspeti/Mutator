using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlMutator;
using HtmlMutator.Contents;
using HtmlMutator.Helpers;

namespace HtmlMutator.HtmlElements
{
    /// <summary>
    /// The HTML element table header cell <see cref="Th"/> defines a cell as header of a group of table cells. 
    /// The exact nature of this group is defined by the scope and headers attributes.
    /// </summary>
    public class Th : HtmlElement, ITrContent, IChildElements<IPhrasing, Th>, IChildElements<PhrasingContent, Th>
    {
        public override string Tag => "th";

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="HtmlElement.ChildElements"/> list.
        /// </summary>
        /// <param name="elements">Child elements</param>
        public Th Add(params IPhrasing[] elements) => AddInternal(elements);

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="HtmlElement.ChildElements"/> list.
        /// </summary>
        /// <param name="elements">Child elements</param>
        public Th Add(params PhrasingContent[] elements) => AddInternal(elements);

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="HtmlElement.ChildElements"/> list.
        /// </summary>
        /// <param name="elements">Child elements</param>
        private Th AddInternal(params IHtml[] elements)
        {
            _childElements.AddRange(elements);
            return this;
        }
    }
}
