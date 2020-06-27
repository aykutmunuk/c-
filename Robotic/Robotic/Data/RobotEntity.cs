using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Robotic.Data.Constants;

namespace Robotic.Data
{
    class RobotEntity
    {
        private static RobotEntity instance = null;
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;
        public Directions Direction { get; set; } = Directions.NORTH;
        public static RobotEntity CreateInstance(int x, int y, Directions directions)
        {
            if (instance == null)
            {
                instance = new RobotEntity(x, y, directions);
            }
            return instance;
        }
        public static RobotEntity getInstance()
        {
            return instance;
        }
        public static void Clear()
        {
            instance = null;
        }
        private RobotEntity(int x, int y, Directions directions)
        {
            this.X = x;
            this.Y = y;
            this.Direction = directions;
        }
    }
}
