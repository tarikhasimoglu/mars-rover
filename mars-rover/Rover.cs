using mars_rover.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace mars_rover
{
    class Rover : IRover
    {
        public int RoverX { get; set; }
        public int RoverY { get; set; }

        public Rover(int RoverX, int RoverY)
        {
            this.RoverX = RoverX;
            this.RoverY = RoverY;
        }
    }
}
