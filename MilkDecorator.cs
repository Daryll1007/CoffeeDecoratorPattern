namespace CoffeeDecoratorPattern
{
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription()
        {
            return _coffee.GetDescription() + ", with Milk";
        }

        public override double GetCost()
        {
            return _coffee.GetCost() + 0.75;  // Milk cost
        }
    }
}
