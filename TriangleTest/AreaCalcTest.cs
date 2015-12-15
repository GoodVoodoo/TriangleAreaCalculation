using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleCalc;

namespace TriangleTest
{
    [TestClass]
    public class AreaCalcTest
    {
        RectangularTriangleCalc rectTriangleCalc = new RectangularTriangleCalc();
        [TestMethod]
        public void RectTriangleAreaCalcTest1()
        {
            double area = rectTriangleCalc.CalcArea(6.0, 8.0, 10.0);
            Assert.IsNotNull(area);
            Assert.IsTrue(area == 24);
        }

        [TestMethod]
        public void RectTriangleAreaCalcTest2()
        {
            RectangularTriangle rectangularTriangle = new RectangularTriangle();
            rectangularTriangle.TriangleSide1 = 6.0;
            rectangularTriangle.TriangleSide2 = 8.0;
            rectangularTriangle.TriangleSide3 = 10.0;
            double area = rectTriangleCalc.CalcArea(rectangularTriangle);
            Assert.IsNotNull(area);
            Assert.IsTrue(area == 24);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Side of triangle should be greater than zero.")]
        public void Side1ExceptionTest()
        {
            double area = rectTriangleCalc.CalcArea(-6.0, 8.0, 10.0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Side of triangle should be greater than zero.")]
        public void Side2ExceptionTest()
        {
            double area = rectTriangleCalc.CalcArea(6.0, -8.0, 10.0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Side of triangle should be greater than zero.")]
        public void Side3ExceptionTest()
        {
            double area = rectTriangleCalc.CalcArea(6.0, 8.0, -10.0);
        }
    }

    [TestClass]
    public class RectTriangleTest
    {
        RectangularTriangle rectangularTriangle = new RectangularTriangle();

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Side of triangle should be greater than zero.")]
        public void TriangleSide1ExceptionTest()
        {
            rectangularTriangle.TriangleSide1 = -6.0;
            rectangularTriangle.TriangleSide2 = 8.0;
            rectangularTriangle.TriangleSide3 = 10.0;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Side of triangle should be greater than zero.")]
        public void TriangleSide2ExceptionTest()
        {
            rectangularTriangle.TriangleSide1 = 6.0;
            rectangularTriangle.TriangleSide2 = -8.0;
            rectangularTriangle.TriangleSide3 = 10.0;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Side of triangle should be greater than zero.")]
        public void TriangleSide3ExceptionTest()
        {
            rectangularTriangle.TriangleSide1 = 6.0;
            rectangularTriangle.TriangleSide2 = 8.0;
            rectangularTriangle.TriangleSide3 = -10.0;
        }
    }
}
