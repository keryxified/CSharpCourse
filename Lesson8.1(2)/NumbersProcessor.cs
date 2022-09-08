namespace Lesson8Observer
{
    public class NumbersProcessor : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        public int[] resultArray;

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void ProcessNumbers()
        {
            Console.WriteLine("Hello! Please enter the numbers, separated by a space.");
            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            resultArray = Array.ConvertAll(input, int.Parse);
            NotifyObservers();
        }
    }
}