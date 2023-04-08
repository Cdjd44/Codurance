using System;
using System.Collections.Generic;

namespace Exercise
{
    public class RoverGrid
    {
        public int xAxis { get; }
        public int yAxis { get; }

        public RoverGrid(int v1, int v2)
        {
            xAxis = v1;
            yAxis = v2;
        }

        public string[,] initialiseGrid(MarsRover mr)
        {
            int i = 0;
            int j = 0;
            string[,] grid = new string[xAxis, yAxis];
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
            grid[Int32.Parse(mrCoord[0]), Int32.Parse(mrCoord[1])] = "X";
            return grid;
        }
    }
}