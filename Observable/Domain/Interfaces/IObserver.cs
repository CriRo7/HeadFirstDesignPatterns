namespace Observable.Domain.Interfaces
{
    public interface IObserver<in T>
    {
        public void Update(T state);
    }
}