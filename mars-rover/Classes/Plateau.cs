using mars_rover.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace mars_rover.Classes
{
    public class Plateau : IPlateau
    {
        public int UpperRightCoordX { get; }
        public int UpperRightCoordY { get; }


        public Plateau(int UpperRightCoordX, int UpperRightCoordY)
        {
            this.UpperRightCoordX = UpperRightCoordX;
            this.UpperRightCoordY = UpperRightCoordY;
        }
    }
}
