using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleCalc
{
    public class RectangularTriangle:ITriangle
    {
        private double triangleSide1;
        private double triangleSide2;
        private double triangleSide3;

        public double TriangleSide1
        {
            get
            {
                return triangleSide1;
            }
            set
            {
                if (value<=0)
                    throw new System.ArgumentException("Side of triangle should be greater than zero.");
                triangleSide1 = value;
            }
        }

        public double TriangleSide2
        {
            get
            {
                return triangleSide2;
            }
            set
            {
                if (value <= 0)
                    throw new System.ArgumentException("Side of triangle should be greater than zero.");
                triangleSide2 = value;
            }
        }

        public double TriangleSide3
        {
            get
            {
                return triangleSide3;
            }
            set
            {
                if (value <= 0)
                    throw new System.ArgumentException("Side of triangle should be greater than zero.");
                triangleSide3 = value;
            }
        }
    }
}
