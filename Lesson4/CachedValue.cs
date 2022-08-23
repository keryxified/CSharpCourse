namespace Lesson_4
{
    internal record CachedValue<T>
    {
        public T Value { get; set; }
        public DateTime CreationTime { get; set; }
        public int Timeout { get; set; }
    }
}