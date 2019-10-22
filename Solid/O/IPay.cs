using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.O
{
    public interface IPay
    {
        string Payment(decimal amount);
    }
}
