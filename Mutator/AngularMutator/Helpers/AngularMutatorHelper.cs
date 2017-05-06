using HtmlMutator.AngularMutator.NgElements;
using HtmlMutator;
using HtmlMutator.HtmlElements;
using System;
using System.Collections.Generic;

namespace HtmlMutator.AngularMutator
{
    public static class AngularMutatorHelper
    {
        public static TModel NgApp<TModel>(this TModel element, string app) where TModel : HtmlElement, IHtml
        {
            element["ng-app"] = new NgApp(app).ToAttribute();
            return element;
        }

        public static TModel NgClass<TModel>(this TModel element, string condition) where TModel : HtmlElement, IHtml
        {
            element["ng-class"] = new NgClass(condition).ToAttribute();
            return element;
        }

        public static TModel NgInit<TModel>(this TModel element, string value) where TModel : HtmlElement, IHtml
        {
            element["ng-init"] = new NgInit(value).ToAttribute();
            return element;
        }

        public static TModel NgInit<TModel>(this TModel element, Func<TModel, string> callbackSelector, string value) where TModel : HtmlElement, IHtml
        {
            element["ng-init"] = new NgInit(callbackSelector(element), value.Replace("\"", "'")).ToAttribute();
            return element;
        }

        public static TModel NgIf<TModel>(this TModel element, string value) where TModel : HtmlElement, IHtml
        {
            element["ng-if"] = new NgIf(value).ToAttribute();
            return element;
        }

        public static TModel NgIf<TModel>(this TModel element, Func<TModel, string> callbackSelector, string value) where TModel : HtmlElement, IHtml
        {
            element["ng-if"] = new NgIf(callbackSelector(element), value).ToAttribute();
            return element;
        }

        public static TModel NgBind<TModel>(this TModel element, string model) where TModel : HtmlElement, IHtml
        {
            element["ng-bind"] = new NgBind(model).ToAttribute();
            return element;
        }

        public static TModel NgBind<TModel>(this TModel element, Func<TModel, string> callbackSelector) where TModel : HtmlElement, IHtml
        {
            element["ng-bind"] = callbackSelector(element);
            return element;
        }

        public static TModel NgModel<TModel>(this TModel element, string model) where TModel : HtmlElement, IHtml
        {
            element["ng-model"] = new NgModel(model).ToAttribute();
            return element;
        }

        public static TModel NgModel<TModel>(this TModel element, Func<TModel, string> callbackSelector) where TModel : HtmlElement, IHtml
        {
            element["ng-model"] = callbackSelector(element);
            return element;
        }

        public static TModel NgShow<TModel>(this TModel element, string model) where TModel : HtmlElement, IHtml
        {
            element["ng-show"] = new NgModel(model).ToAttribute();
            return element;
        }

        public static TModel NgShow<TModel>(this TModel element, Func<TModel, string> callbackSelector) where TModel : HtmlElement, IHtml
        {
            element["ng-show"] = callbackSelector(element);
            return element;
        }

        public static TModel NgCloak<TModel>(this TModel element) where TModel : HtmlElement, IHtml
        {
            element["ng-cloak"] = string.Empty;
            return element;
        }

        /// <summary>
        /// The ngController directive attaches a controller class to the view.
        /// </summary>
        /// <typeparam name="TModel">The type param must be derived from <see cref="HtmlElement"/>.</typeparam>
        /// <param name="element">The <see cref="HtmlElement"/>, whom the extension method is called.</param>
        /// <param name="name">Name of the controller</param>
        /// <param name="alias">Alias for the controller name</param>
        /// <returns></returns>
        public static TModel NgController<TModel>(this TModel element, string name, string alias = null) where TModel : HtmlElement, IHtml
        {
            element["ng-controller"] = new NgController(name, alias).ToAttribute();
            return element;
        }

        public static TModel NgController<TModel, TController>(this TModel element, string alias = null) 
            where TModel : HtmlElement, IHtml
            where TController : NgController, new()
        {
            element.ExtraData["ng-controller"] = new TController() { ControllerAlias = alias };
            element["ng-controller"] = ((TController)element.ExtraData["ng-controller"]).ToAttribute();
            return element;
        }

        public static TController GetController<TModel, TController>(this TModel element) where TModel : HtmlElement, IHtml
            where TController : NgController, new()
        {
            object instance = null;
            var currentElement = element as IHtml;

            while (currentElement != null)
            {
                currentElement.ExtraData.TryGetValue("ng-controller", out instance);
                currentElement = currentElement.Parent;
            }

            return (TController)instance;
        }

        public static TModel NgClick<TModel>(this TModel element, string action) where TModel : HtmlElement, IHtml
        {
            element["ng-click"] = action;
            return element;
        }

        public static TModel NgClick<TModel>(this TModel element, Func<TModel, string> callbackSelector) where TModel : HtmlElement, IHtml
        {
            element["ng-click"] = callbackSelector(element);
            return element;
        }

        public static TModel NgDblClick<TModel>(this TModel element, Func<TModel, string> callbackSelector) where TModel : HtmlElement, IHtml
        {
            element["ng-dblclick"] = callbackSelector(element);
            return element;
        }

        public static TModel NgSubmit<TModel>(this TModel element, Func<TModel, string> callbackSelector) where TModel : HtmlElement, IHtml
        {
            element["ng-submit"] = callbackSelector(element);
            return element;
        }

        /// <summary>
        /// The ngRepeat directive instantiates a template once per item from a collection.
        /// </summary>
        /// <typeparam name="TModel">>The type param must be derived from <see cref="HtmlElement"/>.</typeparam>
        /// <param name="element">The <see cref="HtmlElement"/>, whom the extension method is called.</param>
        /// <param name="collection">Collection name</param>
        /// <param name="iterator">Iterator name for the collection</param>
        /// <param name="trackBy">If you do need to repeat duplicate items, you can substitute the default tracking behavior with your own using the track by expression.</param>
        /// <param name="filters">Optional filters for the directive</param>
        /// <returns></returns>
        public static TModel NgRepeat<TModel>(this TModel element, string collection, string iterator, string trackBy = null, IEnumerable<string> filters = null) where TModel : HtmlElement
        {
            element["ng-repeat"] = new NgRepeat(collection, iterator, trackBy, filters).ToAttribute();
            return element;
        }

        /// <summary>
        /// The ngRepeat directive instantiates a template once per item from a collection.
        /// </summary>
        /// <typeparam name="TModel">>The type param must be derived from <see cref="HtmlElement"/>.</typeparam>
        /// <param name="element">The <see cref="HtmlElement"/>, whom the extension method is called.</param>
        /// <param name="collectionSelector">Collection selector for the collection</param>
        /// <param name="iterator">Iterator name for the collection</param>
        /// <param name="trackBy">If you do need to repeat duplicate items, you can substitute the default tracking behavior with your own using the track by expression.</param>
        /// <param name="filters">Optional filters for the directive</param>
        public static TModel NgRepeat<TModel>(this TModel element, Func<TModel, string> collectionSelector, string iterator, string trackBy = null, IEnumerable<string> filters = null) where TModel : HtmlElement
        {
            var collection = collectionSelector(element);
            element["ng-repeat"] = new NgRepeat(collection, iterator, trackBy, filters).ToAttribute();
            return element;
        }
    }
}
