using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TriangleCalc
{
    public class RectangularTriangleCalc:ITriangleCalculator
    {

        public double CalcArea(double side1, double side2, double side3)
        {
            if (side1<=0||side2<=0||side3<=0)
                throw new System.ArgumentException("Side of triangle should be greater than zero.");

            double cathetus1;
            double cathetus2;
           
            double[] sides = new double [3];
            sides[0] = side1;
            sides[1] = side2;
            sides[2] = side3;

            sides = sides.OrderByDescending(c => c).ToArray();
            cathetus1 = sides[1];
            cathetus2 = sides[2];

            double area = (cathetus1* cathetus2)*0.5;
            return area;
        }

        public double CalcArea(ITriangle triangle)
        {
            double cathetus1;
            double cathetus2;

            double[] sides = new double[3];
            sides[0] = triangle.TriangleSide1;
            sides[1] = triangle.TriangleSide2;
            sides[2] = triangle.TriangleSide3;

            sides = sides.OrderByDescending(c => c).ToArray();
            cathetus1 = sides[1];
            cathetus2 = sides[2];

            double area = (cathetus1 * cathetus2) * 0.5;
            return area;
        }

    }


}
