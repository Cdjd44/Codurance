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

        [TestMethod]
        public void Convert_4_to_I()
        {
            RomanNumeral rn = new RomanNumeral();
            Assert.AreEqual("I", rn.convert(4));
        }

        [TestMethod]
        public void Convert_5_to_V()
        {
            RomanNumeral rn = new RomanNumeral();
            Assert.AreEqual("I", rn.convert(5));
        }

        [TestMethod]
        public void Convert_6_to_VI()
        {
            RomanNumeral rn = new RomanNumeral();
            Assert.AreEqual("I", rn.convert(6));
        }

        [TestMethod]
        public void Convert_7_to_VII()
        {
            RomanNumeral rn = new RomanNumeral();
            Assert.AreEqual("I", rn.convert(70));
        }
    }
}
