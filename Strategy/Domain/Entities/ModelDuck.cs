using HeadFirstDesignPatterns.Domain.Behaviors.FlyBehavior;
using HeadFirstDesignPatterns.Domain.Behaviors.QuackBehavior;
using System;

namespace HeadFirstDesignPatterns.Domain.Entities
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            _flyBehavior = new FlyNoWay();
            _quackBehavior = new Quacky();
        }

        public override void Display()
        {
            Console.WriteLine("I'm model duck");
        }
    }
}
