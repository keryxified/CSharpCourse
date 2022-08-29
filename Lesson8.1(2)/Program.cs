namespace Lesson8._1_2_
{
    internal class Program
    {
        static void Main(string[] args)
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