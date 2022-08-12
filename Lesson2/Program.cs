using System.Text.RegularExpressions;

namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("Please, enter your name:");
            string name;
            do
            {
                name = Console.ReadLine();

            }
            while (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
            {
                
            }
            


        }
    }
}