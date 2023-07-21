namespace DecoratorPattern.FromHeadFirstBook.Decorators
{
    public class Milk : Beverage
    {
        private const double BeverageCost = .10; 
        private readonly Beverage _beverage;

        public Milk(Beverage beverage)
        {
            _beverage = beverage;
            Description = $"{_beverage.GetDescription()} with {nameof(Milk)}";
        }
        
        public override double Cost() => _beverage.Cost() + BeverageCost;
    }
}