using HtmlMutator;
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
    /// The HTML <see cref="Body"/> Element represents the content of an HTML document. There can be only one body element in a document.
    /// </summary>
    public class Body : HtmlElement, IChildElements<IFlow, Body>, IChildElements<PhrasingContent, Body>
    {
        public override string Tag => "body";

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="HtmlElement.ChildElements"/> list.
        /// </summary>
        /// <param name="elements">Child elements</param>
        /// <returns>this</returns>
        public Body Add(params IFlow[] elements)
        {
            _childElements.AddRange(elements);
            return this;
        }

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="HtmlElement.ChildElements"/> list.
        /// </summary>
        /// <param name="elements">Child elements</param>
        public Body Add(params PhrasingContent[] elements)
        {
            _childElements.AddRange(elements);
            return this;
        }

        #region Attributes

        /// <summary>
        /// Color of text for hyperlinks when selected. This method is non-conforming, use CSS color property in conjunction with the :active pseudo-class instead.
        /// </summary>
        [Obsolete]
        public string Alink
        {
            get { return this[nameof(Alink)]; }
            set { this[nameof(Alink)] = value; }
        }

        /// <summary>
        /// URI of a image to use as a background. This method is non-conforming, use CSS background property on the element instead.
        /// </summary>
        [Obsolete]
        public string Background
        {
            get { return this[nameof(Background)]; }
            set { this[nameof(Background)] = value; }
        }

        /// <summary>
        /// Background color for the document. This method is non-conforming, use CSS background-color property on the element instead.
        /// </summary>
        [Obsolete]
        public string Bgcolor
        {
            get { return this[nameof(Bgcolor)]; }
            set { this[nameof(Bgcolor)] = value; }
        }

        /// <summary>
        /// The margin of the bottom of the body. This method is non-conforming, use CSS margin-bottom property on the element instead.
        /// </summary>
        [Obsolete]
        public string Bottommargin
        {
            get { return this[nameof(Bottommargin)]; }
            set { this[nameof(Bottommargin)] = value; }
        }

        /// <summary>
        /// The margin of the left of the body. This method is non-conforming, use CSS margin-left property on the element instead.
        /// </summary>
        [Obsolete]
        public string Leftmargin
        {
            get { return this[nameof(Leftmargin)]; }
            set { this[nameof(Leftmargin)] = value; }
        }

        /// <summary>
        /// Color of text for unvisited hypertext links. This method is non-conforming, use CSS color property in conjunction with the :link pseudo-class instead.
        /// </summary>
        [Obsolete]
        public string Link
        {
            get { return this[nameof(Link)]; }
            set { this[nameof(Link)] = value; }
        }

        /// <summary>
        /// Function to call after the user has printed the document.
        /// </summary>
        public string Onafterprint
        {
            get { return this[nameof(Onafterprint)]; }
            set { this[nameof(Onafterprint)] = value; }
        }

        /// <summary>
        /// Function to call when the user requests printing of the document.
        /// </summary>
        public string Onbeforeprint
        {
            get { return this[nameof(Onbeforeprint)]; }
            set { this[nameof(Onbeforeprint)] = value; }
        }

        /// <summary>
        /// Function to call when the document is about to be unloaded.
        /// </summary>
        public string Onbeforeunload
        {
            get { return this[nameof(Onbeforeunload)]; }
            set { this[nameof(Onbeforeunload)] = value; }
        }

        /// <summary>
        /// Function to call when the document loses focus.
        /// </summary>
        public string Onblur
        {
            get { return this[nameof(Onblur)]; }
            set { this[nameof(Onblur)] = value; }
        }

        /// <summary>
        /// Function to call when the document fails to load properly.
        /// </summary>
        public string Onerror
        {
            get { return this[nameof(Onerror)]; }
            set { this[nameof(Onerror)] = value; }
        }

        /// <summary>
        /// Function to call when the document receives focus.
        /// </summary>
        public string Onfocus
        {
            get { return this[nameof(Onfocus)]; }
            set { this[nameof(Onfocus)] = value; }
        }

        /// <summary>
        /// Function to call when the fragment identifier part (starting with the hash ('#') character) of the document's current address has changed.
        /// </summary>
        public string Onhashchange
        {
            get { return this[nameof(Onhashchange)]; }
            set { this[nameof(Onhashchange)] = value; }
        }

        /// <summary>
        /// Function to call when the document has finished loading.
        /// </summary>
        public string Onload
        {
            get { return this[nameof(Onload)]; }
            set { this[nameof(Onload)] = value; }
        }

        /// <summary>
        /// Function to call when the document has received a message.
        /// </summary>
        public string Onmessage
        {
            get { return this[nameof(Onmessage)]; }
            set { this[nameof(Onmessage)] = value; }
        }

        /// <summary>
        /// Function to call when network communication has failed.
        /// </summary>
        public string Onoffline
        {
            get { return this[nameof(Onoffline)]; }
            set { this[nameof(Onoffline)] = value; }
        }

        /// <summary>
        /// Function to call when network communication has been restored.
        /// </summary>
        public string Ononline
        {
            get { return this[nameof(Ononline)]; }
            set { this[nameof(Ononline)] = value; }
        }

        /// <summary>
        /// Function to call when the user has navigated session history.
        /// </summary>
        public string Onpopstate
        {
            get { return this[nameof(Onpopstate)]; }
            set { this[nameof(Onpopstate)] = value; }
        }

        /// <summary>
        /// Function to call when the user has moved forward in undo transaction history.
        /// </summary>
        public string Onredo
        {
            get { return this[nameof(Onredo)]; }
            set { this[nameof(Onredo)] = value; }
        }

        /// <summary>
        /// Function to call when the document has been resized.
        /// </summary>
        public string Onresize
        {
            get { return this[nameof(Onresize)]; }
            set { this[nameof(Onresize)] = value; }
        }

        /// <summary>
        /// Function to call when the storage area has changed.
        /// </summary>
        public string Onstorage
        {
            get { return this[nameof(Onstorage)]; }
            set { this[nameof(Onstorage)] = value; }
        }

        /// <summary>
        /// Function to call when the user has moved backward in undo transaction history.
        /// </summary>
        public string Onundo
        {
            get { return this[nameof(Onundo)]; }
            set { this[nameof(Onundo)] = value; }
        }

        /// <summary>
        /// Function to call when the document is going away.
        /// </summary>
        public string Onunload
        {
            get { return this[nameof(Onunload)]; }
            set { this[nameof(Onunload)] = value; }
        }

        /// <summary>
        /// The margin of the right of the body. This method is non-conforming, use CSS margin-right property on the element instead.
        /// </summary>
        [Obsolete]
        public string Rightmargin
        {
            get { return this[nameof(Rightmargin)]; }
            set { this[nameof(Rightmargin)] = value; }
        }

        /// <summary>
        /// Foreground color of text. This method is non-conforming, use CSS color property on the element instead.
        /// </summary>
        [Obsolete]
        public string Text
        {
            get { return this[nameof(Text)]; }
            set { this[nameof(Text)] = value; }
        }

        /// <summary>
        /// The margin of the top of the body. This method is non-conforming, use CSS margin-top property on the element instead.
        /// </summary>
        [Obsolete]
        public string Topmargin
        {
            get { return this[nameof(Topmargin)]; }
            set { this[nameof(Topmargin)] = value; }
        }

        /// <summary>
        /// Color of text for visited hypertext links. This method is non-conforming, use CSS color property in conjunction with the :visited pseudo-class instead.
        /// </summary>
        [Obsolete]
        public string Vlink
        {
            get { return this[nameof(Vlink)]; }
            set { this[nameof(Vlink)] = value; }
        }

        #endregion
    }
}
