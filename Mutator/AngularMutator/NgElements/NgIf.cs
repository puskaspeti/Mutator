using HtmlMutator.Contents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlMutator.AngularMutator.NgElements
{

    public class NgIf : AttributeValue
    {
        private string _otherValue;

        public NgIf(string value, string otherValue = null)
        {
            Value = value;
            _otherValue = otherValue;
        }

        public override string ToAttribute()
        {
            return _otherValue != null ? $"{Value}=={_otherValue}" : Value.ToString();
        }
    }
}
