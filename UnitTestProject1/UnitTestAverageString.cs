using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestAverageString
    {
        [TestMethod]
        public void TestNormal()
        {
            Assert.AreEqual("four", Kata.AverageString.Average("zero nine five two")); // 16 / 4 = 4 
            Assert.AreEqual("three", Kata.AverageString.Average("one two three four five")); // 15 / 5 = 3 
        }

        [TestMethod]
        public void TestFloor()
        {
            Assert.AreEqual("three", Kata.AverageString.Average("four six two three")); // 15 / 4 = 3.75
            Assert.AreEqual("four", Kata.AverageString.Average("five four")); // 9 / 2 = 4 
            Assert.AreEqual("two", Kata.AverageString.Average("one one eight one")); // 11 / 4 = 2.75
        }

        [TestMethod]
        public void TestAllZero()
        {
            Assert.AreEqual("zero", Kata.AverageString.Average("zero zero zero zero zero")); // 0 / 5 = 0
        }

        [TestMethod]
        public void TestEmptyString()
        {
            Assert.AreEqual("n/a", Kata.AverageString.Average("")); // EmptyString
        }
    }
}
