using mars_rover.Classes;
using mars_rover.Enums;
using NUnit.Framework;
using System;

namespace mars_rover_unit_test
{
    public class Tests
    {
        [Test]
        public void Should_The_Output_For_1_2_N_Rover_LMLMLMLMM_Be_1_3_N()
        {
            Console.Write("Hello, Please enter the upper-right coordinates of the plateau:");

            var plateauCoordsInput = "5 5";

            var plateauCoords = plateauCoordsInput.Split(' ');

            int plateauUpperRightCoordX = Int32.Parse(plateauCoords[0]);
            int plateauUpperRightCoordY = Int32.Parse(plateauCoords[1]);

            Plateau plateau = new Plateau(plateauUpperRightCoordX, plateauUpperRightCoordY);

            Console.Write("Please enter the rover's position and intial direction that you want to deploy:");

            var roverInfoInput = "1 2 N";
            var roverInfo = roverInfoInput.Split(' ');
            int roverCoordX = Int32.Parse(roverInfo[0]);
            int roverCoordY = Int32.Parse(roverInfo[1]);
            Directions roverDirection = Enum.Parse<Directions>(roverInfo[2]);


            Rover rover = new Rover(plateau, roverCoordX, roverCoordY, roverDirection);

            Console.Write("Please enter a command:");
            string NASACommand = "LMLMLMLMM";
            rover.ExecuteNASACommand(NASACommand);
            Assert.AreEqual(rover.GetPosition(), "1 3 N");
        }

        [Test]
        public void Should_The_Output_For_3_3_E_Rover_MMRMMRMRRM_Be_5_1_3()
        {
            Console.Write("Hello, Please enter the upper-right coordinates of the plateau:");

            var plateauCoordsInput = "5 5";

            var plateauCoords = plateauCoordsInput.Split(' ');

            int plateauUpperRightCoordX = Int32.Parse(plateauCoords[0]);
            int plateauUpperRightCoordY = Int32.Parse(plateauCoords[1]);

            Plateau plateau = new Plateau(plateauUpperRightCoordX, plateauUpperRightCoordY);

            Console.Write("Please enter the rover's position and intial direction that you want to deploy:");

            var roverInfoInput = "3 3 E";
            var roverInfo = roverInfoInput.Split(' ');
            int roverCoordX = Int32.Parse(roverInfo[0]);
            int roverCoordY = Int32.Parse(roverInfo[1]);
            Directions roverDirection = Enum.Parse<Directions>(roverInfo[2]);


            Rover rover = new Rover(plateau, roverCoordX, roverCoordY, roverDirection);

            Console.Write("Please enter a command:");
            string NASACommand = "MMRMMRMRRM";
            rover.ExecuteNASACommand(NASACommand);
            Assert.AreEqual(rover.GetPosition(), "5 1 E");
        }

        [Test]
        public void Should_The_Output_For_10_10_E_Rover_LLMLMLMLLL_Be_Out_Of_Boundaries()
        {
            Console.Write("Hello, Please enter the upper-right coordinates of the plateau:");

            var plateauCoordsInput = "5 5";

            var plateauCoords = plateauCoordsInput.Split(' ');

            int plateauUpperRightCoordX = Int32.Parse(plateauCoords[0]);
            int plateauUpperRightCoordY = Int32.Parse(plateauCoords[1]);

            Plateau plateau = new Plateau(plateauUpperRightCoordX, plateauUpperRightCoordY);

            Console.Write("Please enter the rover's position and intial direction that you want to deploy:");

            var roverInfoInput = "10 10 E";
            var roverInfo = roverInfoInput.Split(' ');
            int roverCoordX = Int32.Parse(roverInfo[0]);
            int roverCoordY = Int32.Parse(roverInfo[1]);
            Directions roverDirection = Enum.Parse<Directions>(roverInfo[2]);

            Rover rover = new Rover(plateau, roverCoordX, roverCoordY, roverDirection);
            Console.Write("Please enter a command:");

            string NASACommand = "LLMLMLMLLL";
            rover.ExecuteNASACommand(NASACommand);
            Assert.AreEqual(rover.GetPosition(), "Rover is out of boundaries. Rover is lost.");
        }
    }
}