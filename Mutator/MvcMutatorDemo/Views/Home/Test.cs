using System.Collections.Generic;
using HtmlMutator.Helpers;
using HtmlMutator.Contents;
using HtmlMutator;
using HtmlMutator.HtmlElements;
using HtmlMutator.AngularMutator;
using HtmlMutator.MvcMutator;
using MvcMutatorDemo.Scripts.controllers;
using MvcMutatorDemo.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace MvcMutatorDemo.Views.Home
{
    public class Test : MutatorView
    {
        public override List<IHtml> CreateDom()
        {
            var document = new List<IHtml>();

            for (var i = 0; i < 5000; i++)
                document.Add(new PhrasingContent(Html.Partial(new _Div(), i, Url)));

            return document;
        }
    }
}