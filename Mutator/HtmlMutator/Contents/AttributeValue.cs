using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlMutator
{
    public class AttributeValue
    {
        public object Value { get; set; }

        public AttributeValue() { }

        public AttributeValue(object value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Returns the attribute value as string.
        /// </summary>
        /// <returns></returns>
        public virtual string ToAttribute() => Value.ToString();

        public static implicit operator AttributeValue(string value) => new AttributeValue(value);
        public static implicit operator string(AttributeValue value) => value.ToAttribute();
    }
}
