using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlMutator.MvcMutator
{
    /// <summary>
    /// Provides methods and properties that are used to render start pages that use Mutator view engine.
    /// </summary>
    public static class MutatorStartPage
    {
        /// <summary>
        /// Gets or sets the layout page.
        /// </summary>
        public static LayoutMutatorView Layout { get; set; }
    }
}
