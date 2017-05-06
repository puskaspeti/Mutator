using HtmlMutator.Contents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMutatorDemo.Styles
{
    public class MutatorBootstrap : MutatorAttribute
    {
        public MutatorBootstrap(object value) : base(value)
        {
        }

        public string Col => "row";
    }
}