using System.Collections;
using System.Collections.Generic;
using System.Web.Mvc;
using HtmlMutator.Contents;
using HtmlMutator.HtmlElements;

namespace HtmlMutator
{
    public interface IChildElements<in T, out T2> where T : IHtml
                                                  where T2 : HtmlElement
    {
        T2 Add(params T[] element);
    }

    public interface IHtml : IEnumerable<IHtml>
    {
        string Tag { get; }
        TagOmission TagOmission { get; }
        IEnumerable<KeyValuePair<string, IEnumerable<AttributeValue>>> Attributes { get; }
        IEnumerable<IHtml> ChildElements { get; }
        IHtml Parent { get; set; }
        Dictionary<string, object> ExtraData { get; set; }
        MvcHtmlString Render();
    }

    /// <summary>
    /// Elements belonging to the flow content category typically contain text or embedded content.
    /// </summary>
    public interface IFlow : IHtml
    {
    }

    /// <summary>
    /// Heading content defines the title of a section, 
    /// whether marked by an explicit sectioning content element 
    /// or implicitly defined by the heading content itself.
    /// </summary>
    public interface IHeading : IFlow
    {
    }

    /// <summary>
    /// Elements belonging to the sectioning content model create a section in the current outline 
    /// that defines the scope of  header elements, footer elements, and heading content.
    /// </summary>
    public interface ISectioning : IFlow
    {
    }

    /// <summary>
    /// Phrasing content defines the text and the mark-up it contains. 
    /// Runs of phrasing content make up paragraphs.
    /// </summary>
    public interface IPhrasing : IFlow
    {
    }

    /// <summary>
    /// Embedded content imports another resource or inserts content 
    /// from another mark-up language or namespace into the document.
    /// </summary>
    public interface IEmbedded : IPhrasing
    {
    }

    /// <summary>
    /// Interactive content includes elements that are specifically designed for user interaction.
    /// </summary>
    public interface IInteractive : IFlow
    {
    }

    /// <summary>
    /// Includes interactive and phrasing content
    /// </summary>
    public interface IInteractivePhrasing : IInteractive, IPhrasing
    {
    }

    /// <summary>
    /// Includes interactive and embedded content
    /// </summary>
    public interface IInteractiveEmbedded : IInteractive, IEmbedded
    {
    }

    /// <summary>
    /// Elements belonging to the metadata content category modify 
    /// the presentation or the behavior of the rest of the document, 
    /// set up links to other documents, or convey other out of band information.
    /// </summary>
    public interface IMetadata : IHtml
    {
    }

    /// <summary>
    /// Includes metadata and flow content
    /// </summary>
    public interface IMetadataFlow : IFlow
    {
    }

    /// <summary>
    /// Includes metadata and phrasing content
    /// </summary>
    public interface IMetadataPhrasing : IMetadata, IPhrasing
    {
    }

    /// <summary>
    /// A content is palpable when it's neither empty nor hidden. 
    /// Elements whose model is flow content or phrasing content should have at least one node which is palpable.
    /// </summary>
    public interface IPalpable
    {
    }

    /// <summary>
    /// Form-associated content comprises elements that have a form owner, exposed by a form attribute. 
    /// A form owner is either the containing form element or the element whose id is specified in the form attribute.
    /// </summary>
    public interface IFormAssociated
    {
    }

    /// <summary>
    /// Elements that are listed in the form.elements and fieldset.elements IDL collections.
    /// </summary>
    public interface IListed : IFormAssociated
    {
    }

    /// <summary>
    /// Elements that can be associated with label elements. 
    /// </summary>
    public interface ILabelable : IFormAssociated
    {
    }

    /// <summary>
    /// Elements that can be used for constructing the form data set when the form is submitted.
    /// </summary>
    public interface ISubmittable : IFormAssociated
    {
    }

    /// <summary>
    /// Elements that can be affected when a form is reset.
    /// </summary>
    public interface IResettable : IFormAssociated
    {
    }

    /// <summary>
    /// Elements that can be child of a tr element
    /// </summary>
    public interface ITrContent : IHtml { }

}