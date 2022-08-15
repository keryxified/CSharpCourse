using Lesson3.Store;

namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Food carnitine = new Food("L-Carnitine", "001056", "9782123456803", 30.50m, "2023-05-20", 150);
            Wear columbiaCoat = new Wear("Columbia Winter Coat", "001153", "9782563256803", 120m, "XL", "Winter");
            Equipment dumbbels10kg = new Equipment("Dumbells 10kg", "001138", "9782563256803", 50);
            Console.WriteLine(carnitine);
            Console.WriteLine(columbiaCoat);
            Console.WriteLine(dumbbels10kg);

        }
    }
}