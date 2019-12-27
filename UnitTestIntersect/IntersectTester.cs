using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using UnitTestSample;

namespace UnitTestIntersect
{
    [TestClass]
    public class IntersectTester
    {

        [TestMethod]
        public void Test_GetIntersect()
        {
            //Arrange
            List<string> data1 = new List<string> { "1", "2", "3", "4" };
            List<string> data2 = new List<string> { "6", "3", "4" };
            List<string> expected = new List<string> { "3", "4" };

            //Act
            ListIntersect ListIntersect = new ListIntersect();
            var actual=  ListIntersect.GetIntersect(data1, data2);

            //Assert
            CollectionAssert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void TestCount_GetIntersect()
        {
            //Arrange
            List<string> data1 = new List<string> { "1", "2", "3", "4" };
            List<string> data2 = new List<string> { "6", "7", "8" };
            int expected =0;

            //Act
            ListIntersect ListIntersect = new ListIntersect();
            var actual = ListIntersect.GetIntersect(data1, data2).Count;

            //Assert
            Assert.AreEqual(expected, actual);


        }
    }
}
