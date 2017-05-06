//using HtmlMutator.MvcMutator;
//using System.Collections.Generic;
//using HtmlMutator;
//using MvcMutatorDemo.Models;
//using System.Web.Mvc.Html;
//using HtmlMutator.HtmlElements;
//using MvcMutatorDemo.Views.Shared;

//namespace MvcMutatorDemo.Views.Account
//{
//    public class LoginMutatorView : MutatorModelView<LoginViewModel>
//    {
//        public override List<IHtml> CreateDom()
//        {
//            //Layout = new _Layout();

//            return new List<IHtml>
//            {
//                new Div().Add(Html.Partial("~/Views/Account/Login.cshtml", Model, ViewData))
//            };
//        }
//    }
//}