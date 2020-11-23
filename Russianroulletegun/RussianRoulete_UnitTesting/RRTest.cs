using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Russianroulletegun;

namespace RussianRoulete_UnitTesting
{
    [TestClass]
    public class RRTest
    {
        //defining an object with in the class Roullete

        Roullete Obj_test = new Roullete();
        //first testing
        [TestMethod]
        public void positive()
        {
            //Actual - we need to provide some data to get an output
            var actual = Obj_test.Bulleteloop(5);
            //Assert - we need to check the output we get is correct or not
            Assert.AreEqual(expected: 6, actual);
        }
        //Second testing
        [TestMethod]
        public void Negative()
        {
            //Act - we need to provide some data to get an output
            var actual = Obj_test.Bulleteloop(4);
            //Assert - we need to check the output we get is correct or not
            Assert.AreNotEqual(notExpected: 3, actual);
        }
    }
}
