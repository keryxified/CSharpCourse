using System.Text;

namespace Lesson8
{
    public class UserAddress
    {
        public int Index { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public short House { get; set; }
        public short Apartments { get; set; }

        public override string ToString()
        {
            return $"Your address:" +
                $"\nCOUNTRY:\t\t{Country}" +
                $"\nINDEX:\t\t{Index}" +
                $"\nREGION:\t\t{Region}" +
                $"\nCITY:\t\t{City}" +
                $"\nSTREET:\t\t{Street}" +
                $"\nHOUSE:\t\t{House}" +
                $"\nAPARTMENTS:\t\t{Apartments}"; 
        }



    }
}