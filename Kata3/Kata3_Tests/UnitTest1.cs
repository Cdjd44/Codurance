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
    }
}
