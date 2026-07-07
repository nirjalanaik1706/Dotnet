using TFLDSA.Collections.CirculerLinkedList;

using TFLDSA.Collections.CirculerList;

public class Program
{
    public static void Main(string[] args)
    {
        CirculerLinkedList list = new CirculerLinkedList();
        list.insertAtFront(70);
        list.insertAtFront(60);
        list.insertAtFront(30);
        list.insertAtFront(20);
        list.display();
        list.insertAtMiddle(35);
        list.display();
        list.insertAtEnd(80);
        list.display();
    }
}