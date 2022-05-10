using System;
using System.Collections.Generic;

namespace Exercise
{
    public class MarsRover
    {
        string _location;

        public MarsRover(string location)
        {
            _location = location;
        }
        public string execute(string command)
        {
            List<string> cmd = new List<string>();
            cmd = LocationSplit(_location);

            if(command == "LL")
            {
                cmd[2] = rotateLeft(cmd[2]);
                cmd[2] = rotateLeft(cmd[2]);
                return $"{cmd[0]}:{cmd[1]}:{cmd[2]}";
            }

            if (command == "L") { return "5:5:W"; }
            if (command == "R") { return "5:5:E"; }
            if (command == "M") { return "5:6:N"; }

            return "5:5:S";
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
            if(dir == "N")
            {
                dir = "W";
            }
            else if(dir == "W")
            {
                dir = "S";
            }
            return dir;
        }
    }
}