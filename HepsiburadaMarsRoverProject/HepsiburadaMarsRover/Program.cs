using BusinessLogic.Services;
using BusinessLogic.Services.Implementations;
using System;

namespace HepsiburadaMarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            var input =
@"5 5
1 2 N
LMLMLMLMM
3 3 E
MMRMMRMRRM";

            IMarsRoverService marsRoverService = new MarsRoverService();
            string output = marsRoverService.Execute(input);
            Console.WriteLine(output);

        }
    }
}
