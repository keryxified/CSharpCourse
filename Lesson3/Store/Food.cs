namespace Lesson3.Store
{
    internal record Food : StoreItem, IHasShelfLife
    {
        public int Calories { get; }
        public DateTime ExpirationDate { get; }

        public Food(string name, string id, string isbn, decimal price, string expDate, int calories) : base(name, id, isbn, price)
        {
            ExpirationDate = DateTime.Parse(expDate);
            Calories = calories;
        }

        public override string ToString()
        {
            return $"ID:\t{ID}\nName:\t{Name}\nCalories:\t{Calories}\nExp.Date:\t{ExpirationDate}\nISBN:\t{Isbn}\nPrice:\t{Price}$\n";
        }
    }
}