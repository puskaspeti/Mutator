using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlMutator;
using HtmlMutator.Contents;
using HtmlMutator.Helpers;
using HtmlMutator.HtmlElements;

namespace HtmlMutator.HtmlElements
{
    /// <summary>
    /// The HTML <see cref="Label"/> element represents a caption for an item in a user interface.
    /// </summary>
    public class Label : InlineHtmlElement, IFlow, IPhrasing, IInteractive, IFormAssociated, IChildElements<IPhrasing, Label>, IChildElements<PhrasingContent, Label>
    {
        public override string Tag => "label";

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="HtmlElement.ChildElements"/> list.
        /// </summary>
        /// <param name="element">Child elements</param>
        public Label Add(params IPhrasing[] elements)
        {
            AddInternal(elements);
            return this;
        }

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="HtmlElement.ChildElements"/> list.
        /// </summary>
        /// <param name="element">Child elements</param>
        public Label Add(params PhrasingContent[] elements)
        {
            AddInternal(elements);
            return this;
        }
    }
}
