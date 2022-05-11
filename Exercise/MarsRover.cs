﻿using System;
using System.Collections.Generic;

namespace Exercise
{
    public class MarsRover
    {
        public string location { get; }

        public MarsRover(string _location)
        {
            location = _location;
            RoverGrid rg = new RoverGrid(10, 10);
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
                        currentLocation[2] = rotateLeft(currentLocation[2]);
                        break;
                    case "R":
                        currentLocation[2] = rotateRight(currentLocation[2]);
                        break;
                    case "M":
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
            foreach(string s in location.Split(':'))
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
                    coordinates[1] = (Int32.Parse(coordinates[1]) + 1).ToString();
                    break;
                case "S":
                    coordinates[1] = (Int32.Parse(coordinates[1]) - 1).ToString();
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
    }
}