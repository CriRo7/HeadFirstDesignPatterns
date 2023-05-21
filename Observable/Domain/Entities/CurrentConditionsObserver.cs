using System;

namespace Observable.Domain.Entities
{
    public class CurrentConditionsObserver: Interfaces.IObserver<int>
    {
        public void Update(int state)
        {
            Console.WriteLine($"Current condition is: {state.ToString()}");
        }
    }
}