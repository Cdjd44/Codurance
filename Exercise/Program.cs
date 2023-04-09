using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 10;
            // RoverGrid (X,Y) - X = Up/Down Y = Left/Right
            RoverGrid rg = new RoverGrid(x, y);
            MarsRover mr = new MarsRover("0:0:N");
            string input = "";
            string[,] grid = new string[x,y];
            rg.grid = rg.initialiseGrid(mr);

            do
            {
                PrintGrid(rg, mr);
                WriteHelp();
                Console.WriteLine("***** Rover Facing:" + mr.location + "*****");
                input = getUserInput();
                mr.location = mr.execute(input);
            }
            while (input != "E" &&  input != "e");


        }

        private static void PrintGrid(RoverGrid grid, MarsRover mr)
        {
            int i, j = 0;
            string[,] landscape = grid.updateGrid(mr);
            bool yNumbers = false;
            // xAxis lable
            for (i = 0; i < grid.xAxis; i++)
            {
                if (i == 0) 
                { 
                    Console.Write("  " + i.ToString() + " "); 
                }
                else
                {
                    Console.Write(i.ToString() + " ");
                }
            }
            Console.Write("X");
            Console.WriteLine();

            for (j = 0; j < grid.yAxis; j++)
            {
                for (i = 0; i < grid.xAxis; i++)
                {
                    if(!yNumbers) { Console.Write(j.ToString() + " "); yNumbers = true; }
                    Console.Write(landscape[i, j] + " ");
                }
                Console.WriteLine();
                yNumbers = false;
            }
            Console.WriteLine("Y");
            Console.WriteLine();
        }

        private static void WriteHelp()
        {
            Console.WriteLine("Valid Commands are:");
            Console.WriteLine("L - Turn Rover Left");
            Console.WriteLine("R - Turn Rover Right");
            Console.WriteLine("M - Move Rover Forward");
            Console.WriteLine("E - End");
            Console.WriteLine("Enter to execute commands");
        }

        private static string getUserInput()
        {
            Console.Write("Command: ");
            return Console.ReadLine();

        }
    }
}
