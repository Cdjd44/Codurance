using Exercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Check_Input_For_L()
        {
            string command = "L";
            MarsRover rover = new MarsRover("5:5:N");
            
            Assert.AreEqual("5:5:W", rover.execute(command));
        }

        [TestMethod]
        public void Check_Input_For_R()
        {
            string command = "R";
            MarsRover rover = new MarsRover("5:5:N");

            Assert.AreEqual("5:5:E", rover.execute(command));
        }

        [TestMethod]
        public void Check_Input_For_M()
        {
            string command = "M";
            MarsRover rover = new MarsRover("5:5:N");

            Assert.AreEqual("5:6:N", rover.execute(command));
        }
    }
}
