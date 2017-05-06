using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using HtmlMutator;
using HtmlMutator.Contents;
using HtmlMutator.Helpers;
using HtmlMutator.Renderers;
using static System.Int32;

namespace HtmlMutator.HtmlElements
{
    /// <summary>
    /// Abstract base class of the HTML elements.
    /// Contains the global HTML attributes.
    /// </summary>
    public abstract class HtmlElement : IHtml
    {
        /// <summary>
        /// Default contsructor for the HTML element with default <see cref="BasicMutatorHtmlRenderer"/>.
        /// </summary>
        protected HtmlElement()
        {
            Renderer = new BasicMutatorHtmlRenderer();
            ExtraData = new Dictionary<string, object>();
        }

        /// <summary>
        /// Constructor with given <see cref="IRenderer"/>.
        /// </summary>
        /// <param name="renderer"></param>
        protected HtmlElement(IRenderer renderer)
        {
            Renderer = new BasicMutatorHtmlRenderer();
            ExtraData = new Dictionary<string, object>();
            Renderer = renderer;
        }

        /// <summary>
        /// Renderer for the HTML Mutator.
        /// </summary>
        public IRenderer Renderer { get; protected set; }

        /// <summary>
        /// Tag omission of the HTML element.
        /// </summary>
        public virtual TagOmission TagOmission => TagOmission.BothRequired;

        /// <summary>
        /// Renders the HTML element.
        /// </summary>
        /// <returns></returns>
        public virtual MvcHtmlString Render() => Renderer.Render(this);

        public IHtml Parent { get; set; }

        /// <summary>
        /// Protected settable list of child elements of the HTML element. Not every HTML element has child elements.
        /// </summary>
        protected readonly List<IHtml> _childElements = new List<IHtml>();

        /// <summary>
        /// Returns the child elements of the HTML element. Not every HTML element has child elements.
        /// </summary>
        public virtual IEnumerable<IHtml> ChildElements => _childElements;

        /// <summary>
        /// Protected settable dictionary of the attributes of the HTML element.
        /// </summary>
        protected readonly Dictionary<string, IEnumerable<AttributeValue>> _attributes = new Dictionary<string, IEnumerable<AttributeValue>>();

        /// <summary>
        /// Returns the attributes of the HTML element.
        /// Key: attribute name.
        /// Value: attribute value as string.
        /// </summary>
        public IEnumerable<KeyValuePair<string, IEnumerable<AttributeValue>>> Attributes => _attributes;

        public Dictionary<string, object> ExtraData { get; set; }

        /// <summary>
        /// Gets or sets the attribute value based on the attribute name as key.
        /// </summary>
        /// <param name="attribute">Attribute name</param>
        /// <returns>Attribute value</returns>
        public string this[string attribute]
        {
            get
            {
                IEnumerable<AttributeValue> value;
                _attributes.TryGetValue(attribute.ToLower(), out value);

                if(value != null)
                    return value.ToAttribute();

                return string.Empty;
            }
            set { _attributes[attribute.ToLower()] = new List<AttributeValue>{ value }; }
        }

        IEnumerator<IHtml> IEnumerable<IHtml>.GetEnumerator() => ChildElements.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        public IEnumerator<KeyValuePair<string, IEnumerable<AttributeValue>>> GetEnumerator() => Attributes.GetEnumerator();

        #region Global attributes

        /// <summary>
        /// Provides a hint for generating a keyboard shortcut for the current element. 
        /// This attribute consists of a space-separated list of characters. 
        /// The browser should use the first one that exists on the computer keyboard layout.
        /// </summary>
        public string Accesskey
        {
            get { return this[nameof(Accesskey)]; }
            set { this[nameof(Accesskey)] = value; }
        }

        /// <summary>
        /// Is a space-separated list of the classes of the element. 
        /// Classes allows CSS and JavaScript to select and access specific elements via the class selectors or functions.
        /// </summary>
        public string Class
        {
            get { return this[nameof(Class)]; }
            set { this[nameof(Class)] = value; }
        }

        /// <summary>
        /// Is an enumerated attribute indicating if the element should be editable by the user. 
        /// If so, the browser modifies its widget to allow editing. 
        /// The attribute must take one of the following values:
        /// - true or the empty string, which indicates that the element must be editable;
        /// - false, which indicates that the element must not be editable.
        /// </summary>
        public bool? Contenteditable
        {
            get { return this[nameof(Contenteditable)].FromStringToNullableBool(); }
            set { this[nameof(Contenteditable)] = value.FromNullableBoolToString(); }
        }

