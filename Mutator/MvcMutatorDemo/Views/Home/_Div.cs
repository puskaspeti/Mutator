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
    public class _Div : MutatorModelView<int>
    {
        public override List<IHtml> CreateDom()
        {
            Layout = LayoutMutatorView.EmptyLayout;
            return new List<IHtml>
            {
                new Div { Class="test" }.Add(Model.ToString())
            };
        }
    }
}