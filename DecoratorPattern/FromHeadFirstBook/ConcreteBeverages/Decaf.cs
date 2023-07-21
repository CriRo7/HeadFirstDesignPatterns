namespace DecoratorPattern.FromHeadFirstBook.ConcreteBeverages
{
    public class Decaf : Beverage
    {
        private const double BeverageCost = 1.05;

        public Decaf()
        {
            Description = "Decaf";
        }

        public override double Cost() => BeverageCost;
    }
}