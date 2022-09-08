namespace Lesson8
{
    public interface IGetAddress
    {
        AddressBuilder WithIndex(int input);
        AddressBuilder WithCountry(string input);
        AddressBuilder WithRegion(string input);
        AddressBuilder WithCity(string input);
        AddressBuilder WithStreet(string input);
        AddressBuilder WithHouse(short input);
        AddressBuilder WithApartments(short input);
        UserAddress Build();
    }
}
