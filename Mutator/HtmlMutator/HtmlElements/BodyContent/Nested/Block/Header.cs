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
    /// The HTML <see cref="Header"/> element represents a group of introductory or navigational aids. 
    /// It may contain some heading elements but also other elements like a logo, a search form, and so on.
    /// </summary>
    public class Header : BlockHtmlElement, IFlow, IPalpable, IChildElements<IFlow, Header>, IChildElements<PhrasingContent, Header>
    {
        public override string Tag => "header";

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="HtmlElement.ChildElements"/> list.
        /// </summary>
        /// <param name="element">Child elements</param>
        public Header Add(params IFlow[] elements)
        {
            AddInternal(elements);
            return this;
        }

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="HtmlElement.ChildElements"/> list.
        /// </summary>
        /// <param name="element">Child elements</param>
        public Header Add(params PhrasingContent[] elements)
        {
            AddInternal(elements);
            return this;
        } 
    }
}
