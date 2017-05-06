using HtmlMutator.Contents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlMutator.AngularMutator.NgElements
{

    public class NgController : AttributeValue
    {
        public string ControllerName { get; set; }
        public string ControllerAlias { get; set; }

        public NgController(string name, string alias = null)
        {
            ControllerName = name;
            ControllerAlias = alias;
        }

        public override string ToAttribute()
        {
            return ControllerAlias != null ? $"{ControllerName} as {ControllerAlias}" : ControllerName;
        }
    }
}
