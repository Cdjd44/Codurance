using System;
using System.Collections.Generic;

namespace Exercise
{
    public class RoverGrid
    {
        public int xAxis { get; }
        public int yAxis { get; }
        public List<string> obstacle { get; set; }
        public string[,] grid { get; set; }

        public RoverGrid(int v1, int v2)
        {
            xAxis = v1;
            yAxis = v2;
            grid = new string[xAxis, yAxis];
        }

        public string[,] initialiseGrid(MarsRover mr)
        {
            int i = 0;
            int j = 0;
            List<string> mrCoord = mr.LocationSplit(mr.location);

            // Initialise Y axis
            for (j = 0; j < yAxis; j++)
            {
                // Initialise X axis
                for (i = 0; i < xAxis; i++)
                {
                    grid[i, j] = "o";
                }
            }

            // Add rover to grid.
            grid[Int32.Parse(mrCoord[0]), Int32.Parse(mrCoord[1])] = "X";
            return grid;
        }

        public string[,] initialiseGrid(MarsRover mr, Obstacle ob)
        {
            int i = 0;
            int j = 0;
            List<string> mrCoord = mr.LocationSplit(mr.location);

            // Initialise Y axis
            for (j = 0; j < yAxis; j++)
            {
                // Initialise X axis
                for (i = 0; i < xAxis; i++)
                {
                    grid[i, j] = "o";
                }  
            }

            // Add obstacle to grid.
            grid[ob.xCoord, ob.yCoord] = ob.obstacleCharacter;

            // Add rover to grid.
            grid[Int32.Parse(mrCoord[0]), Int32.Parse(mrCoord[1])] = "X";
            return grid;
        }

        public string[,] updateGrid(MarsRover mr)
        {
            int i = 0;
            int j = 0;
            List<string> mrCoord = mr.LocationSplit(mr.location);

            // removed previous character of rover from grid
            for (j = 0; j < yAxis; j++)
            {
                // Initialise X axis
                for (i = 0; i < xAxis; i++)
                {
                    if (grid[i, j] == "X")
                    {
                        grid[i, j] = "o";
                    }
                }
            }

            grid[Int32.Parse(mrCoord[0]), Int32.Parse(mrCoord[1])] = "X";
            return grid;
        }

        public string[,] addObstacle(Obstacle obstacle)
        {
            Random rnd = new Random();
            int randomX = rnd.Next(xAxis);
            int randomY = rnd.Next(yAxis);

            grid[obstacle.xCoord, obstacle.yCoord] = obstacle.obstacleCharacter;

            return grid;
        }

        public string[,] addObstacle(int xCoord, int yCoord)
        {
            Random rnd = new Random();
            int x = xCoord;
            int y = yCoord;

            grid[x, y] = "#";
            obstacle.Add(x.ToString() + ":" + y.ToString());

            return grid;
        }
    }
}