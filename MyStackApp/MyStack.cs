namespace MyStackApp
{
    public class MyStack<T>
    {
        private List<T> Items { get; set; } = new();
        public bool IsEmpty()
        {
            return !Items.Any();
        }
        public void Push(T item)
        {
            Items.Add(item);
        }
        public int Size()
        {
            return Items.Count;
        }

        public T Pop()
        {
            var last = Items.Last();
            Items.Remove(last);
            return last;
        }
    }
}
