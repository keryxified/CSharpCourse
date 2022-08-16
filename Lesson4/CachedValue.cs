namespace Lesson_4
{
    internal record CachedValue<T>
    {
        public T Value;
        public DateTime CreationTime;
        public int Timeout;
    }
}