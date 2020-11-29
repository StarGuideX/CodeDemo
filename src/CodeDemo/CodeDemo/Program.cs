using CodeDemo.DesignPattern._09Decorate;
using System;

namespace CodeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            RunDecorateTest();
            Console.ReadLine();
        }

        private static void RunDecorateTest() 
        {
            Console.WriteLine("Decorate");
            Beverage beverage = new Water();
            Console.WriteLine("beverage Cost:{0}", beverage.Cost());
            Beverage milk = new Milk(beverage);
            Console.WriteLine("milk Cost:{0}", milk.Cost());
            Beverage mixBeverage = new Americano(milk);
            Console.WriteLine("Milk And Americano Cost:{0}", mixBeverage.Cost());
        }
    }
}
