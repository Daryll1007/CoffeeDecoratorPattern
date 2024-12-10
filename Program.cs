using System;

namespace CoffeeDecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a ConcreteComponent object
            IComponent<string> component = new ConcreteComponent();

            // Apply decorators
            IComponent<string> decoratedPlain = new PlainDecorator(component);
            IComponent<string> decoratedUpperCase = new UpperCaseDecorator(decoratedPlain);
            IComponent<string> decoratedColor = new ColorDecorator(decoratedUpperCase);

            // Print the result after applying decorators
            Console.WriteLine("Original: " + component.GetText());
            Console.WriteLine("After PlainDecorator: " + decoratedPlain.GetText());
            Console.WriteLine("After UpperCaseDecorator: " + decoratedUpperCase.GetText());
            Console.WriteLine("After ColorDecorator: " + decoratedColor.GetText());
        }
    }
}
