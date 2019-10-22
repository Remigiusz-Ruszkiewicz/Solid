using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.D
{
    public class E_Mail : ISender
    {
        public string Method()
        {
            return "E-Mail";
        }
    }
}
