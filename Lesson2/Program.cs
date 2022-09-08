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
                bool isValidText;
                do
                {
                    isValidText = (Regex.IsMatch(text, @"^[a-zA-Z]+$"));
                    if (!isValidText)
                    {
                        Console.WriteLine($"Please enter correct text! It should contain only latin letters.");
                        text = Console.ReadLine();
                    }
                }
                while (!isValidText);
                return text;
            }

            int AgeChecker()
            {
                int age;
                bool isValidAge;
                do
                {
                    isValidAge = int.TryParse(Console.ReadLine(), out age) && (age > 9 && age < 101);
                    if (!isValidAge)
                    {
                        Console.WriteLine("Please enter correct number from 10 to 99!");
                    }
                }
                while (!isValidAge);
                return age;
            }
        }
    }
}