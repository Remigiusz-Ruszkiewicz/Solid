using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.D
{
    public class SMS : ISender
    {
        public string Method()
        {
            return "SMS";
        }
    }
}
