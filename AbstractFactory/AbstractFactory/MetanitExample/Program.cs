using System;
using MetanitExample.HeroClasses;

// Пример с сайта метанит
// https://metanit.com/sharp/patterns/2.2.php

namespace MetanitExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero elf = new Hero(new ElfFactory());
            elf.Run();
            elf.Hit();

            Hero warrior = new Hero(new WarriorFactory());
            warrior.Run();
            warrior.Hit();
            
            Console.ReadLine();
        }
    }
}