using System.Text.RegularExpressions;

namespace Lesson8
{
    public class AddressBuilder : IGetAddress
    {
        private UserAddress _userAddress;

        public void GetApartments()
        {
            Console.Write("\nPlease enter your house number:");
            _userAddress.Apartments = HouseApartmentsChecker();
        }

        public void GetCity()
        {
            Console.Write("\nPlease enter your city:");
            _userAddress.City = TextInputChecker();
        }

        public void GetCountry()
        {
            Console.Write("\nPlease enter your country:");
            _userAddress.Country = TextInputChecker();
        }

        public void GetHouse()
        {
            Console.Write("\nPlease enter your house number:");
            _userAddress.House = HouseApartmentsChecker();
        }

        public void GetIndex()
        {
            Console.Write("\nPlease enter your index:");
            _userAddress.Index = IndexChecker();
        }

        public void GetRegion()
        {
            Console.Write("\nPlease enter your region:");
            _userAddress.Region = TextInputChecker();
        }

        public void GetStreet()
        {
            Console.Write("\nPlease enter your street:");
            _userAddress.Street = TextInputChecker();
        }

        public UserAddress GetAddress()
        {
            GetCountry();
            GetIndex();
            GetRegion();
            GetCity();
            GetStreet();
            GetHouse();
            GetApartments();
            return _userAddress;
        }

        private string TextInputChecker()
        {
            string text = Console.ReadLine();
            while (!Regex.IsMatch(text, @"^[a-zA-Z]+$"))
            {
                Console.WriteLine($"Please enter correct text! It should contain only latin letters.");
                text = Console.ReadLine();
            }
            return text;
        }
        private int IndexChecker()
        {
            var numberInput = Console.ReadLine();
            int number;
            bool IsIndexParsed = int.TryParse(numberInput, out number) && (number.ToString().Length > 5 && number.ToString().Length < 7);
            while (!IsIndexParsed)
            {
                Console.WriteLine("Please enter correct number above zero");
                IsIndexParsed = int.TryParse(Console.ReadLine(), out number) && (number.ToString().Length > 5 && number.ToString().Length < 7);
            }
            return number;
        }

        private short HouseApartmentsChecker()
        {
            var numberInput = Console.ReadLine();
            short number;
            bool IsNumberParsed = short.TryParse(numberInput, out number) && (number > 0 && number < 1000);
            while (!IsNumberParsed)
            {
                Console.WriteLine("Please enter correct number more than zero and less than 999");
                IsNumberParsed = short.TryParse(Console.ReadLine(), out number) && (number > 0 && number < 1000);
            }
            return number;
        }
    }
}