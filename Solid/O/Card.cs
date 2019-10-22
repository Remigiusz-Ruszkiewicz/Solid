using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.O
{
    public class Card : IPay
    {
        public string Payment(decimal amount)
        {
            return $"Płatnośc kartą - {amount}";
        }
    }
}
