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
    /// The HTML <see cref="Li"/> element (or HTML List Item Element) is used to represent an item in a list. 
    /// It must be contained in a parent element: an ordered list (ol), an unordered list (<see cref="Ul"/>), or a menu (menu).
    /// </summary>
    public class Li : BlockHtmlElement, IChildElements<IFlow, Li>, IChildElements<PhrasingContent, Li>
    {
        public override string Tag => "li";

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="HtmlElement.ChildElements"/> list.
        /// </summary>
        /// <param name="element">Child elements</param>
        public Li Add(params IFlow[] elements)
        {
            AddInternal(elements);
            return this;
        }

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="HtmlElement.ChildElements"/> list.
        /// </summary>
        /// <param name="element">Child elements</param>
        public Li Add(params PhrasingContent[] elements)
        {
            AddInternal(elements);
            return this;
        }

        #region Attributes

        /// <summary>
        /// This integer attribute indicates the current ordinal value of the list item as defined by the ol element.
        /// </summary>
        public string Value
        {
            get { return this[nameof(Value)]; }
            set { this[nameof(Value)] = value; }
        }

        /// <summary>
        /// This character attribute indicates the numbering type.
        /// </summary>
        [Obsolete]
        public string Type
        {
            get { return this[nameof(Type)]; }
            set { this[nameof(Type)] = value; }
        }

        #endregion
    }
}
