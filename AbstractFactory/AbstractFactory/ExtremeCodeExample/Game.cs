using System;
using System.Collections.Generic;

namespace ExtremeCodeExample
{
    public class Game
    {
        public Park location;
        
        public Game(IBidloFactory factory)
        {
            var bidlos = factory.Create();

            location = new Park(bidlos);
        }
        
        public void Start()
        {
            location.Render();
        }
    }

    public class Park
    {
        private List<IBidlo> _bidlos;
        
        public Park(List<IBidlo> bidlos)
        {
            _bidlos = bidlos;
        }

        public void Render()
        {
            foreach (var bidlo in _bidlos)
            {
                Console.WriteLine($"{bidlo}");
            }
        }
    }
}