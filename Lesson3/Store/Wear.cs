using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.Store
{
    enum Season
    {
        Winter,
        Spring,
        Summer,
        Autumn
    }
    internal class Wear : StoreItem
    {   public string Size { get; set; }
        public Season seasonType { get; set; }

        public Wear(string name, string id, string isbn, decimal price, string size, string season) : base(name, id, isbn, price)
        {
            Size = size;
            Enum.TryParse(season, out Season seasonType);
        }

        public override string ToString()
        {
            return $"ID:\t{ID,-5}\nName:\t{Name}\nSize:\t{Size}\nSeason:\t{seasonType}\nISBN:\t{ISBN}\nPrice:\t{Price}$\n";
        }






    }
}
