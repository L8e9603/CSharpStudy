using System;

namespace PartialClass
{
    class Program
    {
        public static void Main(string[] args)
        {
            Robot robot = new Robot("Taekwon V");

            Console.WriteLine(robot.Name);

            robot.ShootLaserBeam();
            robot.ShootMissiles();
            robot.Nuke();

        }
    }
}