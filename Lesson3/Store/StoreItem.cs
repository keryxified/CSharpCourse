namespace Lesson3.Store
{
    internal class StoreItem
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }

        public StoreItem(string name, string id, string isbn, decimal price)
        {
            ISBN = isbn;
            Name = name;
            ID = id;
            Price = price;
        }

        public override string ToString()
        {
            return $"ID:\t{ID}\nName:\t{Name}\nISBN:\t{ISBN}\nPrice:\t{Price}$\n";
        }
    }
}