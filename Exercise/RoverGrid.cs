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

        public string[,] initialiseGrid()
        {
            int i = 0;
            int j = 0;
            string[,] grid = new string[xAxis, yAxis];

            // Initialise X axis
            for (i = 0; i < xAxis; i++)
            {
                // Initialise Y axis
                for (j = 0; j < yAxis; j++)
                {
                    grid[i, j] = "o";
                }
            }

            return grid;
        }
    }
}