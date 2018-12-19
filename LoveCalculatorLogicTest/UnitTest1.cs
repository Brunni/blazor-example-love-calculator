using LoveCalculatorLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LoveCalculatorLogicTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var loveCalculator = new LoveCalculator();
            bool calculateLove = loveCalculator.CalculateLove("Michael", "Sina");
            Assert.IsTrue(calculateLove);
        }

        [TestMethod]
        public void TestMethod1b()
        {
            var loveCalculator = new LoveCalculator();
            bool calculateLove = loveCalculator.CalculateLove("Sina", "Michael");
            Assert.IsTrue(calculateLove);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var loveCalculator = new LoveCalculator();
            bool calculateLove = loveCalculator.CalculateLove("Carsten", "Sina");
            Assert.IsFalse(calculateLove);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var loveCalculator = new LoveCalculator();
            bool calculateLove = loveCalculator.CalculateLove("Sina", "Carsten");
            Assert.IsFalse(calculateLove);
        }
    }
}
