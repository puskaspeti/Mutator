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
    /// The HTML <see cref="Footer"/> element represents a footer for its nearest sectioning content or sectioning root element.
    /// </summary>
    public class Footer : BlockHtmlElement, IFlow, IPalpable, IChildElements<IFlow, Footer>, IChildElements<PhrasingContent, Footer>
    {
        public override string Tag => "footer";

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="HtmlElement.ChildElements"/> list.
        /// </summary>
        /// <param name="element">Child elements</param>
        public Footer Add(params IFlow[] elements)
        {
            AddInternal(elements);
            return this;
        }

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="HtmlElement.ChildElements"/> list.
        /// </summary>
        /// <param name="element">Child elements</param>
        public Footer Add(params PhrasingContent[] elements)
        {
            AddInternal(elements);
            return this;
        } 
    }
}
