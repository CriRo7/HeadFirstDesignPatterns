namespace DecoratorPattern.FromHeadFirstBook.Decorators
{
    public class Soy : Beverage
    {
        private const double BeverageCost = .15; 
        private readonly Beverage _beverage;

        public Soy(Beverage beverage)
        {
            _beverage = beverage;
            Description = $"{_beverage.GetDescription()} with {nameof(Soy)}";
        }

        public override double Cost() => _beverage.Cost() + BeverageCost;
    }
}