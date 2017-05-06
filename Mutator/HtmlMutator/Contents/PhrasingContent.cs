using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using HtmlMutator;
using HtmlMutator.HtmlElements;

namespace HtmlMutator
{
    /// <summary>
    /// Represents the text content of the HTML element. 
    /// This can be used with the HTML elements, which implements the <see cref="IPhrasing"/> interface.
    /// The <see cref="PhrasingContent"/> can be used as a <see cref="HtmlElement.ChildElements"/> of the HTML element.
    /// </summary>
    public class PhrasingContent : HtmlElement, IPhrasing
    {
        public override string Tag => null;

        /// <summary>
        /// Text content.
        /// </summary>
        private readonly MvcHtmlString _content;

        /// <summary>
        /// Represents the text content of the HTML element.
        /// </summary>
        /// <param name="content">Text content.</param>
        public PhrasingContent(string content)
        {
            _content = new MvcHtmlString(HttpUtility.HtmlEncode(content));
        }

        /// <summary>
        /// Represents the text content of the HTML element.
        /// </summary>
        /// <param name="content">Text content.</param>
        public PhrasingContent(MvcHtmlString content)
        {
            _content = content;
        }

        /// <summary>
        /// Returns the text content.
        /// </summary>
        /// <returns></returns>
        public override MvcHtmlString Render() => _content;

        public static implicit operator PhrasingContent(string text) => new PhrasingContent(text);
        public static implicit operator string(PhrasingContent text) => text._content.ToString();

        public static implicit operator PhrasingContent(MvcHtmlString text) => new PhrasingContent(text);
        public static implicit operator MvcHtmlString(PhrasingContent text) => text._content;
    }
}
