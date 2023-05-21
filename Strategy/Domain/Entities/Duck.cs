using System;

namespace HeadFirstDesignPatterns.Domain
{
    public abstract class Duck
    {
        protected IFlyBehavior _flyBehavior;
        protected IQuackBehavior _quackBehavior;

        public abstract void Display();

        public void PerformFly()
        {
            _flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            _quackBehavior.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks can swim");
        }

        public void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            _flyBehavior = flyBehavior;
        }

        public void SetFlyBehavior(IQuackBehavior quackBehavior)
        {
            _quackBehavior = quackBehavior;
        }
    }
}
