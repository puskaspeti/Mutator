using HtmlMutator;
using HtmlMutator.Contents;
using HtmlMutator.Helpers;
using HtmlMutator.HtmlElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlMutator
{
    public static class MutatorExtensions
    {
        /// <summary>
        /// Adds new value to the <see cref="Class"/> attribute.
        /// </summary>
        /// <param name="classValue">New class value</param>
        /// <returns></returns>
        public static TModel AddClass<TModel>(this TModel model, params AttributeValue[] classValue) where TModel : HtmlElement, IHtml
        {
            try
            {
                model.Class = model.Class + " " + string.Join(" ", classValue.ToAttribute());
            }
            catch
            {
                model.Class = string.Join(" ", classValue.ToAttribute());
            }
            
            return model;
        }

        /// <summary>
        /// Adds new value to the <see cref="Style"/> attribute.
        /// </summary>
        /// <param name="styleValue">New style value</param>
        /// <returns></returns>
        public static TModel AddStyle<TModel>(this TModel model, AttributeValue styleValue) where TModel : HtmlElement, IHtml
        {
            try
            {
                model.Style = model.Style + " " + styleValue.ToAttribute();
            }
            catch
            {
                model.Style = styleValue.ToAttribute();
            }

            return model;
        }
    }
}
