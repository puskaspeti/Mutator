using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlMutator.HtmlElements;
using HtmlMutator.Contents;
using HtmlMutator;

namespace HtmlMutator.Helpers
{
    /// <summary>
    /// Internal helper class for the Mutator.
    /// </summary>
    internal static class MutatorHelper
    {
        /// <summary>
        /// Creates the opening tag with attributes for the given element.
        /// </summary>
        /// <param name="tagName">Tag name</param>
        /// <param name="tagAttributes">Tag attributes</param>
        /// <param name="isSelfCLosing">Is self closing</param>
        /// <returns>Opening tag</returns>
        internal static string CreateOpeningTagWithAttributes(string tagName, Dictionary<string, string> tagAttributes, bool isSelfCLosing)
        {
            var sb = new StringBuilder();
            sb.Append($"<{tagName}");

            foreach (var attribute in tagAttributes)
                sb.Append($" {attribute.Key}=\"{attribute.Value}\"");

            return isSelfCLosing ?
                sb.Append("/>").ToString()
                : sb.Append(">").ToString();
        }

        internal static string ToAttribute(this IEnumerable<AttributeValue> attributeValues)
        {
            var attributeValueStrings = new List<string>();
            attributeValues.ToList().ForEach(v => attributeValueStrings.Add(v.ToAttribute()));
            return string.Join(" ", attributeValueStrings);
        }

        /// <summary>
        /// Creates HTML compatible string output from bool input.
        /// </summary>
        /// <param name="input">bool input</param>
        /// <returns>string ouput.</returns>
        internal static string FromBoolToString(this bool input) => input.ToString() == true.ToString() ? "true" : "false";

        /// <summary>
        /// Creates bool output from string input.
        /// </summary>
        /// <param name="input">string input</param>
        /// <returns>bool output</returns>
        internal static bool FromStringToBool(this string input) => input == "true";

        /// <summary>
        /// Creates HTML compatible string output from nullable bool input.
        /// </summary>
        /// <param name="input">Nullable bool input</param>
        /// <returns>string ouput.</returns>
        internal static string FromNullableBoolToString(this bool? input) => input.HasValue ? (input.ToString() == true.ToString() ? "true" : "false") : "";

        /// <summary>
        /// Creates nullable bool output from string input.
        /// </summary>
        /// <param name="input">string input</param>
        /// <returns>Nullable bool output</returns>
        internal static bool? FromStringToNullableBool(this string input) => input == "" ? (bool?) null : input == "true";
    }
}
