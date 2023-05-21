using System;

namespace Observable.Domain.Entities
{
    public class StatisticsObserver : Interfaces.IObserver<int>
    {
        public void Update(int state)
        {
            Console.WriteLine($"Statistic is: {state.ToString()}");
        }
    }
}