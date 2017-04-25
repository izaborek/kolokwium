using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Figure;



namespace Figure.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRectangle()
        {
            var rectangle = new Rectangle();
            double rectangle1 = rectangle.rectangle(1, 2, 3, 4);
            Assert.AreEqual(rectangle1,4 );

        }
    }
}
