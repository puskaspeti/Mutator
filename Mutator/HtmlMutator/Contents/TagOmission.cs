using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlMutator.Contents
{
    public enum TagOmission
    {
        NoneRequired = 0,
        StartingRequired = 1,
        EndingRequired = 2,
        BothRequired = 3,
        SelfClosing = 4
    }
}
