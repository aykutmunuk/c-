using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Robotic.Data;
using static Robotic.Data.Constants;

namespace Robotic.Business
{
    public class RobotMapping
    {
        public static void Run(string rotations)
        {
            foreach (char item in rotations)
             {
                 switch (item)
                 {
                    case (char)RotationKeys.L:
                        turnLeft(RotationKeys.L);
                        break;
                    case (char)RotationKeys.R:
                        turnRight(RotationKeys.R);
                        break;
                     case (char)RotationKeys.M:
                        goStraight();
                        break;;
                     default:
                        break;
                 }
             }
        }
        private static void turnLeft(RotationKeys rotationKey)
        {
            RobotEntity robotEntity = RobotEntity.getInstance();
            switch (robotEntity.Direction)
            {
                case Directions.EAST:
                    robotEntity.Direction = Directions.NORTH;
                    break;
                case Directions.NORTH:
                    robotEntity.Direction = Directions.WEST;
                    break;
                case Directions.SOUTH:
                    robotEntity.Direction = Directions.EAST;
                    break;
                case Directions.WEST:
                    robotEntity.Direction = Directions.SOUTH;
                    break;
                default:
                    break;
            }
        }
        private static void turnRight(RotationKeys rotationKey)
        {
            RobotEntity robotEntity = RobotEntity.getInstance();
            switch (robotEntity.Direction)
            {
                case Directions.EAST:
                    robotEntity.Direction = Directions.SOUTH;
                    break;
                case Directions.NORTH:
                    robotEntity.Direction = Directions.EAST;
                    break;
                case Directions.SOUTH:
                    robotEntity.Direction = Directions.WEST;
                    break;
                case Directions.WEST:
                    robotEntity.Direction = Directions.NORTH;
                    break;
                default:
                    break;
            }
        }
        private static void goStraight()
        {
            RobotEntity robotEntity = RobotEntity.getInstance();
            AreaEntity areaEntity = AreaEntity.getInstance();
            areaEntity.buttons[robotEntity.X][robotEntity.Y].Text = "";
            areaEntity.buttons[robotEntity.X][robotEntity.Y].BackColor = Color.White;
            areaEntity.buttons[robotEntity.X][robotEntity.Y].Update();
            switch (robotEntity.Direction)
            {
                case Directions.EAST:
                    robotEntity.X++;
                    break;
                case Directions.NORTH:
                    robotEntity.Y--;
                    break;
                case Directions.SOUTH:
                    robotEntity.Y++;
                    break;
                case Directions.WEST:
                    robotEntity.X--;
                    break;
                default:
                    break;
            }
            
            if (robotEntity.X <0 || robotEntity.Y < 0 || areaEntity.ySize < robotEntity.Y || areaEntity.xSize < robotEntity.X)
            {
                throw new Exception($"Alanın dışına çıkıldı.");
            }
            areaEntity.buttons[robotEntity.X][robotEntity.Y].Text = robotEntity.Direction.ToString();
            areaEntity.buttons[robotEntity.X][robotEntity.Y].BackColor = Color.Red;
            areaEntity.buttons[robotEntity.X][robotEntity.Y].Update();
            System.Threading.Thread.Sleep(1000);
        }
    }
}
