namespace DecoratorPattern.FromHeadFirstBook.Decorators
{
    public class Mocha : Beverage
    {
        private const double BeverageCost = .20; 
        private readonly Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
            Description = $"{_beverage.GetDescription()} with {nameof(Mocha)}";
        }
        public override double Cost() => _beverage.Cost() + BeverageCost;
    }
}