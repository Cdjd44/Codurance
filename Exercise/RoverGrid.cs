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
            obstacle = new List<string>();
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

            Random rnd = new Random();
            int randomX = rnd.Next(xAxis);
            int randomY = rnd.Next(yAxis);

            grid[randomX, randomY] = "#";
            obstacle.Add(randomX.ToString() + ":" + randomY.ToString());

            mr.location = (mrCoord[0]).ToString() + ":" + (mrCoord[1]).ToString() + ":" + mrCoord[2];
            grid[Int32.Parse(mrCoord[0]), Int32.Parse(mrCoord[1])] = "X";
            return grid;
        }

        public string[,] updateGrid(MarsRover mr)
        {
            List<string> mrCoord = mr.LocationSplit(mr.location);

            // Check rover location and wrap around if out of array bounds.
            // N/S & S/N warp around
            if (Int32.Parse(mrCoord[1]) == -1)
            {
                mrCoord[1] = (yAxis - 1).ToString();
            }
            else if (Int32.Parse(mrCoord[1]) == yAxis)
            {
                mrCoord[1] = 0.ToString();
            }
            // E/W & W/E warp around
            if (Int32.Parse(mrCoord[0]) == -1)
            {
                mrCoord[0] = (xAxis - 1).ToString();
            }
            else if (Int32.Parse(mrCoord[0]) == xAxis)
            {
                mrCoord[0] = 0.ToString();
            }

            mr.location = (mrCoord[0]).ToString() + ":" + (mrCoord[1]).ToString() + ":" + mrCoord[2];
            grid[Int32.Parse(mrCoord[0]), Int32.Parse(mrCoord[1])] = "X";
            return grid;
        }
    }
}