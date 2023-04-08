using Exercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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

            Assert.AreEqual("5:4:N", rover.execute(command));
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

            Assert.AreEqual("5:3:N", rover.execute(command));
        }

        [TestMethod]
        public void Check_Input_For_RMMRML()
        {
            string command = "RMMRML";
            MarsRover rover = new MarsRover("0:0:N");

            Assert.AreEqual("2:1:E", rover.execute(command));
        }

        [TestMethod]
        public void Check_Initialisation_Of_xAxis()
        {
            RoverGrid grid = new RoverGrid(10,10);
            Assert.AreEqual(10, grid.xAxis);
        }

        [TestMethod]
        public void Check_Initialisation_Of_yAxis()
        {
            RoverGrid grid = new RoverGrid(10, 10);
            Assert.AreEqual(10, grid.yAxis);
        }

        [TestMethod]
        public void Check_Initial_Placement_Of_Rover()
        {
            MarsRover rover = new MarsRover("0:0:N");
            RoverGrid grid = new RoverGrid(10, 10);
            string[,] plane = grid.initialiseGrid(rover);
            
            Assert.IsTrue(plane[0, 0] == "X");
         
        }

        [TestMethod]
        public void Check_Random_Placement_Of_Rover()
        {
            Random rnd = new Random();
            int xAxis = rnd.Next(9);
            int yAxis = rnd.Next(9);
            string roverLocation = xAxis.ToString() + ":" + yAxis.ToString() + ":N";
            MarsRover rover = new MarsRover(roverLocation);
            RoverGrid grid = new RoverGrid(10, 10);
            string[,] plane = grid.initialiseGrid(rover);

            Assert.IsTrue(plane[xAxis, yAxis] == "X");

        }

        [TestMethod]
        public void Check_Wrap_Around_From_N()
        {
            string command = "M";
            MarsRover rover = new MarsRover("0:0:N");

            Assert.AreEqual("0:9:N", rover.execute(command));
        }

        [TestMethod]
        public void Check_Wrap_Around_From_S()
        {
            string command = "LLM";
            MarsRover rover = new MarsRover("0:9:N");

            Assert.AreEqual("0:0:S", rover.execute(command));
        }

        [TestMethod]
        public void Check_Wrap_Around_From_E()
        {
            string command = "RM";
            MarsRover rover = new MarsRover("9:0:N");

            Assert.AreEqual("0:0:E", rover.execute(command));
        }

        [TestMethod]
        public void Check_Wrap_Around_From_W()
        {
            string command = "LM";
            MarsRover rover = new MarsRover("0:0:N");

            Assert.AreEqual("9:0:W", rover.execute(command));
        }

    }
}
