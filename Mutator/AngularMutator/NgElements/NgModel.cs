using HtmlMutator.Contents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlMutator.AngularMutator.NgElements
{
    internal class NgModel : AttributeValue
    {
        public NgModel(string model)
        {
            Value = model;
        }

    }
}
