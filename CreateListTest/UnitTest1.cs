using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CreateListProject;

namespace CreateListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddIntTest()
        {
            //arrange
            ListAttrubutes<int> list = new ListAttrubutes<int>();
            int expectedResult = 22;
            list.Add(5);
            list.Add(3);
            list.Add(5);
            list.Add(22);
            list.Add(50);
            list.Add(2);
            list.Add(100);

            //assert
            Assert.AreEqual(expectedResult, list[3]);
        }
        [TestMethod]
        public void AddTestLargeNumber()
        {
            //arrange
            ListAttrubutes<int> list = new ListAttrubutes<int>();
            int expectedResult = 2147483647;
            list.Add(2147483647);
            //assert
            Assert.AreEqual(expectedResult, list[0]);
        }
        [TestMethod]
        public void AddTestNegNumber()
        {
            //arrange
            ListAttrubutes<int> list = new ListAttrubutes<int>();

            int expectedResult = -22;
            list.Add(-5);
            list.Add(-3);
            list.Add(-5);
            list.Add(-22);
            list.Add(-50);
            list.Add(-2);
            list.Add(-100);

            //assert
            Assert.AreEqual(expectedResult, list[3]);
        }
        [TestMethod]
        public void AddString()
        {
            //arrange
            ListAttrubutes<string> list = new ListAttrubutes<string>();
            string expectedResult = "Test";

            //act
            list.Add("words");
            list.Add("Test");


            //assert
            Assert.AreNotSame(expectedResult, list[0]);
        }
        [TestMethod]
        public void AddTestDouble()
        {
            //arrange
            ListAttrubutes<double> list = new ListAttrubutes<double>();
            double expectedResult = 19.55;
            //act
            list.Add(.32);
            list.Add(19.55);


            //assert
            Assert.AreNotEqual(expectedResult, list[0]);
        }
        [TestMethod]
        public void RemoveStringTest()
        {
            //arrange
            ListAttrubutes<string> list = new ListAttrubutes<string>();
            string[] testIntArray = new string[5] { "Dog", "Bird", "Lizard", "Frog", "Cat", };

            //act

            list.Remove("dog");


            //assert
            Assert.IsFalse(false, "Dog");
        }

        [TestMethod]
        public void CountIntTest()
        {
            //arrange
            ListAttrubutes<int> list = new ListAttrubutes<int>() { 1, 2, 3, 4, 5 };
            int expectedResult = 5;
            //act
            int actualResult = list.Count;
            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void CountStringTest()
        {
            ListAttrubutes<string> list = new ListAttrubutes<string>() { "Dog", "Bird", "Lizard" };
            int expectedResult = 3;
            //act
            int actualResult = list.Count;
            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void CountDoubtTest()
        {
            //arrange
            ListAttrubutes<double> list = new ListAttrubutes<double>() { 123.14, 334.54, 7732.00, 421.34, 10 };
            int expectedResult = 3;
            //act
            int actualResult = list.Count;
            //assert
            Assert.AreNotEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void RemoveIntTest()
        {
            //arrange
            ListAttrubutes<int> list = new ListAttrubutes<int>();
            int[] testIntArray = new int[5] { 1, 2, 3, 4, 5 };
            //act
            list.Remove(3);
            //assert
            Assert.IsFalse(false);
        }
        [TestMethod]
        public void ToStringTest()
        {
            //arrange
            ListAttrubutes<string> list = new ListAttrubutes<string>() { "Dog", "Bird", "Lizard" };
            //act
            string actualResult = list.ToString();
            string expectedResult = "Dog Bird Lizard ";
            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

//arrange
//act
//assert