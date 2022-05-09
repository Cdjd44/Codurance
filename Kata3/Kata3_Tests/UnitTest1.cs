using Kata3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata3_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Convert_1_to_I()
        {
            RomanNumeral rn = new RomanNumeral();
            Assert.AreEqual("I", rn.convert(1));
        }

        [TestMethod]
        public void Convert_2_to_I()
        {
            RomanNumeral rn = new RomanNumeral();
            Assert.AreEqual("I", rn.convert(2));
        }

        [TestMethod]
        public void Convert_3_to_I()
        {
            RomanNumeral rn = new RomanNumeral();
            Assert.AreEqual("I", rn.convert(3));
        }
    }
}
