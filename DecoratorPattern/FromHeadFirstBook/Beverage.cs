namespace DecoratorPattern.FromHeadFirstBook
{
    public abstract class Beverage
    {
        protected string Description = "Unknown Beverage";

        public virtual string GetDescription() => Description;

        public abstract double Cost();
    }
}