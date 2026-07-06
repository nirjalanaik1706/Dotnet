namespace tfldsa.main;
using TFLDSA.Node;
using TFLDSA.DoublyLinkedList;

public class Program
{
    public static void Main(string[] args)
    {
        DoublyLinkedList dl=new DoublyLinkedList();
        dl.insertAtEnd(23);
        dl.insertAtEnd(24);
        dl.insertAtEnd(30);
        dl.insertInMiddle(70);

        dl.display();
        Console.WriteLine();
        dl.insertInFront(0);
        dl.insertInMiddle(90);
        dl.display();
        Console.WriteLine();
        dl.update(90,10);
        dl.display();
        Console.WriteLine();
        dl.delete(70);
        dl.display();
    }
}
