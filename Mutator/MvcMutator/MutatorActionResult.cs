using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace HtmlMutator.MvcMutator
{
    /// <summary>
    /// Custom ActionResult class for the Mutator.
    /// Writing the binary characters to the HTTP output stream uses the <see cref="MutatorView.Render()"/> method.
    /// </summary>
    public class MutatorActionResult : ActionResult
    {
        private readonly MutatorView _mutatorView;

        /// <summary>
        /// Creates a <see cref="MutatorActionResult"/> instance from <see cref="MutatorView"/>.
        /// </summary>
        /// <param name="mutatorView"></param>
        public MutatorActionResult(MutatorView mutatorView)
        {
            _mutatorView = mutatorView;
        }

        /// <summary>
        /// Generates HTTP output stream from the <see cref="MutatorView.Render()"/> method.
        /// </summary>
        /// <param name="context">Controller context</param>
        public override void ExecuteResult(ControllerContext context)
        {
            var bytes = Encoding.ASCII.GetBytes(_mutatorView.Render().ToString());
            context.HttpContext.Response.BinaryWrite(bytes);
        }
    }
}
