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

        [TestMethod]
        public void Check_Input_For_LL()
        {
            string command = "LL";
            MarsRover rover = new MarsRover("5:5:N");

            Assert.AreEqual("5:5:S", rover.execute(command));
        }

        [TestMethod]
        public void Check_Input_For_RR()
        {
            string command = "RR";
            MarsRover rover = new MarsRover("5:5:N");

            Assert.AreEqual("5:5:S", rover.execute(command));
        }

        [TestMethod]
        public void Check_Input_For_MM()
        {
            string command = "MM";
            MarsRover rover = new MarsRover("5:5:N");

            Assert.AreEqual("5:7:N", rover.execute(command));
        }

        [TestMethod]
        public void Check_Input_For_RMMLM()
        {
            string command = "RMMLM";
            MarsRover rover = new MarsRover("0:0:N");

            Assert.AreEqual("2:1:N", rover.execute(command));
        }

    }
}
