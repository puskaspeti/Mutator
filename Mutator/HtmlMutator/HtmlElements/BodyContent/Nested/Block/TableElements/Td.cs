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
    /// The Table cell HTML element (<see cref="Td"/>) defines a cell of a table that contains data. It participates in the table model.
    /// </summary>
    public class Td : HtmlElement, ITrContent, IChildElements<IFlow, Td>, IChildElements<PhrasingContent, Td>
    {
        public override string Tag => "td";

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="HtmlElement.ChildElements"/> list.
        /// </summary>
        /// <param name="element">Child elements</param>
        public Td Add(params IFlow[] elements) => AddInternal(elements);

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="HtmlElement.ChildElements"/> list.
        /// </summary>
        /// <param name="element">Child elements</param>
        public Td Add(params PhrasingContent[] elements) => AddInternal(elements);

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="HtmlElement.ChildElements"/> list.
        /// </summary>
        /// <param name="elements">Child elements</param>
        private Td AddInternal(params IHtml[] elements)
        {
            foreach (var element in elements)
                _childElements.Add(element);
                
            return this;
        }
    }
}
