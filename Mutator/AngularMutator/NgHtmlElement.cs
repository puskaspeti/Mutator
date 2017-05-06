using HtmlMutator.HtmlElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlMutator.AngularMutator
{
    public class NgHtmlElement<T> : HtmlElement where T : HtmlElement
    {
        public T Element { get; set; }

        public override string Tag => Element.Tag;

        public static implicit operator T(NgHtmlElement<T> ngElement) => ngElement.Element;
        public static implicit operator NgHtmlElement<T>(T element) => new NgHtmlElement<T>();
    }
}
