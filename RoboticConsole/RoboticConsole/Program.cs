using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Robotic.Business;
using Robotic.Data;
using static Robotic.Data.Constants;

namespace RoboticConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var areaBorders = Console.ReadLine().Trim().Split(' ');
            if (areaBorders.Count() == 2)
            {
                var location = Console.ReadLine().Trim().Split(' ');
                if (location.Count() == 3)
                {
                    var rotationKeys = Console.ReadLine().Trim().ToUpper();
                    if (rotationKeys !=null)
                    {
                        try
                        {
                            AreaEntity areaEntity = AreaEntity.CreateInstance(int.Parse(areaBorders[0]), int.Parse(areaBorders[1]));
                            Directions direction = (Directions)Enum.Parse(typeof(Directions), location[2]);
                            RobotEntity robotEntity = RobotEntity.CreateInstance(int.Parse(location[0]), int.Parse(location[1]), direction);
                            RobotMapping.Run(rotationKeys);
                            Console.WriteLine($"X: {robotEntity.X} Y:{robotEntity.Y} Yön : {robotEntity.Direction.ToString()}");
                        } catch(Exception exp)
                        {
                            Console.WriteLine($"Exception: {exp.Message} ******** {exp.StackTrace}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Eksik veya fazla parametre girdiniz, rotasyonu örneğin şu şekilde girebilirsiniz: LMLMLMLMM ");
                    }
                }
                else
                {
                    Console.WriteLine("Eksik veya fazla parametre girdiniz, üç parametre girmeniz gerekmektedir, örneğin; 1 2 N ");
                }
            }
            else
            {
                Console.WriteLine("Eksik veya fazla parametre girdiniz, iki parametre girmeniz gerekmektedir, örneğin; 5 5 ");
            }
            Console.ReadLine();
        }
    }
}
