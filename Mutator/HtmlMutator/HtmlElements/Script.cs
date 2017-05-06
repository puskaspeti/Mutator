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
    /// The HTML <see cref="Script"/> Element is used to embed or reference an executable script within an HTML or XHTML document.
    ///Scripts without async or defer attributes, as well as inline scripts, are fetched and executed immediately, before the browser continues to parse the page.
    /// </summary>
    public class Script : HtmlElement, IChildElements<PhrasingContent, Script>, IMetadata, IFlow, IPhrasing
    {
        public override string Tag => "script";

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="HtmlElement.ChildElements"/> list.
        /// </summary>
        /// <param name="elements">Child elements</param>
        public Script Add(params PhrasingContent[] elements)
        {
            _childElements.AddRange(elements);
            return this;
        }

        #region Attributes

        /// <summary>
        /// Set this Boolean attribute to indicate that the browser should, if possible, execute the script asynchronously. 
        /// It has no effect on inline scripts (i.e., scripts that don't have the src attribute).
        /// </summary>
        public bool Async
        {
            get { return this[nameof(Async)].FromStringToBool(); }
            set { this[nameof(Async)] = value.FromBoolToString(); }
        }

        /// <summary>
        /// Contains inline metadata that a user agent can use to verify that a fetched resource has been delivered free of unexpected manipulation.
        /// </summary>
        public string Integrity
        {
            get { return this[nameof(Integrity)]; }
            set { this[nameof(Integrity)] = value; }
        }

        /// <summary>
        /// The value will be absolute path of the realtive route.
        /// This attribute specifies the URI of an external script; 
        /// this can be used as an alternative to embedding a script directly within a document. 
        /// If a script element has a src attribute specified, it should not have a script embedded inside its tags.
        /// </summary>
        public string Src
        {
            get { return this[nameof(Src)]; }
            set
            {
                if (value[0] == '~')
                    this[nameof(Src)] = System.Web.VirtualPathUtility.ToAbsolute(value);
                else
                    this[nameof(Src)] = value;
            }
        }

        /// <summary>
        /// This attribute identifies the scripting language of code embedded within a script element or referenced via the element’s src attribute. 
        /// This is specified as a MIME type; examples of supported MIME types include text/javascript, text/ecmascript, application/javascript, and application/ecmascript. 
        /// If this attribute is absent, the script is treated as JavaScript.
        /// </summary>
        public string Type
        {
            get { return this[nameof(Type)]; }
            set { this[nameof(Type)] = value; }
        }

        /// <summary>
        /// Like the textContent attribute, this attribute sets the text content of the element.  
        /// Unlike the textContent attribute, however, this attribute is evaluated as executable code after the node is inserted into the DOM.
        /// </summary>
        public string Text
        {
            get { return this[nameof(Text)]; }
            set { this[nameof(Text)] = value; }
        }

        /// <summary>
        /// Like the type attribute, this attribute identifies the scripting language in use. 
        /// Unlike the type attribute, however, this attribute’s possible values were never standardized. 
        /// The type attribute should be used instead.
        /// </summary>
        [Obsolete]
        public string Language
        {
            get { return this[nameof(Language)]; }
            set { this[nameof(Language)] = value; }
        }

        /// <summary>
        /// This Boolean attribute is set to indicate to a browser that the script is meant to be executed 
        /// after the document has been parsed, but before firing DOMContentLoaded. 
        /// The defer attribute shouldn't be used on scripts that don't have the src attribute.
        /// </summary>
        public bool Defer
        {
            get { return this[nameof(Defer)].FromStringToBool(); }
            set { this[nameof(Defer)] = value.FromBoolToString(); }
        }

        /// <summary>
        /// Normal script elements pass minimal information to the window.onerror for scripts which do not pass the standard CORS checks. 
        /// To allow error logging for sites which use a separate domain for static media, use this attribute.
        /// </summary>
        public string Crossorigin
        {
            get { return this[nameof(Crossorigin)]; }
            set { this[nameof(Crossorigin)] = value; }
        }

        #endregion
    }
}