        /// <summary>
        /// Is the id of an "menu" to use as the contextual menu for this element.
        /// </summary>
        public string Contextmenu
        {
            get { return this[nameof(Contextmenu)]; }
            set { this[nameof(Contextmenu)] = value; }
        }

        /// <summary>
        /// Is an enumerated attribute indicating the directionality of the element's text. It can have the following values:
        /// - ltr, which means left to right and is to be used for languages that are written from the left to the right (like English);
        /// - rtl, which means right to left and is to be used for languages that are written from the right to the left (like Arabic);
        /// - auto, which let the user agent decides. It uses a basic algorithm as it parses the characters inside the element 
        /// until it finds a character with a strong directionality, then apply that directionality to the whole element.
        /// </summary>
        public DirEnum Dir
        {
            get { return (DirEnum) Enum.Parse(typeof(DirEnum), this[nameof(Dir)]); }
            set { this[nameof(Dir)] = value.ToString("G").ToLower(); }
        }

        /// <summary>
        /// Is a Boolean attribute indicates that the element is not yet, or is no longer, relevant. 
        /// For example, it can be used to hide elements of the page that can't be used until the login process has been completed. 
        /// The browser won't render such elements. 
        /// This attribute must not be used to hide content that could legitimately be shown.
        /// </summary>
        public bool Hidden
        {
            get { return this[nameof(Hidden)].FromStringToBool(); }
            set { this[nameof(Hidden)] = value.FromBoolToString(); }
        }

        /// <summary>
        /// Defines a unique identifier (ID) which must be unique in the whole document. 
        /// Its purpose is to identify the element when linking (using a fragment identifier), scripting, or styling (with CSS).
        /// </summary>
        public string Id
        {
            get { return this[nameof(Id)]; }
            set { this[nameof(Id)] = value; }
        }

        /// <summary>
        /// Participates in defining the language of the element, the language that non-editable elements are written in
        /// or the language that editable elements should be written in.
        /// </summary>
        public string Lang
        {
            get { return this[nameof(Lang)]; }
            set { this[nameof(Lang)] = value; }
        }

        /// <summary>
        /// Contains CSS styling declarations to be applied to the element. Note that it is recommended for styles to be defined in a separate file or files. 
        /// This attribute and the style element have mainly the purpose of allowing for quick styling, for example for testing purposes.
        /// </summary>
        public string Style
        {
            get { return this[nameof(Style)]; }
            set { this[nameof(Style)] = value; }
        }

        /// <summary>
        /// Is an integer attribute indicates if the element can take input focus (is focusable), 
        /// if it should participate to sequential keyboard navigation, and if so, at what position. It can takes several values:
        /// - a negative value means that the element should be focusable, but should not be reachable via sequential keyboard navigation;
        /// - 0 means that the element should be focusable and reachable via sequential keyboard navigation, but its relative order is defined by the platform convention;
        /// - a positive value which means should be focusable and reachable via sequential keyboard navigation; its relative order is defined by the value of the attribute: the sequential follow the increasing number of the tabindex.
        /// </summary>
        public int Tabindex
        {
            get { return Parse(this[nameof(Tabindex)]); }
            set { this[nameof(Tabindex)] = value.ToString(); }
        }

        public abstract string Tag { get; }

        /// <summary>
        /// Contains a text representing advisory information related to the element it belongs to. 
        /// Such information can typically, but not necessarily, be presented to the user as a tooltip.
        /// </summary>
        public string Title
        {
            get { return this[nameof(Title)]; }
            set { this[nameof(Title)] = value; }
        }

        /// <summary>
        /// Is an enumerated attribute that is used to specify whether an element's attribute values and the values of its 
        /// Text node children are to be translated when the page is localized, or whether to leave them unchanged. 
        /// It can have the following values:
        /// - empty string and "yes", which indicates that the element will be translated.
        /// - "no", which indicates that the element will not be translated.
        /// </summary>
        public TranslateEnum Translate
        {
            get { return (TranslateEnum) Enum.Parse(typeof(TranslateEnum), this[nameof(Translate)]); }
            set { this[nameof(Translate)] = value.ToString("G").ToLower(); }
        }

        #endregion
    }
}
