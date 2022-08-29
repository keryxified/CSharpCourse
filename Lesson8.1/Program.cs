namespace Lesson8._1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var processor = new NumbersProcessor();
            processor.ProcessNumbers += ReverseArray;
            processor.ProcessNumbers += SumOfElements;
            processor.NumbersInput();
        }

        public static void SumOfElements(int[] input)
        {
            Console.WriteLine($"\nSum of the elements is {input.Sum()}");
        }

        public static void ReverseArray(int[] input)
        {
            Array.Reverse(input);
            Console.Write($"\nReversed array is: ");
            foreach (var number in input)
                Console.Write(number + " ");
        }
    }
}