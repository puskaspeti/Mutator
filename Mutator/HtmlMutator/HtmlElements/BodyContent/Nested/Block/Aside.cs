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
    /// The HTML <see cref="Aside"/> element represents a section of a document with content connected tangentially to the main content of the document (often presented as a sidebar).
    /// </summary>
    public class Aside : BlockHtmlElement, ISectioning, IFlow, IPalpable, IChildElements<IFlow, Aside>, IChildElements<PhrasingContent, Aside>
    {
        public override string Tag => "aside";

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="HtmlElement.ChildElements"/> list.
        /// </summary>
        /// <param name="elements">Child elements</param>
        public Aside Add(params IFlow[] elements)
        {
            AddInternal(elements);
            return this;
        }

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="HtmlElement.ChildElements"/> list.
        /// </summary>
        /// <param name="elements">Child elements</param>
        public Aside Add(params PhrasingContent[] elements)
        {
            AddInternal(elements);
            return this;
        } 
    }
}
