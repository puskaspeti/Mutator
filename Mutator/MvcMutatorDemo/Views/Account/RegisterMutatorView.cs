//using HtmlMutator.Contents;
//using HtmlMutator;
//using HtmlMutator.MvcMutator;
//using MvcMutatorDemo.Models;
//using MvcMutatorDemo.Views.Shared;
//using System.Web.Mvc.Html;
//using System.Collections.Generic;

//namespace MvcMutatorDemo.Views.Account
//{
//    public class RegisterMutatorView : MutatorModelView<RegisterViewModel>
//    {
//        public override List<IHtml> CreateDom()
//        {
//            //Layout = new _Layout();

//            return new List<IHtml>
//            {
//                new PhrasingContent(Html.Partial("~/Views/Account/Register.cshtml", Model, ViewData))
//            };
//        }
//    }
//}