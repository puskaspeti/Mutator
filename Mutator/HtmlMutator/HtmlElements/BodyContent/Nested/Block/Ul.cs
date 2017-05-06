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
    /// The HTML <see cref="Ul"/> element (or HTML Unordered List Element) represents an unordered list of items, 
    /// namely a collection of items that do not have a numerical ordering, and their order in the list is meaningless. 
    /// </summary>
    public class Ul : HtmlElement, IChildElements<Li, Ul>, IFlow
    {
        public override string Tag => "ul";

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="HtmlElement.ChildElements"/> list.
        /// </summary>
        /// <param name="elements">Child elements</param>
        public Ul Add(params Li[] elements)
        {
            _childElements.AddRange(elements);
            return this;
        }

        #region Attributes

        /// <summary>
        /// 
        /// </summary>
        [Obsolete]
        public bool Compact
        {
            get { return this[nameof(Compact)].FromStringToBool(); }
            set { this[nameof(Compact)] = value.FromBoolToString(); }
        }

        /// <summary>
        /// Used to set the bullet style for the list. The values defined under HTML3.2 and the transitional version of HTML 4.0/4.01 are:
        /// - circle,
        /// - disc,
        /// - square.
        /// A fourth bullet type has been defined in the WebTV interface, but not all browsers support it: triangle.
        /// </summary>
        [Obsolete]
        public UlTypeEnum Type
        {
            get { return (UlTypeEnum)Enum.Parse(typeof(UlTypeEnum), this[nameof(Type)]); }
            set { this[nameof(Type)] = value.ToString("G").ToLower(); }
        }

        #endregion
    }
}
