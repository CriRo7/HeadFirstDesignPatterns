using System.Collections.Generic;
using Observable.Domain.Interfaces;

namespace Observable.Domain.Entities
{
    public class WheatherData<T> : IObservable<T>
    {
        private readonly ICollection<IObserver<T>> _observers;

        public WheatherData()
        {
            _observers = new List<IObserver<T>>();
        }
        
        public void RegisterObserver(IObserver<T> observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver<T> observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(T state)
        {
            foreach (var observer in _observers)
            {
                observer.Update(state);
            }
        }

        public void SetState(T newState)
        {
            Notify(newState);
        }
    }
}