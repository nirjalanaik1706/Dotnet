namespace TFLDSA.DoublyLinkedList;

using TFLDSA.Node;


public class DoublyLinkedList
{

    Node head=null;    
    

    public void insertInFront(int data)
    {
        Node newData=new Node(data);
        newData.next=head;
        head=newData;

    }
    public void insertAtEnd(int data)
    {
        Node newData = new Node(data);
        if (head == null)
        {
            head=newData;
        }
        else{
            Node current=head;
            while (current.next != null)
            {
                current=current.next;
            }
            current.next=newData;
            newData.previous=current;
            
        }
    }

    public void insertInMiddle(int data)
    {
        Node newData=new Node(data);
        Node current;
        current=head;
            while (current.next!=null&&current.next.data < data)
            {
                current=current.next;
            }
            newData.next=current.next;
            current.next=newData;
            newData.previous=current;
            current.next.previous=newData;
            

        
    }

    public void update(int oldData,int newData)
    {
        Node current=head;
        if (head.data == oldData)
        {
            head.data=oldData;
        }
        else{
            while (current.data != oldData)
            {
                current=current.next;
            }
            current. data=newData;
        }
    }

    public void delete(int data)
    {
            Node current=head;
        if (head.data == data)
        {
            if (head.next == null)
            {
                head=null;
            }
            else
            {
                head=head.next;
            }
        }
        else
        {
            while (current.next.data != data)
            {
                current=current.next;
            }
            if (current.next.next == null)
            {
                current.next=null;
            }
            else
            {
                current.next=current.next.next;
                current.next.next=
            }
        }
    }
    // public void display()
    // {
    //     Node current = head;
    //     while (current != null)
    //     {
    //         Console.Write(current.data + "--->");
    //         current = current.next;
    //     }
    // }
    public void display()
        {
            Node last=null;;
            Node current = head;
            Console.WriteLine("\n\n\nNext Element: ");
            Console.Write("null--->");
            while (current != null)
            {
                Console.Write(current.data+"--->");
                last=current;
                current = current.next;
            }
            Console.Write("null\n");
            // Console.WriteLine("Prev Element");
            // Console.Write("null");
            // current=last;
            // while (current != null)
            // {
            //     Console.Write("<---"+ current.data);
            //     current = current.previous;
            // }
            // Console.Write("<---null");
        }
}