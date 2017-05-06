using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlMutator;
using HtmlMutator.Contents;

namespace HtmlMutator.HtmlElements
{
    /// <summary>
    /// The HTML <see cref="Caption"/> Element (or HTML Table Caption Element) represents the title of a table.
    /// </summary>
    public class Caption : HtmlElement, IChildElements<PhrasingContent, Caption>
    {
        public override string Tag => "caption";

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="HtmlElement.ChildElements"/> list.
        /// </summary>
        /// <param name="elements">Child elements</param>
        public Caption Add(params PhrasingContent[] elements)
        {
            _childElements.AddRange(elements);
            return this;
        }
    }
}
