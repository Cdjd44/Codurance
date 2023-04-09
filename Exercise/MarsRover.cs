using System;
using System.Collections.Generic;

namespace Exercise
{
    public class MarsRover
    {
        public string location { get; set; }

        public MarsRover(string _location)
        {
            location = _location;
        }
        public string execute(string command)
        {
            List<string> currentLocation = new List<string>();
            currentLocation = LocationSplit(location);

            List<string> commandBreakdown = new List<string>();
            commandBreakdown = commandSplit(command);

            foreach (string c in commandBreakdown)
            {
                switch (c)
                {
                    case "L":
                    case "l":
                        currentLocation[2] = rotateLeft(currentLocation[2]);
                        break;
                    case "R":
                    case "r":
                        currentLocation[2] = rotateRight(currentLocation[2]);
                        break;
                    case "M":
                    case "m":
                        currentLocation = moveRover(currentLocation);
                        break;

                }
            }

            return $"{currentLocation[0]}:{currentLocation[1]}:{currentLocation[2]}";
        }
        public List<string> commandSplit(string command)
        {
            List<string> split = new List<string>();
            foreach (char c in command)
            {
                split.Add((c).ToString());
            }
            return split;
        }
        public List<string> LocationSplit(string location)
        {
            List<string> split = new List<string>();
            foreach (string s in location.Split(':'))
            {
                split.Add(s);
            }
            return split;
        }

        public string rotateLeft(string facing)
        {
            string dir = facing;
            switch (dir)
            {
                case "N":
                    dir = "W";
                    break;
                case "W":
                    dir = "S";
                    break;
                case "S":
                    dir = "E";
                    break;
                case "E":
                    dir = "N";
                    break;
            }
            return dir;
        }

        public string rotateRight(string facing)
        {
            string dir = facing;
            switch (dir)
            {
                case "N":
                    dir = "E";
                    break;
                case "E":
                    dir = "S";
                    break;
                case "S":
                    dir = "W";
                    break;
                case "W":
                    dir = "N";
                    break;
            }
            return dir;
        }

        public List<string> moveRover(List<string> currentLocation)
        {
            List<string> coordinates = currentLocation;

            switch (coordinates[2])
            {
                case "N":
                    coordinates[1] = (Int32.Parse(coordinates[1]) - 1).ToString();
                    break;
                case "S":
                    coordinates[1] = (Int32.Parse(coordinates[1]) + 1).ToString();
                    break;
                case "E":
                    coordinates[0] = (Int32.Parse(coordinates[0]) + 1).ToString();
                    break;
                case "W":
                    coordinates[0] = (Int32.Parse(coordinates[0]) - 1).ToString();
                    break;
            }

            return coordinates;
        }

        //public List<string> checkForOutofBounds(List<string> currentLocation, Boundary bounds)
        //{
        //    List<string> coordinates = currentLocation;

        //    // Check rover location and wrap around if out of array bounds.
        //    // N/S & S/N warp around
        //    if (Int32.Parse(currentLocation[1]) == -1)
        //    {
        //        currentLocation[1] = (bounds.yAxis - 1).ToString();
        //    }
        //    else if (Int32.Parse(currentLocation[1]) == bounds.yAxis)
        //    {
        //        currentLocation[1] = 0.ToString();
        //    }
        //    // E/W & W/E warp around
        //    if (Int32.Parse(currentLocation[0]) == -1)
        //    {
        //        currentLocation[0] = (bounds.xAxis - 1).ToString();
        //    }
        //    else if (Int32.Parse(currentLocation[0]) == bounds.xAxis)
        //    {
        //        currentLocation[0] = 0.ToString();
        //    }

        //    return coordinates;
        //}
    }
}