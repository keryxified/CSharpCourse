namespace Lesson7
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Please enter first number: ");
            int firstArg = int.Parse(Console.ReadLine());
            Console.Write("\nPlease enter second number: ");
            int secondArg = int.Parse(Console.ReadLine());
            var startNumber = Math.Min(firstArg, secondArg);
            var finishNumber = Math.Max(firstArg, secondArg);
            var numbers = Enumerable.Range(startNumber, finishNumber - startNumber + 1);
            var results = numbers.AsParallel().AsOrdered().Select(item => new
            {
                Number = item,
                Root = Math.Sqrt(item),
            });

            foreach (var item in results)
            {
                Console.WriteLine($"The root for {item.Number} is {item.Root}");
            }
        }
    }
}