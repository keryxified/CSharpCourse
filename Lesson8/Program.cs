using Lesson8.Builder;

namespace Lesson8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your index:");
            var index = InputCheck.IndexChecker();
            Console.WriteLine("Please enter your country:");
            var country = InputCheck.TextInputChecker();
            Console.WriteLine("Please enter your region:");
            var region = InputCheck.TextInputChecker();
            Console.WriteLine("Please enter your city:");
            var city = InputCheck.TextInputChecker();
            Console.WriteLine("Please enter your house number:");
            var house = InputCheck.HouseApartmentsChecker();
            Console.WriteLine("Please enter your apartments number:");
            var apartments = InputCheck.HouseApartmentsChecker();
            UserAddress userAddress = new UserAddress();
            AddressBuilder builder = new AddressBuilder();
            userAddress = builder.WithIndex(index).WithCity(city).Build();
        }
    }
}