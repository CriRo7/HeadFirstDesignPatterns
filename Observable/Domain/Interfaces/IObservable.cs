namespace Observable.Domain.Interfaces
{
    public interface IObservable<T>
    {
        public void RegisterObserver(IObserver<T> observer);
        public void RemoveObserver(IObserver<T> observer);

        public void Notify(T state);
    }
}