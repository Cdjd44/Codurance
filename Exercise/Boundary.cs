using System;
using System.Collections.Generic;

namespace Exercise
{
    public class Boundary
    {
        public int xAxis { get; }
        public int yAxis { get; }

        public Boundary(int x, int y)
        {
            xAxis = x;
            yAxis = y;
        }

        public bool CheckOOB(MarsRover rover)
        {
            List<string> coordinates = rover.LocationSplit(rover.location);

            if ( (Int32.Parse(coordinates[0]) == -1 || Int32.Parse(coordinates[1]) == -1) || (Int32.Parse(coordinates[0]) == xAxis || Int32.Parse(coordinates[1]) == yAxis) )
            {
                return true;
            }

            return false;
        }

        public string RoverWrapAround(MarsRover rover)
        {
            List<string> coordinates = rover.LocationSplit(rover.location);

            // Check rover location and wrap around if out of array bounds.
            // N/S & S/N warp around
            if (Int32.Parse(coordinates[1]) == -1)
            {
                coordinates[1] = (yAxis - 1).ToString();
            }
            else if (Int32.Parse(coordinates[1]) == yAxis)
            {
                coordinates[1] = 0.ToString();
            }
            // E/W & W/E warp around
            if (Int32.Parse(coordinates[0]) == -1)
            {
                coordinates[0] = (xAxis - 1).ToString();
            }
            else if (Int32.Parse(coordinates[0]) == xAxis)
            {
                coordinates[0] = 0.ToString();
            }

            return (coordinates[0]).ToString() + ":" + (coordinates[1]).ToString() + ":" + coordinates[2];
        }
    }
}