using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Interface02
{
    internal interface IShape
    {
        double CalArea();
        int CompareTo(Square? other);
    }
}
