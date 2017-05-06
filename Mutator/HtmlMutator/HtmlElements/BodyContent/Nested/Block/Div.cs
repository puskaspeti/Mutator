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
    /// The HTML <see cref="Div"/> element (or HTML Document Division Element) is the generic container for flow content, 
    /// which does not inherently represent anything.
    /// </summary>
    public class Div : BlockHtmlElement, IFlow, IPalpable, IChildElements<IFlow, Div>, IChildElements<PhrasingContent, Div>
    {
        public override string Tag => "div";

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="HtmlElement.ChildElements"/> list.
        /// </summary>
        /// <param name="element">Child elements</param>
        public Div Add(params IFlow[] elements)
        {
            AddInternal(elements);
            return this;
        }

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="HtmlElement.ChildElements"/> list.
        /// </summary>
        /// <param name="element">Child elements</param>
        public Div Add(params PhrasingContent[] elements)
        {
            AddInternal(elements);
            return this;
        } 
    }
}
