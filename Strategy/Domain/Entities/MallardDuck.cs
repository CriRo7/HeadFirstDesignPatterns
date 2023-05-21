using HeadFirstDesignPatterns.Domain.Behaviors.FlyBehavior;
using HeadFirstDesignPatterns.Domain.Behaviors.QuackBehavior;
using System;

namespace HeadFirstDesignPatterns.Domain
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            _flyBehavior = new FlyWithWings();
            _quackBehavior = new Quacky();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}
