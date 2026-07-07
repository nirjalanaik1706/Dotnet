namespace TFLDSA.DoublyLinkedList;

using TFLDSA.Node;


public class DoublyLinkedList
{

    Node head=null; 
    Node tail=null;   

    public void insertInFront(int data)
    {
        Node newData=new Node(data);
        if (head == null)
        {
            head=newData; 
            tail=head;
        }
        else
        {
            head.previous=newData;
            newData.next=head;
            head=newData;
        }

    }

    public void insertAtEnd(int data){
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
            tail=newData;
            
        }
    }
    
        public void insertInMiddle(int data){
        Node newData = new Node(data);
        if (head == null)
        {
            head = newData;
            return;
        }
        if (data < head.data)
        {
            newData.next = head;
            head.previous = newData;
            head = newData;
            return;
        }
        Node current = head;
        while (current.next != null && current.next.data < data)
        {
            current = current.next;
        }
        if (current.next == null)
        {
            current.next = newData;
            newData.previous = current;
        }
        else
        {
            newData.next = current.next;
            current.next.previous = newData;
            newData.previous = current;
            current.next = newData;
        }
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
        if (head.data == data)
        {
            if (head.next == null)
            {
                head=null;
                tail=null;
            }
            else
            {
                head=head.next;
            }
        }
        else
        {
            Node current=head;
            while (current.next.data != data)
            {
                current=current.next;
            }
            if (current.next.next == null)
            {
                current.next=null;
                tail=current;
            }
            else
            {
                current.next=current.next.next;
                current.next.previous=current;
            }
        }
    }
    
    
    public void displayFromHead()
        {
            
            Node current = head;
            Console.WriteLine("\nNext Elements traversing: ");
            Console.Write("null--->");
            while (current != null)
            {
                Console.Write(current.data+"--->");
                current = current.next;
            }
            Console.Write("null");
        }

        public void displayFromTail()
    {
        Console.WriteLine("\nPrevious Elements traversing: ");
            Console.Write("null");
            Node current=tail;
            while (current != null)
            {
                Console.Write("<---"+ current.data);
                current = current.previous;
            }
            Console.Write("<---null");
    }
    }
