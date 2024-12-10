using System;

namespace CoffeeDecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // a Basic Coffee
            ICoffee myCoffee = new BasicCoffee();
            Console.WriteLine($"{myCoffee.GetDescription()} - ${myCoffee.GetCost()}");

            // Add Milk to the Coffee
            myCoffee = new MilkDecorator(myCoffee);
            Console.WriteLine($"{myCoffee.GetDescription()} - ${myCoffee.GetCost()}");

            // Add Sugar to the Coffee
            myCoffee = new SugarDecorator(myCoffee);
            Console.WriteLine($"{myCoffee.GetDescription()} - ${myCoffee.GetCost()}");

            // Add Espresso Shot to the Coffee
            myCoffee = new EspressoDecorator(myCoffee);
            Console.WriteLine($"{myCoffee.GetDescription()} - ${myCoffee.GetCost()}");
        }
    }
}
