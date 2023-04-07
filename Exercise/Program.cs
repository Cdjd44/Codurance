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
            RoverGrid rg = new RoverGrid(10, 10);
            MarsRover mr = new MarsRover("0:0:N");
            
            PrintGrid(rg, mr);
            WriteHelp();
            
        }

        private static void PrintGrid(RoverGrid grid, MarsRover mr)
        {
            int i, j = 0;
            string[,] landscape = grid.initialiseGrid(mr);

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
            Console.WriteLine();

            for (i = 0; i < grid.xAxis; i++)
            {
                for (j = 0; j < grid.yAxis; j++)
                {
                    if(j == 0) { Console.Write(i.ToString() + " "); }
                    Console.Write(landscape[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void WriteHelp()
        {
            Console.WriteLine("Valid Commands are:");
            Console.WriteLine("L - Turn Rover Left");
            Console.WriteLine("R - Turn Rover Right");
            Console.WriteLine("F - Move Rover Forward");
            Console.WriteLine("E - End");
            Console.WriteLine("Enter to execute commands");
        }
    }
}
