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
    public class Test2 : MutatorView
    {
        public override List<IHtml> CreateDom()
        {
            var document = new List<IHtml>();

            for (var i = 0; i < 100000; i++)
                document.Add(new Div().Add(i.ToString()));

            return document;
        }
    }
}