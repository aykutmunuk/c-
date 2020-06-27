using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Robotic.Data
{
    public static class Constants
    {
        public enum Directions { 
        
            WEST,
            EAST,
            NORTH,
            SOUTH
        }
        public enum RotationKeys
        {
            L='L',
            R='R',
            M='M',
            l = 'l',
            r = 'r',
            m = 'm'
        }
    }
}
