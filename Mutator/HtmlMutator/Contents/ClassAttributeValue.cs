namespace HtmlMutator
{
    public class ClassAttributeValue : AttributeValue
    {
        public ClassAttributeValue() { }

        public ClassAttributeValue(object value)
        {
            this.Value = value;
        }

        public static implicit operator ClassAttributeValue(string value) => new ClassAttributeValue(value);
        public static implicit operator string(ClassAttributeValue value) => value.ToAttribute();
    }
}
