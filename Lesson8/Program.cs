namespace Lesson8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserAddress userAddress = new UserAddress();
            AddressBuilder builder = new AddressBuilder();
            userAddress =  builder.GetAddress();
            Console.WriteLine(userAddress);
        }
    }
}