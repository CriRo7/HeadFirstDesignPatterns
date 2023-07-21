namespace DecoratorPattern.FromHeadFirstBook.ConcreteBeverages
{
    public class HouseBlend : Beverage
    {
        private const double BeverageCost = .89;

        public HouseBlend()
        {
            Description = "HouseBlend";
        }

        public override double Cost() => BeverageCost;
    }
}