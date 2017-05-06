using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using HtmlMutator;
using HtmlMutator.Helpers;
using HtmlMutator.HtmlElements;
using HtmlMutator.Contents;

namespace HtmlMutator.HtmlElements
{
    /// <summary>
    /// The HTML element <see cref="Input"/> is used to create interactive controls for web-based forms in order to accept data from the user. 
    /// How an <see cref="Input"/> works varies considerably depending on the value of its type attribute.
    /// </summary>
    public class Input : EmptyHtmlElement, IFlow, IListed, ISubmittable, IResettable, IFormAssociated, IPhrasing
    {
        public override string Tag => "input";

        /// <summary>
        /// The type of control to display. The default type is text, if this attribute is not specified.
        /// </summary>
        public InputTypeOptions Type
        {
            get { return (InputTypeOptions)Enum.Parse(typeof(InputTypeOptions), this[nameof(Type)]); }
            set { this[nameof(Type)] = value.ToString("G").ToLower(); }
        }
    }
}
