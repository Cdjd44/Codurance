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
            Assert.AreEqual("II", rn.convert(2));
        }

        [TestMethod]
        public void Convert_3_to_I()
        {
            RomanNumeral rn = new RomanNumeral();
            Assert.AreEqual("III", rn.convert(3));
        }

        [TestMethod]
        public void Convert_4_to_IV()
        {
            RomanNumeral rn = new RomanNumeral();
            Assert.AreEqual("IV", rn.convert(4));
        }

        [TestMethod]
        public void Convert_5_to_V()
        {
            RomanNumeral rn = new RomanNumeral();
            Assert.AreEqual("V", rn.convert(5));
        }

        [TestMethod]
        public void Convert_6_to_VI()
        {
            RomanNumeral rn = new RomanNumeral();
            Assert.AreEqual("VI", rn.convert(6));
        }

        [TestMethod]
        public void Convert_7_to_VII()
        {
            RomanNumeral rn = new RomanNumeral();
            Assert.AreEqual("VII", rn.convert(7));
        }

        [TestMethod]
        public void Convert_8_to_VIII()
        {
            RomanNumeral rn = new RomanNumeral();
            Assert.AreEqual("VIII", rn.convert(8));
        }

        [TestMethod]
        public void Convert_9_to_IX()
        {
            RomanNumeral rn = new RomanNumeral();
            Assert.AreEqual("IX", rn.convert(9));
        }

        [TestMethod]
        public void Convert_10_to_X()
        {
            RomanNumeral rn = new RomanNumeral();
            Assert.AreEqual("X", rn.convert(10));
        }

        [TestMethod]
        public void Convert_29_to_XXIX()
        {
            RomanNumeral rn = new RomanNumeral();
            Assert.AreEqual("XXIX", rn.FromNumberToRoman(29));
        }
    }
}
