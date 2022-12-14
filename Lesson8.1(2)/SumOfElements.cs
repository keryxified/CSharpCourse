namespace Lesson8Observer
{
    internal class SumOfElements : IObserver
    {
        public void Update(ISubject subject)
        {
            int[] array = (subject as NumbersProcessor).resultArray;
            Console.WriteLine($"\nSum of the elements is {array.Sum()}");
        }
    }
}