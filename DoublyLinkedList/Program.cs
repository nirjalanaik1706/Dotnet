namespace tfldsa.main;
using TFLDSA.Node;
using TFLDSA.DoublyLinkedList;
using System.Buffers;

public class Program
{
    public static void Main(string[] args)
    {
        DoublyLinkedList dl=new DoublyLinkedList();
        dl.insertAtEnd(23);
        dl.insertAtEnd(24);
        dl.insertAtEnd(30);
        Console.WriteLine("\n After Insert At end: ");
        dl.display();

        dl.insertInFront(0);
        Console.WriteLine("\n After Insert In Middle : ");
        dl.display();

        // dl.insertInMiddle(70);
        dl.insertInMiddle(90);
        Console.WriteLine("\nAfter inserting in middle: ");
        dl.display();

        dl.update(30,999);
        Console.WriteLine("\n After Update : ");
        dl.display();

        dl.delete(23);
        Console.WriteLine("\n After Delete: ");
        dl.display();
    }
}
