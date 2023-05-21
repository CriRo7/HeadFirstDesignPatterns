using Observable.Domain.Entities;

namespace Observable
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var currentConditionObserver = new CurrentConditionsObserver();
            var forecastObserver = new ForecastObserver();
            var statisticsObserver = new StatisticsObserver();

            var customObserver = new CustomObserver();

            var observable = new WheatherData<int>();
            observable.RegisterObserver(currentConditionObserver);
            observable.RegisterObserver(forecastObserver);
            observable.RegisterObserver(statisticsObserver);
            // observable.RegisterObserver(customObserver);
            
            observable.Notify(4);
        }
    }
}