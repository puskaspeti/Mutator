using HtmlMutator.HtmlElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlMutator.Helpers;

namespace HtmlMutator.BootstrapMutator.BootstrapElements
{
    public class Row : Div
    {
        public Row()
        {
            this.AddClass("row");
        }
    }
}
