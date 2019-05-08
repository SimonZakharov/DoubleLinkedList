namespace DoubleLinkedList
{
    public interface DoubleLinkedListNode<T>
    {
        T Value { get; set; }
        DoubleLinkedNode<T> Next { get; set; }
        DoubleLinkedNode<T> Prev { get; set; }
    }
}
