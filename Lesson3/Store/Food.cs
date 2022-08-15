namespace Lesson3.Store
{
    internal class Food : StoreItem, IHasShelfLife
    {
        //public DateTime ExpDate { get; set; }
        public int Calories { get; set; }
        public DateTime ExpirationDate { get; set; }

        public Food(string name, string id, string isbn, decimal price, string expDate, int calories) : base(name, id, isbn, price)
        {
            ExpirationDate = DateTime.Parse(expDate);
            Calories = calories;
        }
        public override string ToString()
        {
            return $"ID:\t{ID}\nName:\t{Name}\nCalories:\t{Calories}\nExp.Date:\t{ExpirationDate}\nISBN:\t{ISBN}\nPrice:\t{Price}$\n";
        }


    }
}