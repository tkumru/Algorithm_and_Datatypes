

namespace Array_and_Collections.LinkedList.SinglyLinkedList
{
    public class SinglyLinkedListNode<T>
    {
        public SinglyLinkedListNode<T> Next {get; set;}  // go to after node
        public T Value {get; set;}

        public SinglyLinkedListNode(T value)
        {
            Value = value;
        }

        public override string ToString() => $"{Value}";
    }
}
