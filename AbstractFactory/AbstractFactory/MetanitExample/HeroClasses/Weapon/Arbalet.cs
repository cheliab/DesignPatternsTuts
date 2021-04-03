using System;

namespace MetanitExample.HeroClasses
{
    public class Arbalet : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Стреляем из арбалета");
        }
    }
}