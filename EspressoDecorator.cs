namespace CoffeeDecoratorPattern
{
    public class EspressoDecorator : CoffeeDecorator
    {
        public EspressoDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription()
        {
            return _coffee.GetDescription() + ", with Espresso Shot";
        }

        public override double GetCost()
        {
            return _coffee.GetCost() + 1.50;  // Espresso shot cost
        }
    }
}
