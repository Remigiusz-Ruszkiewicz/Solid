using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.I
{
    public interface IStandard: IGlass
    {
        string Open();
        string Close();
    }
}
