using Lesson8.Builder;

namespace Lesson8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserAddress userAddress = new UserAddress();
            AddressBuilder builder = new AddressBuilder();
            userAddress = builder.WithIndex().WithCity().Build();
            Console.WriteLine(userAddress);
        }
    }
}