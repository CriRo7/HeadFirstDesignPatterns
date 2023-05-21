using HeadFirstDesignPatterns.Domain;
using HeadFirstDesignPatterns.Domain.Behaviors.FlyBehavior;
using HeadFirstDesignPatterns.Domain.Entities;
using System;

namespace HeadFirstDesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new MallardDuck();
            duck.PerformQuack();
            duck.PerformFly();
            duck.Swim();

            duck = new ModelDuck();
            duck.SetFlyBehavior(new FlyRocketPowered());
            duck.PerformQuack();
            duck.PerformFly();
            duck.Swim();
        }
    }
}
