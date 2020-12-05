using mars_rover.Enums;
using mars_rover.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace mars_rover.Classes
{
    class Rover : IRover
    {
        public int CoordX { get; set; }
        public int CoordY { get; set; }
        public Directions Direction { get; set; }
        public IPlateau Plateau { get; set; }

        public Rover(IPlateau Plateau, int CoordX, int CoordY, Directions Direction)
        {
            this.CoordX = CoordX;
            this.CoordY = CoordY;
            this.Direction = Direction;
            this.Plateau = Plateau;
        }

        public void ExecuteNASACommand(string command)
        {
            for (int index = 0; index < command.Length; index++)
            {
                var parsedCommand = Enum.Parse<Commands>(command[index].ToString());

                switch (parsedCommand)
                {
                    case Commands.R:
                        RotateRight();
                        break;
                    case Commands.L:
                        RotateLeft();
                        break;
                    case Commands.M:
                        Move();
                        break;
                    default:
                        Console.WriteLine($"Unknown Command: Coudn't Execute {parsedCommand}");
                        break;
                }
            }

            if (!IsInPlateau())
                Console.WriteLine("Rover is out of boundaries. Rover is lost.");

            Console.WriteLine(CoordX + " " + CoordY + " " + Direction);
        }

        public bool IsInPlateau()
        {
            return CoordX >= 0 && CoordX < Plateau.UpperRightCoordX && CoordY >= 0 && CoordY < Plateau.UpperRightCoordY;
        }

        private void Move()
        {
            switch (Direction)
            {
                case Directions.N:
                    CoordY += 1;
                    break;
                case Directions.E:
                    CoordX += 1;
                    break;
                case Directions.S:
                    CoordY -= 1;
                    break;
                case Directions.W:
                    CoordX -= 1;
                    break;
            }
        }

        private void RotateRight()
        {
            if (Direction == Directions.W)
                Direction = Directions.N;
            else
                Direction += 1;
        }

        private void RotateLeft()
        {
            if (Direction == Directions.N)
                Direction = Directions.W;
            else
                Direction -= 1;
        }
    }
}
