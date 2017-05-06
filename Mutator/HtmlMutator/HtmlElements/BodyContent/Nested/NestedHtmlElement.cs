using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlMutator;

namespace HtmlMutator.HtmlElements
{
    /// <summary>
    /// Represents the nested HTML elements.
    /// Can contain child elmenents.
    /// </summary>
    public abstract class NestedHtmlElement : HtmlElement
    {
        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="HtmlElement.ChildElements"/> list.
        /// </summary>
        /// <param name="element">Child elements</param>
        protected void AddInternal(params IHtml[] elements)
        {
            foreach (var element in elements)
            {
                element.Parent = this;
                _childElements.Add(element);
            }
        }

    }
}
