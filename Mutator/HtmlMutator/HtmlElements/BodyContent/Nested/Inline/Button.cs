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
    /// The HTML <see cref="Button"/> Element represents a clickable button.
    /// </summary>
    public class Button : InlineHtmlElement, IFlow, IPhrasing, IInteractive, IListed, ILabelable, ISubmittable, IFormAssociated, IPalpable, IChildElements<IPhrasing, Button>, IChildElements<PhrasingContent, Button>
    {
        public override string Tag => "button";

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="HtmlElement.ChildElements"/> list.
        /// </summary>
        /// <param name="element">Child elements</param>
        public Button Add(params IPhrasing[] elements)
        {
            AddInternal(elements);
            return this;
        }

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="HtmlElement.ChildElements"/> list.
        /// </summary>
        /// <param name="element">Child elements</param>
        public Button Add(params PhrasingContent[] elements)
        {
            AddInternal(elements);
            return this;
        }

        #region Attributes

        /// <summary>
        /// This Boolean attribute indicates that the user cannot interact with the button. If this attribute is not specified, the button inherits its setting from the containing element.
        /// If there is no containing element with the disabled attribute set, then the button is enabled.
        /// </summary>
        public bool Disabled
        {
            get { return this[nameof(Disabled)].FromStringToBool(); }
            set { this[nameof(Disabled)] = value.FromBoolToString(); }
        }

        /// <summary>
        /// The name of the button, which is submitted with the form data.
        /// </summary>
        public string Name
        {
            get { return this[nameof(Name)]; }
            set { this[nameof(Name)] = value; }
        }

        /// <summary>
        /// The type of the button. Possible values are:
        /// - submit: The button submits the form data to the server. This is the default if the attribute is not specified, or if the attribute is dynamically changed to an empty or invalid value.
        /// - reset: The button resets all the controls to their initial values.
        /// - button: The button has no default behavior. It can have client-side scripts associated with the element's events, which are triggered when the events occur.
        /// - menu: The button opens a popup menu defined via its designated menu element.
        /// </summary>
        public ButtonTypeEnum Type
        {
            get { return (ButtonTypeEnum)Enum.Parse(typeof(ButtonTypeEnum), this[nameof(Type)]); }
            set { this[nameof(Type)] = value.ToString("G").ToLower(); }
        }

        /// <summary>
        /// The initial value of the button. 
        /// It defines the value associated with the button which is submitted with the form data.  
        /// This value is passed to the server in params when the form is submitted.
        /// </summary>
        public string Value
        {
            get { return this[nameof(Value)]; }
            set { this[nameof(Value)] = value; }
        }

        #endregion
    }
}
