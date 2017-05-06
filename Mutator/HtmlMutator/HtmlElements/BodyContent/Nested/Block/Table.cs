using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlMutator;
using HtmlMutator.Contents;
using HtmlMutator.Helpers;
using HtmlMutator.HtmlElements;

namespace HtmlMutator.HtmlElements
{
    /// <summary>
    /// The HTML Table Element (<see cref="Table"/>) represents tabular data - i.e., information expressed via a two dimensional data table.
    /// </summary>
    public class Table : HtmlElement, IFlow, IChildElements<Colgroup, Table>, IChildElements<Tr, Table>
    {
        public override string Tag => "table";

        /// <summary>
        /// The HTML <see cref="Caption"/> Element (or HTML Table Caption Element) represents the title of a table.
        /// </summary>
        public Caption Caption { get; set; }

        /// <summary>
        /// The HTML Table Column Group Element (<see cref="Colgroup"/>) defines a group of columns within a table.
        /// </summary>
        public IList<Colgroup> Colgroup { get; set; }

        /// <summary>
        /// The HTML Table Head Element (<see cref="TableElements.Thead"/>) defines a set of rows defining the head of the columns of the table.
        /// </summary>
        public Thead Thead { get; set; }

        /// <summary>
        /// The HTML Table Body Element (<see cref="TableElements.Tbody"/>) defines one or more <see cref="Tr"/> element data-rows to be the body of its parent <see cref="Table"/> element 
        /// (as long as no <see cref="Tr"/> elements are immediate children of that table element.)
        /// </summary>
        public Tbody Tbody { get; set; }

        /// <summary>
        /// The HTML Table Foot Element (<see cref="TableElements.Tfoot"/>) defines a set of rows summarizing the columns of the table.
        /// </summary>
        public Tfoot Tfoot { get; set; }

        /// <summary>
        /// The HTML element table row <see cref="Tr"/> defines a row of cells in a table. Those can be a mix of <see cref="Td"/> and <see cref="Th"/> elements.
        /// </summary>
        public IList<Tr> Trs { get; set; }

        public Table()
        {
            Colgroup = new List<Colgroup>();
            Trs = new List<Tr>();
        }

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="Colgroup"/> list.
        /// </summary>
        /// <param name="element">Colgroup element</param>
        public Table Add(params Colgroup[] elements)
        {
            Colgroup.ToList().AddRange(elements);
            return this;
        }

        /// <summary>
        /// Adds the <see cref="elements"/> to the <see cref="Tr"/> list.
        /// </summary>
        /// <param name="element">Tr element</param>
        public Table Add(params Tr[] elements)
        {
            Trs.ToList().AddRange(elements);
            return this;
        }

        /// <summary>
        /// Sets the order of the <see cref="HtmlElement.ChildElements"/> of the <see cref="Table"/>.
        /// </summary>
        public override IEnumerable<IHtml> ChildElements
        {
            get
            {

                if (Caption != null) yield return Caption;

                if (Colgroup != null)
                {
                    foreach (var cg in Colgroup)
                        yield return cg;
                }

                if (Thead != null) yield return Thead;
                if (Tbody != null) yield return Tbody;
                if (Tfoot != null) yield return Tfoot;

                if (Trs != null)
                {
                    foreach (var tr in Trs)
                        yield return tr;
                }
            }
        }

        #region Attributes

        /// <summary>
        /// This enumerated attribute indicates how the table must be aligned inside the containing document. 
        /// </summary>
        [Obsolete]
        public AlignOptions Align
        {
            get { return (AlignOptions)Enum.Parse(typeof(AlignOptions), this[nameof(Align)]); }
            set { this[nameof(Align)] = value.ToString("G"); }
        }

        /// <summary>
        /// This attribute defines the background color of a table. It consists of a 6-digit hexadecimal code as defined in sRGB and is prefixed by '#'.
        /// </summary>
        [Obsolete]
        public string Bgcolor
        {
            get { return this[nameof(Bgcolor)]; }
            set { this[nameof(Bgcolor)] = value; }
        }

        /// <summary>
        /// This integer attribute defines, in pixels, the size of the frame surrounding the table. 
        /// If set to 0, the frame attribute is set to void.
        /// </summary>
        [Obsolete]
        public int Border
        {
            get { return int.Parse(this[nameof(Border)]); }
            set { this[nameof(Border)] = value.ToString(); }
        }

        /// <summary>
        /// This attribute defines the space between the content of a cell and its border, displayed or not.
        /// </summary>
        [Obsolete]
        public string Cellpadding
        {
            get { return this[nameof(Cellpadding)]; }
            set { this[nameof(Cellpadding)] = value; }
        }

        /// <summary>
        /// This attribute defines the size of the space between two cells in a percentage value or pixels,. 
        /// </summary>
        [Obsolete]
        public string Cellspacing
        {
            get { return this[nameof(Cellspacing)]; }
            set { this[nameof(Cellspacing)] = value; }
        }

        /// <summary>
        /// This enumerated attribute defines which side of the frame surrounding the table must be displayed. 
        /// </summary>
        [Obsolete]
        public FrameOptions Frame
        {
            get { return (FrameOptions) Enum.Parse(typeof(FrameOptions), this[nameof(Frame)]) ; }
            set { this[nameof(Frame)] = value.ToString("G"); }
        }

        /// <summary>
        /// This enumerated attribute defines where rules, i.e. lines, should appear in a table.
        /// </summary>
        [Obsolete]
        public RulesOptions Rules
        {
            get { return (RulesOptions)Enum.Parse(typeof(RulesOptions), this[nameof(Rules)]); }
            set { this[nameof(Rules)] = value.ToString("G"); }
        }

        /// <summary>
        /// This attribute defines an alternative text that summarizes the content of the table. 
        /// Typically, it allows visually impaired people who are browsing the web with a Braille screen, to acquire information about the table.
        /// </summary>
        [Obsolete]
        public string Summary
        {
            get { return this[nameof(Summary)]; }
            set { this[nameof(Summary)] = value; }
        }

        /// <summary>
        /// This attribute defines the width of the table. 
        /// The width may be defined by pixels or a percentage value. 
        /// A percentage value will be defined by the width of the container in which the table is placed.
        /// </summary>
        [Obsolete]
        public string Width
        {
            get { return this[nameof(Width)]; }
            set { this[nameof(Width)] = value; }
        }

        #endregion
    }
}
