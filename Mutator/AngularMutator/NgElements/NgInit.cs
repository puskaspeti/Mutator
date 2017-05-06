using HtmlMutator.Contents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlMutator.AngularMutator.NgElements
{

    public class NgInit : AttributeValue
    {
        private string _initValue;

        public NgInit(string value, string initValue = null)
        {
            Value = value;
            _initValue = initValue;
        }

        public override string ToAttribute()
        {
            return _initValue != null ? $"{Value}={_initValue}" : Value.ToString();
        }
    }
}
