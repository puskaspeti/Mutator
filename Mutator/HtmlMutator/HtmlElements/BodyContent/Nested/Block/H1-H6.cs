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
    /// The HTML <see cref="H1"/>-<see cref="H6"/> elements represent six levels of section headings. 
    /// <see cref="H1"/> is the highest section level and <see cref="H6"/> is the lowest.
    /// </summary>
    public class H1 : BlockHtmlElement, IFlow, IHeading, IPalpable, IChildElements<IFlow, H1>, IChildElements<PhrasingContent, H1>
    {
        public override string Tag => "h1";

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="HtmlElement.ChildElements"/> list.
        /// </summary>
        /// <param name="element">Child elements</param>
        public H1 Add(params IFlow[] elements)
        {
            AddInternal(elements);
            return this;
        }

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="HtmlElement.ChildElements"/> list.
        /// </summary>
        /// <param name="element">Child elements</param>
        public H1 Add(params PhrasingContent[] elements)
        {
            AddInternal(elements);
            return this;
        } 
    }

    /// <summary>
    /// The HTML <see cref="H1"/>-<see cref="H6"/> elements represent six levels of section headings. 
    /// <see cref="H1"/> is the highest section level and <see cref="H6"/> is the lowest.
    /// </summary>
    public class H2 : H1
    {
        public override string Tag => "h2";
    }

    /// <summary>
    /// The HTML <see cref="H1"/>-<see cref="H6"/> elements represent six levels of section headings. 
    /// <see cref="H1"/> is the highest section level and <see cref="H6"/> is the lowest.
    /// </summary>
    public class H3 : H1
    {
        public override string Tag => "h3";
    }

    /// <summary>
    /// The HTML <see cref="H1"/>-<see cref="H6"/> elements represent six levels of section headings. 
    /// <see cref="H1"/> is the highest section level and <see cref="H6"/> is the lowest.
    /// </summary>
    public class H4 : H1
    {
        public override string Tag => "h4";
    }

    /// <summary>
    /// The HTML <see cref="H1"/>-<see cref="H6"/> elements represent six levels of section headings. 
    /// <see cref="H1"/> is the highest section level and <see cref="H6"/> is the lowest.
    /// </summary>
    public class H5 : H1
    {
        public override string Tag => "h5";
    }

    /// <summary>
    /// The HTML <see cref="H1"/>-<see cref="H6"/> elements represent six levels of section headings. 
    /// <see cref="H1"/> is the highest section level and <see cref="H6"/> is the lowest.
    /// </summary>
    public class H6 : H1
    {
        public override string Tag => "h6";
    }
}
