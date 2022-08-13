using System.Text.RegularExpressions;

namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            while (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
            {
                Console.WriteLine("Please enter correct name!");
                name = Console.ReadLine();
            }
            Console.WriteLine("Please enter your surname:");
            string surname = Console.ReadLine();
            while (!Regex.IsMatch(surname, @"^[a-zA-Z]+$"))
            {
                Console.WriteLine("Please enter correct surname!");
                surname = Console.ReadLine();
            }
            Console.WriteLine("Please enter your age:");
            string ageinput = Console.ReadLine();
            int age = 0;
            while (!int.TryParse(ageinput, out age))
            {
                Console.WriteLine("Please, enter the valid age. It should be a number.");
                ageinput = Console.ReadLine();
            }
            Console.WriteLine("Please enter your hobby:");
            string hobby = Console.ReadLine();
            while (!Regex.IsMatch(hobby, @"^[a-zA-Z]+$"))
            {
                Console.WriteLine("Please enter correct hobby!");
                surname = Console.ReadLine();
            }

            Console.WriteLine($"Name: {name}\nSurname: {surname}\nAge: {age}\nHobby: {hobby}");



        }
    }
}