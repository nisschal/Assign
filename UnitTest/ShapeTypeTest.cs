using System;
using Assignment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class ShapeTypeTest
    {
        [TestMethod]
        public void IsCircle_stringCircle_returnTrue()
        {
            //arrange
            bool result;
            ShapeFactoryDefination sd = new ShapeFactoryDefination();

            //act
            result = sd.isCircle("circle");

            //assert
            Assert.IsTrue(result);
        }
        public void isRectangle_stringRectangle_returnTrue()
        {
            //arrange
            bool result;
            ShapeFactoryDefination sd = new ShapeFactoryDefination();

            //act
            result = sd.isCircle("rectangle");

            //assert
            Assert.IsTrue(result);
        }
    }
}
