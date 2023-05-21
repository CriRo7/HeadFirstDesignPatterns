using System;

namespace Observable.Domain.Entities
{
    public class ForecastObserver : Interfaces.IObserver<int>
    {
        public void Update(int state)
        {
            Console.WriteLine($"Forecast is: {state.ToString()}");
        }
    }
}