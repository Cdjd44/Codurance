using System;

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
            throw new NotImplementedException();
        }
    }
}