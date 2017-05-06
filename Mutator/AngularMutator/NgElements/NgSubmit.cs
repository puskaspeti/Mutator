using HtmlMutator.Contents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlMutator.AngularMutator.NgElements
{

    public class NgSubmit : AttributeValue
    {
        public NgSubmit(string submit)
        {
            Value = submit;
        }
    }
}
