namespace Lesson3.Store
{
    internal interface IHasShelfLife
    {
        public DateTime ExpirationDate { get; }
    }
}