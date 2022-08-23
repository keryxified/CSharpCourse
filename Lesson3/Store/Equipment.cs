namespace Lesson3.Store
{
    internal record Equipment : StoreItem
    {
        public Equipment(string name, string id, string isbn, decimal price) : base(name, id, isbn, price)
        {
        }
    }
}