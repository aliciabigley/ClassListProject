using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CreateListProject;

namespace CreateListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddTest()
        {
            //arrange
            ListAttrubutes<int> list = new ListAttrubutes<int>();

            list.Add(5);
            list.Add(3);
            list.Add(5);
            list.Add(22);
            list.Add(50);
            list.Add(2);
            list.Add(100);

            //assert
            Assert.AreEqual(22, list[3]);
        }
        [TestMethod]
        public void AddTestLargeNumber()
        {
            //arrange
            ListAttrubutes<int> list = new ListAttrubutes<int>();

            list.Add(2147483647);
            //assert
            Assert.AreEqual(2147483647, list[0]);
        }
        [TestMethod]
        public void AddTestNegNumber()
        {
            //arrange
            ListAttrubutes<int> list = new ListAttrubutes<int>();

            list.Add(-5);
            list.Add(-3);
            list.Add(-5);
            list.Add(-22);
            list.Add(-50);
            list.Add(-2);
            list.Add(-100);

            //assert
            Assert.AreEqual(-22, list[3]);
        }
    }
}
//arrange
//act
//assert