namespace Lesson10.Store
{
    internal interface IHasShelfLife
    {
        public DateTime ExpirationDate { get; }
    }
}