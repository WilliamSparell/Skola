namespace Datalogi_övning_1
{
    public class MyNode<T>
    {
        public T Data { get; set; }
        public MyNode<T> Next { get; set; }
        public MyNode<T> Previous { get; set; }
    }
}

