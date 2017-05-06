using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlMutator.Contents;
using HtmlMutator.Helpers;

namespace HtmlMutator.HtmlElements
{
    /// <summary>
    /// Represents the self closing HTML elements.
    /// Can not contain child elements.
    /// </summary>
    public abstract class EmptyHtmlElement : HtmlElement
    {
        public override TagOmission TagOmission => TagOmission.SelfClosing;
    }
}
