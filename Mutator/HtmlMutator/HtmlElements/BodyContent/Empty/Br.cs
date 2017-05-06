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
    /// The HTML element line break <see cref="Br"/> produces a line break in text (carriage-return). 
    /// It is useful for writing a poem or an address, where the division of lines is significant.
    /// </summary>
    public class Br : EmptyHtmlElement, IFlow, IPhrasing
    {
        public override string Tag => "br";
    }
}
