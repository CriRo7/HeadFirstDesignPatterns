using System;
using DecoratorPattern.FromHeadFirstBook.ConcreteBeverages;
using DecoratorPattern.FromHeadFirstBook.Decorators;

namespace DecoratorPattern.FromHeadFirstBook
{
    public class ClientCode
    {
        public static void Main()
        {
            var doubleMochaSoyLatteWithWhip = GetDoubleMochaSoyLatteWithWhip();
            PrintBeverage(doubleMochaSoyLatteWithWhip);

            var espresso = new Espresso();
            PrintBeverage(espresso);

            var darkRoast = GetDarkRoastWithDoubleMochaAndWhip();
            PrintBeverage(darkRoast);

            var houseBlend = GetHouseBlendWithSoyMochaAndWhip();
            PrintBeverage(houseBlend);
        }

        private static Beverage GetHouseBlendWithSoyMochaAndWhip()
        {
            return new Soy(
                new Mocha(
                    new Whip(new HouseBlend())));
        }

        private static Beverage GetDarkRoastWithDoubleMochaAndWhip()
        {
            return new Mocha(
                new Mocha(
                    new Whip(new DarkRoast())));
        }

        private static Beverage GetDoubleMochaSoyLatteWithWhip()
        {
            return new Mocha(
                new Mocha(
                    new Soy(
                        new Whip(new HouseBlend()))));
        }

        private static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(
                $"Beverage's {beverage.GetDescription()} cost is : {beverage.Cost():F2}");
        }
    }
}