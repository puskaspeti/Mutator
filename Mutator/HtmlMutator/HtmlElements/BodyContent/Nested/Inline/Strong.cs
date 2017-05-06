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
    /// he HTML <see="Strong"> element gives text strong importance, and is typically displayed in bold.
    /// </summary>
    public class Strong : InlineHtmlElement, IFlow, IPhrasing, IPalpable, IChildElements<IPhrasing, Strong>, IChildElements<PhrasingContent, Strong>
    {
        public override string Tag => "strong";

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="HtmlElement.ChildElements"/> list.
        /// </summary>
        /// <param name="element">Child elements</param>
        public Strong Add(params IPhrasing[] elements)
        {
            AddInternal(elements);
            return this;
        }

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="HtmlElement.ChildElements"/> list.
        /// </summary>
        /// <param name="element">Child elements</param>
        public Strong Add(params PhrasingContent[] elements)
        {
            AddInternal(elements);
            return this;
        }
    }
}
