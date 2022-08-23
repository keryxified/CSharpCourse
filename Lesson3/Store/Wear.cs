namespace Lesson3.Store
{
    internal enum Season
    {
        Winter,
        Spring,
        Summer,
        Autumn
    }

    internal record Wear : StoreItem
    {
        public string Size { get; }
        public Season seasonType { get; }

        public Wear(string name, string id, string isbn, decimal price, string size, string season) : base(name, id, isbn, price)
        {
            Size = size;
            Enum.TryParse(season, out Season seasonType);
        }

        public override string ToString()
        {
            return $"ID:\t{ID,-5}\nName:\t{Name}\nSize:\t{Size}\nSeason:\t{seasonType}\nISBN:\t{Isbn}\nPrice:\t{Price}$\n";
        }
    }
}