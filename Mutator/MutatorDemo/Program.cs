using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlMutator.Contents;
using HtmlMutator.HtmlElements;

namespace MutatorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var html = new Html
            {
                Lang = "hu",
                Id = "test",
                Head = new Head()
                    .Add(new Script().Add("")),
                Body = new Body()
                .Add(new Div { Class = "row", Id = "alma" }
                .Add(new Ul()
                            .Add(new Li()
                                .Add(new Img {["src"] = "alma.hu"})
                            )
                            .Add(new Li()
                                .Add(new A()
                                    .Add(new Button())
                                )
                            )
                        )
                    .Add(new Span()
                        .Add("Barack")
                        .Add(new Input())
                        .Add(new Br())
                    )
                )
                .Add(new Table
                {
                    Caption = new Caption().Add("Hello").Add(" World"),
                    Colgroup = new List<Colgroup>
                    {
                        new Colgroup { ["span"] = "2" }.Add(new Col()),
                        new Colgroup().Add(new Col()).Add(new Col())
                    },
                    Thead = new Thead()
                    .Add(new Tr()
                        .Add(new Th()
                            .Add("Header content 1")
                        )
                        .Add(new Th()
                            .Add("Header content 2")
                        )
                    ),
                    //Tbody = new Tbody()
                    //    .Add(new Tr()
                    //        .Add(new Td()
                    //            .Add(new PhrasingContent("Body content 1"))
                    //        )
                    //        .Add(new Td()
                    //            .Add(new PhrasingContent("Body content 2"))
                    //    )
                    //),
                    Tfoot = new Tfoot()
                        .Add(new Tr()
                            .Add(new Td()
                                .Add("Footer content 1")
                            )
                            .Add(new Td()
                                .Add("Footer content 2")
                        )
                    ),
                    Trs = new List<Tr>
                    {
                        new Tr()
                            .Add(new Td()
                                .Add("Body content 1")
                            )
                            .Add(new Td()
                                .Add("Body content 2")
                         )
                    }
                })
                .Add(new Div()
                    .Add(new Div()
                        .Add("Alma ")
                        .Add("Körte")
                    )
                )
                .Add(new Script {["type"] = "text/javascript"}.Add("function(){ console.log(\"a\"); }()"))
            };

            var htmlString = html.Render();

            Console.WriteLine(htmlString.ToString());
            Console.ReadKey();
        }
    }
}
