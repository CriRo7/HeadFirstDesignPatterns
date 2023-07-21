namespace DecoratorPattern.FromHeadFirstBook.ConcreteBeverages
{
    public class Espresso : Beverage
    {
        private const double BeverageCost = 1.99;

        public Espresso()
        {
            Description = "Espresso";
        }
        
        public override double Cost() => BeverageCost;
    }
}