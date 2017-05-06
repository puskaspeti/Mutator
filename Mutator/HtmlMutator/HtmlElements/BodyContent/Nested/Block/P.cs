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
    /// The HTML <see cref="P"/> element represents a paragraph of text. 
    /// Paragraphs are usually represented in visual media as blocks of text that are separated 
    /// from adjacent blocks by vertical blank space and/or first-line indentation.
    /// </summary>
    public class P : BlockHtmlElement, IFlow, IChildElements<IPhrasing, P>, IChildElements<PhrasingContent, P>
    {
        public override string Tag => "p";

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="HtmlElement.ChildElements"/> list.
        /// </summary>
        /// <param name="element">Child elements</param>
        public P Add(params IPhrasing[] elements)
        {
            AddInternal(elements);
            return this;
        }

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="HtmlElement.ChildElements"/> list.
        /// </summary>
        /// <param name="element">Child elements</param>
        public P Add(params PhrasingContent[] elements)
        {
            AddInternal(elements);
            return this;
        }
    }
}
