using System;

namespace ExtremeCodeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(new EasyLevelBidloFactory());
            game.Start();
            
            Console.ReadLine();
        }
    }
}