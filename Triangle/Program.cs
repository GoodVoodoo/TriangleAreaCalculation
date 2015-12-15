using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TriangleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            ITriangleCalculator rectTriangleAreaCalc = new RectangularTriangleCalc();
            double area = rectTriangleAreaCalc.CalcArea(6, 8, 10);
            Console.WriteLine(area);
            Console.ReadKey();
        }
    }
}
