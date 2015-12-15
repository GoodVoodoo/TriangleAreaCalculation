using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleCalc
{
    public interface ITriangle
    {
        double TriangleSide1 { get; set; }
        double TriangleSide2 { get; set; }
        double TriangleSide3 { get; set; }
    }
}
