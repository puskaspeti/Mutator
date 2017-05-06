using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using HtmlMutator;
using HtmlMutator.Contents;
using HtmlMutator.HtmlElements;
using HtmlMutator.Helpers;

namespace HtmlMutator.Renderers
{
    public class BasicMutatorHtmlRenderer : IRenderer
    {
        public MvcHtmlString Render(IHtml element)
        {
            var sb = new StringBuilder();

            sb.Append($"<{element.Tag}");

            foreach (var attribute in element.Attributes)
                sb.Append($" {attribute.Key}=\"{attribute.Value.ToAttribute()}\"");

            if (element.TagOmission != TagOmission.SelfClosing)
            {
                sb.Append(">");

                foreach (var elem in element.ChildElements)
                    sb.Append(elem.Render());

                sb.Append($"</{element.Tag}>");
            }
            else
            {
                sb.Append("/>");
            }

            return new MvcHtmlString(sb.ToString());
        }
    }
}
