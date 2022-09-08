namespace Lesson8Observer
{
    internal class ReverseArray : IObserver
    {
        public void Update(ISubject subject)
        {
            var resultArray = (subject as NumbersProcessor).resultArray;
            Array.Reverse(resultArray);
            Console.Write($"\nReversed array is: ");
            foreach (var number in resultArray)
                Console.Write(number + " ");
        }
    }
}