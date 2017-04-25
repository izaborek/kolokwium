using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Figure;



namespace Figure.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var rectangle = new Rectangle();
            double rectangle1 = rectangle.RectanglePoint(2, 3);
            Assert.AreEqual(rectangle1, 3);

        }
    }
}
