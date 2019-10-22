using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.I
{
    public class Door : IStandard
    {
        public string Close()
        {
            return "Zamknięte";
        }

        public int Glasses()
        {
            return 1;
        }

        public string Open()
        {
            return "Otwarte";
        }
    }
}
