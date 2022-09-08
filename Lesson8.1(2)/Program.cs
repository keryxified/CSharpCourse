namespace Lesson8Observer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var processor = new NumbersProcessor();
            var sumOfElements = new SumOfElements();
            var reverseArray = new ReverseArray();
            processor.AddObserver(sumOfElements);
            processor.AddObserver(reverseArray);
            processor.ProcessNumbers();
        }
    }
}