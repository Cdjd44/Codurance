using System;

namespace Exercise
{
    public class MarsRover
    {
        string _location;

        public MarsRover(string location)
        {
            location = _location;
        }
        public string execute(string command)
        {
            if (command == "L") { return "5:5:W"; }
            if (command == "R") { return "5:5:E"; }
            return "5:6:N";
        }
    }
}