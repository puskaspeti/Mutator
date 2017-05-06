using HtmlMutator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlMutator.Helpers;

namespace HtmlMutator.HtmlElements
{
    /// <summary>
    /// The HTML <see cref="Head"/> element provides general information (metadata) about the document, 
    /// including its title and links to its scripts and style sheets.
    /// </summary>
    public class Head : HtmlElement, IChildElements<IMetadata, Head>
    {
        public override string Tag => "head";

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="HtmlElement.ChildElements"/> list.
        /// </summary>
        /// <param name="elements">Child elements</param>
        /// <returns>this</returns>
        public Head Add(params IMetadata[] elements)
        {
            _childElements.AddRange(elements);
            return this;
        }

        #region Attributes

        /// <summary>
        /// The URIs of one or more metadata profiles, separated by white space.
        /// </summary>
        [Obsolete]
        public string Profile
        {
            get { return this[nameof(Profile)]; }
            set { this[nameof(Profile)] = value; }
        }

        #endregion
    }
}
