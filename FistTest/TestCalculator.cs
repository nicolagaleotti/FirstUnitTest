using Microsoft.VisualStudio.TestTools.UnitTesting;
using Convertion;

namespace FistTest
{
    [TestClass]
    public class TestCalculator
    {
        [TestMethod]
        public void Calcolo1Test()
        {
            Assert.AreEqual(true, Calculator.Calcolo1());
        }
        [TestMethod]
        public void Calcolo2Test()
        {
            Assert.AreEqual(false, Calculator.Calcolo1());
        }
        [TestMethod]
        public void Calcolo3Test()
        {
            Assert.AreEqual(true, Calculator.Calcolo2());
        }
        [TestMethod]
        public void Calcolo4Test()
        {
            Assert.AreEqual(false, Calculator.Calcolo2());
        }
        [TestMethod]
        public void Calcolo5Test()
        {
            Assert.AreEqual(true, Calculator.Calcolo3());
        }
    }
}
