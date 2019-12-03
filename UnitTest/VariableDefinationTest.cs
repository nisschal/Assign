using System;
using Assignment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class VariableDefinationTest
    {
        [TestMethod]
        public void checkVariableCharacters_ifAlphabets_returnTrue()
        {
            //arrange
            VariableDefination variableDefinition = new VariableDefination();
            String word;
            bool result;

            //act
            word = "Shape";
            result = variableDefinition.isAlphabeticalVariable(word);


            //assert
            Assert.IsTrue(result);

        }
    }
}
