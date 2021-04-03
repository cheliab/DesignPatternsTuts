using System;

namespace FactoryMethod
{
    public class Client
    {
        public void Main()
        {
            Console.WriteLine("ConcreteCreator 1");
            ClientCode(new ConcreteCreator1());
            
            Console.WriteLine(new string('-', 20));
            
            Console.WriteLine("ConcreteCreator 2");
            ClientCode(new ConcreteCreator2());
        }

        public void ClientCode(Creator creator)
        {
            Console.WriteLine("Client work with some creator: " + creator.SomeOperation());
        }
    }
}