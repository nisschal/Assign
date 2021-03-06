﻿using System;
using Assignment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class FactoryDefinationTest
    {
        [TestMethod]
        public void isShape()
        {
            //assign
            bool result;
            String type;
            FactoryProducerDefination fp = new FactoryProducerDefination();

            //act
            type = "shape";
            result = fp.isShape(type);

            //assert
            Assert.IsTrue(result);
        }
    }
}
