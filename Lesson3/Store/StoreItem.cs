namespace Lesson10.Store
{
    internal record StoreItem
    {
        public string ID { get; }
        public string Name { get; }
        public string Isbn { get; }
        public decimal Price { get; }

        public StoreItem(string name, string id, string isbn, decimal price)
        {
            Isbn = isbn;
            Name = name;
            ID = id;
            Price = price;
        }

        public override string ToString()
        {
            return $"ID:\t{ID}\nName:\t{Name}\nISBN:\t{Isbn}\nPrice:\t{Price}$\n";
        }
    }
}