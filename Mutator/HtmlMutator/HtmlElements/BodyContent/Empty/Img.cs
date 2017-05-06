using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using HtmlMutator;
using HtmlMutator.Helpers;
using HtmlMutator.HtmlElements;

namespace HtmlMutator.HtmlElements
{
    /// <summary>
    /// The HTML <see cref="Img"/> element represents an image in the document.
    /// </summary>
    public class Img : EmptyHtmlElement, IFlow, IPhrasing
    {
        public override string Tag => "img";
    }
}
