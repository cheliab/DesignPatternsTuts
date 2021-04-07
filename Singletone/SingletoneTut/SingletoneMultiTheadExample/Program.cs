using System;
using System.Threading;

namespace SingletoneMultiTheadExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread process1 = new Thread(() =>
            {
                TestSingleton("FOO");
            });

            Thread process2 = new Thread(() =>
            {
                TestSingleton("BAR");
            });

            process1.Start();
            process2.Start();

            process1.Join();
            process2.Join();
            
            Console.ReadLine();
        }

        public static void TestSingleton(string value)
        {
            SingletoneThreadSafe singleton = SingletoneThreadSafe.GetInstance(value);
            Console.WriteLine(singleton.Value);
        }
    }
}