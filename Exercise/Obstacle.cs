using System;

namespace Exercise
{
    public class Obstacle
    {     
        public int xCoord { get; }
        public int yCoord { get; }
        public int numObstacles { get; }
        public string obstacleCharacter = "";

        public Obstacle(int xCoordinate, int yCoordinate, int numberOfObstacles, string character)
        {
            xCoord = xCoordinate;
            yCoord = yCoordinate;
            numObstacles = numberOfObstacles;
            obstacleCharacter = character;
        }
    }
}