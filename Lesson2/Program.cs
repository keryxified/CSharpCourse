using System.Text.RegularExpressions;

namespace Lesson2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello!");

            Console.WriteLine("Please enter your name:");
            var name = TextInputChecker();
            Console.WriteLine("Please enter your surname:");
            var surname = TextInputChecker();
            Console.WriteLine("Please enter your age:");
            var age = AgeChecker();
            Console.WriteLine("Please enter your hobby:");
            var hobby = TextInputChecker();

            Console.WriteLine($"Name: {name}\nSurname: {surname}\nAge: {age}\nHobby: {hobby}");

            string TextInputChecker()
            {
                string text = Console.ReadLine();
                while (!Regex.IsMatch(text, @"^[a-zA-Z]+$"))
                {
                    Console.WriteLine($"Please enter correct text! It should contain only latin letters.");
                    text = Console.ReadLine();
                }
                return text;
            }

            int AgeChecker()
            {
                var ageInput = Console.ReadLine();
                int age;
                bool IsAgeParsed = int.TryParse(ageInput, out age) && (age > 9 && age < 101);
                while (!IsAgeParsed)
                {
                    Console.WriteLine("Please enter correct number from 10 to 99");
                    IsAgeParsed = int.TryParse(Console.ReadLine(), out age) && (age > 9 && age < 100);
                }
                return age;
            }
        }
    }
}