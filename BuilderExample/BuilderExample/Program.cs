using System;
using System.Runtime.ConstrainedExecution;

namespace BuilderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var builder = new ConcreteBuilder();
            director.Builder = builder;
            
            // Создаем простой продукт
            Console.WriteLine("Standart basic product:");
            director.BuildMinimalViableProduct();
            Console.WriteLine(builder.GetProduct().ListParts());
            
            // Создаем самый сложный продукт
            Console.WriteLine("Standart full featured product: ");
            director.BuildFullFeaturedProduct();
            Console.WriteLine(builder.GetProduct().ListParts());
            
            // Создание продукта без использования директора
            Console.WriteLine("Custom product:");
            builder.BuildPartA();
            builder.BuildPartC();
            Console.WriteLine(builder.GetProduct().ListParts());
        
            Console.ReadLine();
        }
    }
}