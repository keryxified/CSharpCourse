namespace Lesson8Events
{
    public class NumbersProcessor
    {
        public delegate void NumbersProcessorDelegate(int[] value);

        public event NumbersProcessorDelegate ProcessNumbers;

        public void NumbersInput()
        {
            Console.WriteLine("Hello! Please enter the numbers, separated by a space.");
            var input = Console.ReadLine().Split(" ");
            int[] resultArray = Array.ConvertAll(input, int.Parse);
            ProcessNumbers(resultArray);
        }
    }
}