using System;

namespace Observable.Domain.Entities
{
    public class CustomObserver : Interfaces.IObserver<string>
    {
        public void Update(string state)
        {
            Console.WriteLine($"Custom state is : {state}");
        }
    }
}