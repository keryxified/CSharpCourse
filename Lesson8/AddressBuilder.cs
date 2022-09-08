using System.Text.RegularExpressions;

namespace Lesson8
{
    public class AddressBuilder : IGetAddress
    {
        private UserAddress _userAddress = new();

        public AddressBuilder WithApartments(short inputApartments)
        {
            Console.Write("\nPlease enter your house number:");
            _userAddress.Apartments = inputApartments;
            return this;
        }

        public AddressBuilder WithCity(string inputCity)
        {
            Console.Write("\nPlease enter your city:");
            _userAddress.City = inputCity;
            return this;
        }

        public AddressBuilder WithCountry(string inputCountry)
        {
            Console.Write("\nPlease enter your country:");
            _userAddress.Country = inputCountry;
            return this;
        }

        public AddressBuilder WithHouse(short inputHouse)
        {
            Console.Write("\nPlease enter your house number:");
            _userAddress.House = inputHouse;
            return this;
        }

        public AddressBuilder WithIndex(int inputIndex)
        {
            Console.Write("\nPlease enter your index:");
            _userAddress.Index = inputIndex;
            return this;
        }

        public AddressBuilder WithRegion(string inputRegion)
        {
            Console.Write("\nPlease enter your region:");
            _userAddress.Region = inputRegion;
            return this;
        }

        public AddressBuilder WithStreet(string inputStreet)
        {
            Console.Write("\nPlease enter your street:");
            _userAddress.Street = inputStreet;
            return this;
        }

        public UserAddress Build()
        {
            return _userAddress;
        }
    }
}