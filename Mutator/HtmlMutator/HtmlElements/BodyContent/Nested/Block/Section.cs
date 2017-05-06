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
    /// The HTML <see cref="Section"/> element represents a generic section of a document, i.e., a thematic grouping of content, typically with a heading.
    /// </summary>
    public class Section : BlockHtmlElement, ISectioning, IFlow, IPalpable, IChildElements<IFlow, Section>, IChildElements<PhrasingContent, Section>
    {
        public override string Tag => "section";

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="HtmlElement.ChildElements"/> list.
        /// </summary>
        /// <param name="element">Child elements</param>
        public Section Add(params IFlow[] elements)
        {
            AddInternal(elements);
            return this;
        }

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="HtmlElement.ChildElements"/> list.
        /// </summary>
        /// <param name="element">Child elements</param>
        public Section Add(params PhrasingContent[] elements)
        {
            AddInternal(elements);
            return this;
        } 
    }
}
