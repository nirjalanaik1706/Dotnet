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
        Console.WriteLine("After Inserting a data at Front: ");
        list.display();
        list.insertAtMiddle(35);
        Console.WriteLine("After Inserting a data in Middle: ");
        list.display();
        list.insertAtEnd(80);
        Console.WriteLine("After Inserting a data at End");
        list.display();
        list.Update(20,50);
        Console.WriteLine("After Updating a value: ");
        list.display();
        list.delete(50);
        Console.WriteLine("After deleting a data: ");
        list.display();
    }
}