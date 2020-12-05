using mars_rover.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace mars_rover.Interfaces
{
    public interface IRover
    {

        public int CoordX { get; }
        public int CoordY { get; }
        public Directions Direction { get; }
        public IPlateau Plateau { get; }
        public bool IsInPlateau();
        public void ExecuteNASACommand(string command);
    }
}
