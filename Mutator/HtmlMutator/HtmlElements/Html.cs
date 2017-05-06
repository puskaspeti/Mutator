using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlMutator;
using HtmlMutator.Helpers;

namespace HtmlMutator.HtmlElements
{
    /// <summary>
    /// The HTML <see cref="Html"/> element (or HTML root element) represents the root of an HTML document. All other elements must be descendants of this element.
    /// </summary>
    public class Html : HtmlElement
    {
        public override string Tag => "html";

        /// <summary>
        /// Provides general information about the document.
        /// </summary>
        public Head Head { get; set; }

        /// <summary>
        /// Represents the content of an HTML document.
        /// </summary>
        public Body Body { get; set; }

        public override IEnumerable<IHtml> ChildElements
        {
            get
            {
                if (Head != null)
                    yield return Head;
                if (Body != null)
                    yield return Body;
            }
        }

        #region Attributes

        /// <summary>
        /// Specifies the URI of a resource manifest indicating resources that should be cached locally.
        /// </summary>
        [Obsolete]
        public string Manifest
        {
            get { return this[nameof(Manifest)]; }
            set { this[nameof(Manifest)] = value; }
        }

        /// <summary>
        /// Specifies the version of the HTML Document Type Definition that governs the current document. 
        /// This attribute is not needed, because it is redundant with the version information in the document type declaration.
        /// </summary>
        [Obsolete]
        public string Version
        {
            get { return this[nameof(Version)]; }
            set { this[nameof(Version)] = value; }
        }

        /// <summary>
        /// Specifies the XML Namespace of the document. Default value is "http://www.w3.org/1999/xhtml". This is required in XHTML, and optional in HTML.
        /// </summary>
        public string Xmlns
        {
            get { return this[nameof(Xmlns)]; }
            set { this[nameof(Xmlns)] = value; }
        }

        #endregion
    }
}
