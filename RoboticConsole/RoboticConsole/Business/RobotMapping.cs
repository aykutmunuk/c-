using System;
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
                        break;
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
                case Directions.E:
                    robotEntity.Direction = Directions.N;
                    break;
                case Directions.N:
                    robotEntity.Direction = Directions.W;
                    break;
                case Directions.S:
                    robotEntity.Direction = Directions.E;
                    break;
                case Directions.W:
                    robotEntity.Direction = Directions.S;
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
                case Directions.E:
                    robotEntity.Direction = Directions.S;
                    break;
                case Directions.N:
                    robotEntity.Direction = Directions.E;
                    break;
                case Directions.S:
                    robotEntity.Direction = Directions.W;
                    break;
                case Directions.W:
                    robotEntity.Direction = Directions.N;
                    break;
                default:
                    break;
            }
        }
        private static void goStraight()
        {
            RobotEntity robotEntity = RobotEntity.getInstance();
            AreaEntity areaEntity = AreaEntity.getInstance();
            switch (robotEntity.Direction)
            {
                case Directions.E:
                    robotEntity.X++;
                    break;
                case Directions.N:
                    robotEntity.Y++;
                    break;
                case Directions.S:
                    robotEntity.Y--;
                    break;
                case Directions.W:
                    robotEntity.X--;
                    break;
                default:
                    break;
            }
            
            if (robotEntity.X <0 || robotEntity.Y < 0 || areaEntity.ySize < robotEntity.Y || areaEntity.xSize < robotEntity.X)
            {
                throw new Exception($"Alanın dışına çıkıldı.");
            }
        }
    }
}
