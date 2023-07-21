namespace DecoratorPattern.FromHeadFirstBook.Decorators
{
    public class Whip : Beverage
    {
        private const double BeverageCost = .10; 
        private readonly Beverage _beverage;

        public Whip(Beverage beverage)
        {
            _beverage = beverage;
            Description = $"{_beverage.GetDescription()} with {nameof(Whip)}";
        }

        public override double Cost() => _beverage.Cost() + BeverageCost;
    }
}