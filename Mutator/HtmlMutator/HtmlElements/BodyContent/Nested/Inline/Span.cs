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
    /// The HTML <see cref="Span"/> element is a generic inline container for phrasing content, which does not inherently represent anything. 
    /// It can be used to group elements for styling purposes (using the class or id attributes), or because they share attribute values, such as lang. 
    /// It should be used only when no other semantic element is appropriate. <see cref="Span"/> is very much like a <see cref="Div"/> element, 
    /// but <see cref="Div"/> is a block-level element whereas a <see cref="Span"/> is an inline element.
    /// </summary>
    public class Span : InlineHtmlElement, IFlow, IPhrasing, IChildElements<IPhrasing, Span>, IChildElements<PhrasingContent, Span>
    {
        public override string Tag => "span";

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="HtmlElement.ChildElements"/> list.
        /// </summary>
        /// <param name="element">Child elements</param>
        public Span Add(params IPhrasing[] elements)
        {
            AddInternal(elements);
            return this;
        }

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="HtmlElement.ChildElements"/> list.
        /// </summary>
        /// <param name="element">Child elements</param>
        public Span Add(params PhrasingContent[] elements)
        {
            AddInternal(elements);
            return this;
        }
    }
}
