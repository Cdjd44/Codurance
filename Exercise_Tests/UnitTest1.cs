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
            RoverGrid grid = new RoverGrid(10, 10);
            Boundary bounds = new Boundary(grid.xAxis, grid.yAxis);

            Assert.AreEqual("5:5:W", rover.execute(command, bounds));
        }

        [TestMethod]
        public void Check_Input_For_R()
        {
            string command = "R";
            MarsRover rover = new MarsRover("5:5:N");
            RoverGrid grid = new RoverGrid(10, 10);
            Boundary bounds = new Boundary(grid.xAxis, grid.yAxis);

            Assert.AreEqual("5:5:E", rover.execute(command, bounds));
        }

        [TestMethod]
        public void Check_Input_For_M()
        {
            string command = "M";
            MarsRover rover = new MarsRover("5:5:N");
            RoverGrid grid = new RoverGrid(10, 10);
            Boundary bounds = new Boundary(grid.xAxis, grid.yAxis);

            Assert.AreEqual("5:4:N", rover.execute(command, bounds));
        }

        [TestMethod]
        public void Check_Input_For_LL()
        {
            string command = "LL";
            MarsRover rover = new MarsRover("5:5:N");
            RoverGrid grid = new RoverGrid(10, 10);
            Boundary bounds = new Boundary(grid.xAxis, grid.yAxis);

            Assert.AreEqual("5:5:S", rover.execute(command, bounds));
        }

        [TestMethod]
        public void Check_Input_For_RR()
        {
            string command = "RR";
            MarsRover rover = new MarsRover("5:5:N");
            RoverGrid grid = new RoverGrid(10, 10);
            Boundary bounds = new Boundary(grid.xAxis, grid.yAxis);

            Assert.AreEqual("5:5:S", rover.execute(command, bounds));
        }

        [TestMethod]
        public void Check_Input_For_MM()
        {
            string command = "MM";
            MarsRover rover = new MarsRover("5:5:N");
            RoverGrid grid = new RoverGrid(10, 10);
            Boundary bounds = new Boundary(grid.xAxis, grid.yAxis);

            Assert.AreEqual("5:3:N", rover.execute(command, bounds));
        }

        [TestMethod]
        public void Check_Input_For_RMMRML()
        {
            string command = "RMMRML";
            MarsRover rover = new MarsRover("0:0:N");
            RoverGrid grid = new RoverGrid(10, 10);
            Boundary bounds = new Boundary(grid.xAxis, grid.yAxis);

            Assert.AreEqual("2:1:E", rover.execute(command, bounds));
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
            RoverGrid grid = new RoverGrid(10, 10);
            Boundary bounds = new Boundary(grid.xAxis, grid.yAxis);

            grid.grid = grid.initialiseGrid(rover);
            rover.location = rover.execute(command, bounds);
            grid.grid = grid.updateGrid(rover);

            Assert.AreEqual("0:9:N", rover.location);
        }

        [TestMethod]
        public void Check_Wrap_Around_From_S()
        {
            string command = "LLM";
            MarsRover rover = new MarsRover("0:9:N");
            RoverGrid grid = new RoverGrid(10, 10);
            Boundary bounds = new Boundary(grid.xAxis, grid.yAxis);

            grid.grid = grid.initialiseGrid(rover);
            rover.location = rover.execute(command, bounds);
            grid.grid = grid.updateGrid(rover);

            Assert.AreEqual("0:0:S", rover.location);
        }

        [TestMethod]
        public void Check_Wrap_Around_From_E()
        {
            string command = "RM";
            MarsRover rover = new MarsRover("9:0:N");
            RoverGrid grid = new RoverGrid(10, 10);
            Boundary bounds = new Boundary(grid.xAxis, grid.yAxis);

            grid.grid = grid.initialiseGrid(rover);
            rover.location = rover.execute(command, bounds);
            grid.grid = grid.updateGrid(rover);

            Assert.AreEqual("0:0:E", rover.location);
        }

        [TestMethod]
        public void Check_Wrap_Around_From_W()
        {
            string command = "LM";
            MarsRover rover = new MarsRover("0:0:N");
            RoverGrid grid = new RoverGrid(10, 10);
            Boundary bounds = new Boundary(grid.xAxis, grid.yAxis);

            grid.grid = grid.initialiseGrid(rover);
            rover.location = rover.execute(command, bounds);
            grid.grid = grid.updateGrid(rover);

            Assert.AreEqual("9:0:W", rover.location);
        }

        [TestMethod]
        public void Find_for_Obstacle_in_Path()
        {
            string command = "RM";
            MarsRover rover = new MarsRover("0:0:N");
            RoverGrid grid = new RoverGrid(10, 10);
            Boundary bounds = new Boundary(grid.xAxis, grid.yAxis);
            Obstacle ob = new Obstacle(0, 1, 1, "#");

            grid.grid = grid.initialiseGrid(rover, ob);

            rover.location = rover.execute(command, bounds);
            grid.grid = grid.updateGrid(rover);

            List<string> roverCoOrds = rover.LocationSplit(rover.location);
            Assert.( (ob.xCoord + ":" + ob.yCoord), (rover.location[1] + ":" + rover.location[1]) );
        }

        [TestMethod]
        public void Check_for_out_of_bound()
        {
            string command = "M";
            MarsRover rover = new MarsRover("0:0:N");
            RoverGrid grid = new RoverGrid(10, 10);
            Boundary bounds = new Boundary(grid.xAxis, grid.yAxis);

            grid.grid = grid.initialiseGrid(rover);
            rover.location = rover.execute(command, bounds);
            
            // returns true if rover is out of bounds
            Assert.IsFalse(bounds.CheckOOB(rover));
        }

    }
}
