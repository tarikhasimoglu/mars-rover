using mars_rover.Classes;
using mars_rover.Enums;
using System;

namespace mars_rover
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, Please enter the upper-right coordinates of the plateau:");
            var plateauCoords = Console.ReadLine().Split(' ');

            int plateauUpperRightCoordX = Int32.Parse(plateauCoords[0]);
            int plateauUpperRightCoordY = Int32.Parse(plateauCoords[1]);

            Plateau plateau = new Plateau(plateauUpperRightCoordX, plateauUpperRightCoordY);

            while (true)
            {
                Console.Write("Please enter the rover's position and intial direction that you want to deploy:");

                var roverInfo = Console.ReadLine().Split(' ');
                int roverCoordX = Int32.Parse(roverInfo[0]);
                int roverCoordY = Int32.Parse(roverInfo[1]);
                Directions roverDirection = Enum.Parse<Directions>(roverInfo[2]);

                Rover rover = new Rover(plateau, roverCoordX, roverCoordY, roverDirection);
                if (!rover.IsInPlateau())
                {
                    Console.WriteLine("Can Not Deploy Rover; Please Check Entered Values.");
                    continue;
                }

                Console.Write("Please enter a command:");
                string NASACommand = Console.ReadLine();
                rover.ExecuteNASACommand(NASACommand);
                Console.WriteLine(rover.GetPosition());
            }
        }
    }
}
