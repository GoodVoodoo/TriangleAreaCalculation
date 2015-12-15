using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleCalc
{
    interface ITriangleCalculator
    {
        /// <summary>
        /// Calculates area of a triangle
        /// </summary>
        /// <param name="side1">trianlge side 1 length</param>
        /// <param name="side2">trianlge side 2 length</param>
        /// <param name="side3">trianlge side 3 length</param>
        /// <returns></returns>
        double CalcArea(double side1, double side2, double side3);
        
        /// <summary>
        /// Calculates area of a triangle
        /// </summary>
        /// <param name="triangle">ITriangle object</param>
        /// <returns></returns>
        double CalcArea(ITriangle triangle);
    }
}
