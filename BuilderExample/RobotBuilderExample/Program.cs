using System;

namespace RobotBuilderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var oldStyleRobotBuilder = new OldRobotBuilder();

            var robotEngineer = new RobotEngineer(oldStyleRobotBuilder);
            
            robotEngineer.MakeRobot();

            var oldStyleRobot_1 = oldStyleRobotBuilder.GetRobot();
            
            Console.WriteLine("Робот:");
            Console.WriteLine($" - Голова: {oldStyleRobot_1.Head}");
            Console.WriteLine($" - Тело: {oldStyleRobot_1.Torso}");
            Console.WriteLine($" - Руки: {oldStyleRobot_1.Arms}");
            Console.WriteLine($" - Ноги: {oldStyleRobot_1.Legs}");
            
            Console.ReadLine();
        }
    }
}