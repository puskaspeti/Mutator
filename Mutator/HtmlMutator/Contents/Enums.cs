namespace HtmlMutator.Contents
{
    /// <summary>
    /// Global attribute <see cref="HtmlElement.Dir"/> values.
    /// </summary>
    public enum DirEnum
    {
        Ltr,
        Rtl,
        Auto
    }

    /// <summary>
    /// Global attribute <see cref="HtmlElement.Translate"/> values.
    /// </summary>
    public enum TranslateEnum
    {
        Empty,
        Yes,
        No
    }

    /// <summary>
    /// Button attribute <see cref="HtmlElements.BodyContent.Nested.Inline.Button.Type"/> values.
    /// </summary>
    public enum ButtonTypeEnum
    {
        Submit,
        Reset,
        Button,
        Menu
    }

    /// <summary>
    /// A attribute <see cref="A.Target"/> values.
    /// </summary>
    public enum ATargetEnum
    {
        _Self,
        _Blank,
        _Parent,
        _Top
    }

    /// <summary>
    /// Ul attribute <see cref="Ul.Type"/> values.
    /// </summary>
    public enum UlTypeEnum
    {
        Circle,
        Disc,
        Square,
        Triangle
    }

    /// <summary>
    /// Table attribute <see cref="Table.Align"/> values.
    /// </summary>
    public enum AlignOptions
    {
        Left,
        Center,
        Right
    }

    /// <summary>
    /// Table attribute <see cref="Table.Rules"/> values.
    /// </summary>
    public enum RulesOptions
    {
        None,
        Groups,
        Rows,
        Columns,
        All
    }

    /// <summary>
    /// Table attribute <see cref="Table.Frame"/> values.
    /// </summary>
    public enum FrameOptions
    {
        Above,
        Hsides,
        Lhs,
        Border,
        Below,
        Box,
        Vsides,
        Rhs,
        Void,
    }

    public enum InputTypeOptions
    {
        Button,
        Checkbox,
        Color,
        Date,
        DateTime,
        DateTime_Local,
        Email,
        File,
        Hidden,
        Image,
        Month,
        Number,
        Radio,
        Range,
        Reset,
        Search,
        Submit,
        Tel,
        Text,
        Time,
        Url,
        Week
    }
}
