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
    /// The HTML <see cref="Script"/> Element is used to embed or reference an executable script within an HTML or XHTML document.
    ///Scripts without async or defer attributes, as well as inline scripts, are fetched and executed immediately, before the browser continues to parse the page.
    /// </summary>
    public class Link : EmptyHtmlElement, IMetadata, IFlow, IPhrasing
    {
        public override string Tag => "link";

        #region Attributes

        /// <summary>
        /// The value will be absolute path of the realtive route.
        /// This attribute names a relationship of the linked document to the current document. 
        /// The attribute must be a space-separated list of the link types values.
        /// </summary>
        public string Href
        {
            get { return this[nameof(Href)]; }
            set
            {
                if (value[0] == '~')
                    this[nameof(Href)] = System.Web.VirtualPathUtility.ToAbsolute(value);
                else
                    this[nameof(Href)] = value;
            }
        }

        /// <summary>
        /// This attribute names a relationship of the linked document to the current document. 
        /// The attribute must be a space-separated list of the link types values.
        /// </summary>
        public string Rel
        {
            get { return this[nameof(Rel)]; }
            set { this[nameof(Rel)] = value; }
        }

        #endregion
    }
}
