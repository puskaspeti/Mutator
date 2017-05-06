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
    /// The HTML Anchor Element (<see cref="A"/>) defines a hyperlink to a location on the same page or any other page on the Web. 
    /// It can also be used (in an obsolete way) to create an anchor point—a destination for hyperlinks within the content of a page, 
    /// so that links aren't limited to connecting simply to the top of a page.
    /// </summary>
    public class A : InlineHtmlElement, IPhrasing, IInteractive, IPalpable, IChildElements<IFlow, A>, IChildElements<PhrasingContent, A>
    {
        public override string Tag => "a";

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="HtmlElement.ChildElements"/> list.
        /// </summary>
        /// <param name="element">Child elements</param>
        public A Add(params IFlow[] elements)
        {
            AddInternal(elements);
            return this;
        }

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="HtmlElement.ChildElements"/> list.
        /// </summary>
        /// <param name="element">Child elements</param>
        public A Add(params PhrasingContent[] elements)
        {
            AddInternal(elements);
            return this;
        }

        #region Attributes

        /// <summary>
        /// This was the single required attribute for anchors defining a hypertext source link, 
        /// but the attribute may now be omitted (as of HTML5) in order to create a placeholder link. 
        /// </summary>
        public string Href
        {
            get { return this[nameof(Href)]; }
            set { this[nameof(Href)] = value; }
        }

        /// <summary>
        /// This attribute indicates the language of the linked resource. It is purely advisory. 
        /// Allowed values are determined by BCP47 for HTML5 and by RFC1766 for HTML4. 
        /// Use this attribute only if the href attribute is present.
        /// </summary>
        public string Hreflang
        {
            get { return this[nameof(Hreflang)]; }
            set { this[nameof(Hreflang)] = value; }
        }

        /// <summary>
        /// For anchors containing the href attribute, this attribute specifies the relationship of the target object to the link object. 
        /// The value is a space-separated list of link types values.
        /// </summary>
        public string Rel
        {
            get { return this[nameof(Rel)]; }
            set { this[nameof(Rel)] = value; }
        }

        /// <summary>
        /// This attribute specifies where to display the linked resource. In HTML4, this is the name of, or a keyword for, a frame. 
        /// In HTML5, it is a name of, or keyword for, a browsing context (for example, tab, window, or inline frame). The following keywords have special meanings:
        /// - _self: Load the response into the same HTML4 frame (or HTML5 browsing context) as the current one. This value is the default if the attribute is not specified.
        /// - _blank: Load the response into a new unnamed HTML4 window or HTML5 browsing context.
        /// - _parent: Load the response into the HTML4 frameset parent of the current frame or HTML5 parent browsing context of the current one. If there is no parent, this option behaves the same way as _self.
        /// - _top: In HTML4: Load the response into the full, original window, canceling all other frames. 
        /// In HTML5: Load the response into the top-level browsing context (that is, the browsing context that is an ancestor of the current one, and has no parent). If there is no parent, this option behaves the same way as _self.
        /// </summary>
        public ATargetEnum Target
        {
            get { return (ATargetEnum) Enum.Parse(typeof(ATargetEnum), this[nameof(Target)]); }
            set { this[nameof(Target)] = value.ToString("G").ToLower(); }
        }

        /// <summary>
        /// This attribute specifies the media type in the form of a MIME type for the link target.
        /// </summary>
        public string Type
        {
            get { return this[nameof(Type)]; }
            set { this[nameof(Type)] = value; }
        }

        #endregion
    }
}
