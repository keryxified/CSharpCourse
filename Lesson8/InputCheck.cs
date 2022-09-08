using System.Text.RegularExpressions;

namespace Lesson8.Builder
{
    public static class InputCheck
    {
        public static int IndexChecker()
        {
            int number;
            bool isIndexParsed;
            do
            {
                isIndexParsed = int.TryParse(Console.ReadLine(), out number) && number.ToString().Length is > 5 and < 7;
                if (!isIndexParsed)
                {
                    Console.WriteLine("Please enter correct number above zero");
                }
            }
            while (!isIndexParsed);
            return number;
        }

        public static short HouseApartmentsChecker()
        {
            short number;
            bool isNumberParsed;
            do
            {
                isNumberParsed = short.TryParse(Console.ReadLine(), out number) && number is > 0 and < 1000;
                if (!isNumberParsed)
                {
                    Console.WriteLine("Please enter correct number more than zero and less than 999");
                }
            }
            while (!isNumberParsed);
            return number;
        }

        public static string TextInputChecker()
        {
            string text = Console.ReadLine();
            while (!Regex.IsMatch(text, @"^[a-zA-Z]+$"))
            {
                Console.WriteLine($"Please enter correct text! It should contain only latin letters.");
                text = Console.ReadLine();
            }
            return text;
        }
    }
}