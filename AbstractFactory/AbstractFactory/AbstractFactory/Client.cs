using System;
using AbstractFactory.Factories;

namespace AbstractFactory
{
    public class Client
    {
        public void Main()
        {
            ClientMethod(new ConcreteFactory1());
            ClientMethod(new ConcreteFactory2());
        }

        public void ClientMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();
            
            Console.WriteLine(productB.UsefulFunctionB());
            Console.WriteLine(productB.AnotherUsefulFunction(productA));
        }
    }
}