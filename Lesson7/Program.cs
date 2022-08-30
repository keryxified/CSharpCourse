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
            Task task = new Task(() => RootsCalc(FirstArg, SecondArg));
            task.RunSynchronously();
        }

        public static void RootsCalc(int a, int b)
        {
            {
                Console.WriteLine("\nCalculation started...");
                if (a < b)
                {
                    for (var i = a; i <= b; i++)
                    {
                        Console.WriteLine($"Square root for {i} is {Math.Sqrt(i)}.");
                    }
                }
                else
                {
                    for (var i = a; i >= b; i--)
                    {
                        Console.WriteLine($"Square root for {i} is {Math.Sqrt(i)}.");
                    }
                }
                Console.WriteLine("Calculation ended!");
            }
        }
    }
}