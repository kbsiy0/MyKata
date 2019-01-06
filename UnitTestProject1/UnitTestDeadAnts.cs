using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestDeadAnts
    {
        [TestMethod]
        public void TestAllLive()
        {
            Assert.AreEqual(0, Kata.DeadAnts.DeadAntCount("ant ant ant ant"));
        }

        [TestMethod]
        public void TestSomeDead()
        {
            Assert.AreEqual(2, Kata.DeadAnts.DeadAntCount("ant anantt aantnt"));
            Assert.AreEqual(1, Kata.DeadAnts.DeadAntCount("ant ant .... a nt"));
        }

        [TestMethod]
        public void TestAllDead()
        {
            Assert.AreEqual(4, Kata.DeadAnts.DeadAntCount("a nt .nat nta...an t"));
        }

        [TestMethod]
        public void TestNull()
        {
            Assert.AreEqual(0, Kata.DeadAnts.DeadAntCount(null));
        }
    }
}
