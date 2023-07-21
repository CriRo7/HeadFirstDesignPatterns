namespace DecoratorPattern.FromHeadFirstBook.ConcreteBeverages
{
    public class DarkRoast : Beverage
    {
        private const double BeverageCost = .99;

        public DarkRoast()
        {
            Description = "DarkRoast";
        }

        public override double Cost() => BeverageCost;
    }
}