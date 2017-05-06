using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HtmlMutator.HtmlElements;
using HtmlMutator.AngularMutator;
using HtmlMutator.BootstrapMutator;

namespace UnitTestProject
{
    [TestClass]
    public class HtmlMutatorTests
    {
        [TestMethod]
        public void Div_ShouldBeCreated()
        {
            var div = new Div();
            Assert.IsNotNull(div);
        }

        [TestMethod]
        public void Div_ShouldEqual()
        {
            var div = new Div().Render().ToString();
            Assert.AreEqual(div, "<div></div>");
        }

        [TestMethod]
        public void Div_AttributesShouldEqual()
        {
            var div = new Div { Class="test", Id = "testdiv1" }.Render().ToString();
            Assert.AreEqual(div, @"<div class=""test"" id=""testdiv1""></div>");
        }

        [TestMethod]
        public void Div_ShouldContainText()
        {
            var div = new Div().Add("test").Render().ToString();
            Assert.AreEqual(div, "<div>test</div>");
        }

        [TestMethod]
        public void Div_SpanShouldBeAppendInsideDiv()
        {
            var divWithSpan = new Div().Add(new Span()).Render().ToString();
            Assert.AreEqual(divWithSpan, @"<div><span></span></div>");
        }

        [TestMethod]
        public void Div_ShouldHaveRowAttribute()
        {
            var divWithRow = new Div { Class=Bootstrap.Row }.Render().ToString();
            Assert.AreEqual(divWithRow, @"<div class=""row""></div>");
        }

        [TestMethod]
        public void Div_ShouldContainNgClick()
        {
            var divWithNgClick = new Div().NgClick("todoCtrl.onclick()").Render().ToString();
            Assert.AreEqual(divWithNgClick, @"<div ng-click=""todoCtrl.onclick()""></div>");
        }
    }
}
