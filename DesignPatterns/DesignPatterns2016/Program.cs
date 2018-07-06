using System;

namespace DesignPatterns2016
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Run();
            //Console.ReadLine();
        }

        public static void Run()
        {
            CarFactory_Runner();

        }

        
        public static void CarFactory_Runner()
        {
            FactoryMethod.CarFactory.GetACarPrices();
        }
    }
}
