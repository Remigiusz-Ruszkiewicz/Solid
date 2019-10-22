using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.O
{
    class Cash : IPay
    {
        public string Payment(decimal amount)
        {
            return $"Płatnośc gotówką - {amount}";
        }
    }
}
