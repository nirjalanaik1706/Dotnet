
using TFLCollections.DoublyLinkedList;

namespace TFLCollections.DoublyLinkedList;
public class DoublyNode<T>
{
    public T data;
    public DoublyNode<T> ?next;
    public DoublyNode<T> ?previous;


    public DoublyNode(T data)
    {
        this.data=data;
        this.next=null;
        this.previous=null;
    }
}