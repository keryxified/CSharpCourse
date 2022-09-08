using System.Text.RegularExpressions;

namespace Lesson8
{
    public class AddressBuilder : IGetAddress
    {
        private UserAddress _userAddress = new();
        private string _textAddress;

        public AddressBuilder WithApartments(short inputApartments)
        {
            _userAddress.Apartments = inputApartments;
            _textAddress += $"\nApartments number:{inputApartments}";
            return this;
        }

        public AddressBuilder WithCity(string inputCity)
        {
            _userAddress.City = inputCity;
            _textAddress += $"\nCity:{inputCity}";
            return this;
        }

        public AddressBuilder WithCountry(string inputCountry)
        {
            _userAddress.Country = inputCountry;
            _textAddress += $"\nCountry:{inputCountry}";
            return this;
        }

        public AddressBuilder WithHouse(short inputHouse)
        {
            _userAddress.House = inputHouse;
            _textAddress += $"\nHouse number:{inputHouse}";
            return this;
        }

        public AddressBuilder WithIndex(int inputIndex)
        {
            _userAddress.Index = inputIndex;
            _textAddress += $"\nIndex number:{inputIndex}";
            return this;
        }

        public AddressBuilder WithRegion(string inputRegion)
        {
            _userAddress.Region = inputRegion;
            _textAddress += $"\nRegion:{inputRegion}";
            return this;
        }

        public AddressBuilder WithStreet(string inputStreet)
        {
            _userAddress.Street = inputStreet;
            _textAddress += $"\nStreet:{inputStreet}";
            return this;
        }

        public UserAddress Build()
        {
            Console.WriteLine(_textAddress);
            return _userAddress;
        }
    }
}