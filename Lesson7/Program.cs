namespace Lesson7
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Please enter first number: ");
            int FirstArg = int.Parse(Console.ReadLine());
            Console.Write("\nPlease enter second number: ");
            int SecondArg = int.Parse(Console.ReadLine());
            var startNumber = Math.Min(FirstArg, SecondArg);
            var finishNumber = Math.Max(FirstArg, SecondArg);
            Parallel.For(startNumber, finishNumber, RootsCalc);
        }

        public static void RootsCalc(int a)
        {
            Console.WriteLine($"Square root for {a} is {Math.Sqrt(a)}.");
        }
    }
}