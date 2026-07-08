namespace TFLDSA.Collections.CirculerLinkedList;

using TFLDSA.Collections.CirculerList;

public class CirculerLinkedList
{
    CirculerNode head = null;
    public void insertAtFront(int data)
    {
        CirculerNode newData = new CirculerNode(data);

        if (head == null)
        {
            head = newData;
            head.next = head;
        }
        else
        {
            CirculerNode current = head;
            while (current.next != head)
            {
                current = current.next;
            }
            newData.next = head;
            current.next = newData;
            head = newData;
        }
    }

    public void insertAtEnd(int data)
    {
        CirculerNode current = head;
        CirculerNode newData = new CirculerNode(data);
        if (head == null)
        {
            head = newData;
            head.next = head;
        }
        else
        {
            while (current.next != head)
            {
                current = current.next;
            }
            current.next = newData;
            newData.next = head;
        }
    }

    public void insertAtMiddle(int data)
    {

        CirculerNode newData = new CirculerNode(data);

        CirculerNode current = head;
        while (current.next != head && current.next.data < data)
        {
            current = current.next;
        }
        newData.next = current.next;
        current.next = newData;
    }

    public void Update(int oldData, int newData)
    {
        CirculerNode current = head;
        while (current.data != oldData)
        {
            current = current.next;
        }
        current.data = newData;

    }

    public void delete(int data)
    {
        CirculerNode current = head;
        if (head.data == data)
        {
            if (head.next == head)
            {
                head = null;
            }
            else
            {
                while (current.next != head)
                {
                    current = current.next;
                }

                current.next = head.next;
                head = head.next;
            }
        }
        else
        {
            current = head;
            while (current.next != head && current.next.data != data)
            {
                current = current.next;
            }

            if (current.next.data == data)
            {
                current.next = current.next.next;
            }
            else
            {
                Console.WriteLine("Node not found.");
            }
        }
    }


    public void display()
    {
        CirculerNode current = head;
        while (current.next != head)
        {
            Console.Write(current.data + "---->");

            current = current.next;
        }
        Console.WriteLine(current.data + "---->");
    }
}
