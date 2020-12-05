using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace mars_rover.Enums
{
    public enum DirectionEnum
    {
        [Description("N")]
        North,
        [Description("E")]
        East,
        [Description("S")]
        South,
        [Description("W")]
        West
    }
}
