namespace CoffeeDecoratorPattern
{
    public class BasicCoffee : ICoffee
    {
        public string GetDescription()
        {
            return "Plain Coffee";
        }

        public double GetCost()
        {
            return 2.50;  // Cost of basic coffee
        }
    }
}
