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
        [TestMethod]
        public void AddString()
        {
            //arrange
            ListAttrubutes<string> list = new ListAttrubutes<string>();

            //act
            list.Add("words");
            list.Add("Test");


            //assert
            Assert.AreNotEqual("Test", list[0]);
        }
        [TestMethod]
        public void AddTestDouble()
        {
            //arrange
            ListAttrubutes<double> list = new ListAttrubutes<double>();

            //act
            list.Add(.32);
            list.Add(19.55);


            //assert
            Assert.AreNotEqual(19.55, list[0]);
        }
        [TestMethod]
        public void RemoveStringTest()
        {
            //arrange
            ListAttrubutes<int> list = new ListAttrubutes<int>();
            string [] testIntArray = new string[5] {"Dog","Bird", "Lizard", "Frog", "Cat",};
            
            //act

            list.Remove(1);


            //assert
            Assert.IsFalse(false, "Dog" );
        }
        //public void RemoveintTest()// you are here
        //{
        //    //arrange
        //    ListAttrubutes<int> list = new ListAttrubutes<int>();
        //    int[] testIntArray = new int[5] { 1, 2, 3, 4, 5, };

        //    //act
        //    list.Remove(3); 
        //    bool removeInt = false;
        //    for ()
        //    {
        //        if removeInt == 3;
        //    }
            


        //    //assert
        //    Assert.IsFalse(false, 3);
        //}
    }
}
//arrange
//act
//assert