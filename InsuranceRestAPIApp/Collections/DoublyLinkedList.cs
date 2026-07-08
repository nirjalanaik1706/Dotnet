using System.Collections;
using TFLCollections.DoublyLinkedList;



public class DoublyLinkedList<T>:IEnumerable<T>
{

    DoublyNode<T> head=null; 
    DoublyNode<T> tail=null;   

    public void insertInFront(T data)
    {
        DoublyNode<T> newData=new DoublyNode<T>(data);
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

    public void insertAtEnd(T data)
    {
        DoublyNode<T> newData = new DoublyNode<T>(data);
        if (head == null)
        {
            head=newData;
        }
        else{
            DoublyNode<T> current=head;
            while (current.next != null)
            {
                current=current.next;
            }
            current.next=newData;
            newData.previous=current;
            
        }
    }
    
    //     public void insertInMiddle(T data)
    // {
    //     DoublyNode<T> newData = new DoublyNode<T>(data);
    //     if (head == null)
    //     {
    //         head = newData;
    //         return;
    //     }
    //     if (data.CompareTo(head.data) < 0)
    //     {
    //         newData.next = head;
    //         head.previous = newData;
    //         head = newData;
    //         return;
    //     }
    //     DoublyNode<T> current = head;
    //     while (current.next != null && current.next.data.CompareTo(data)<0)
    //     {
    //         current = current.next;
    //     }
    //     if (current.next == null)
    //     {
    //         current.next = newData;
    //         newData.previous = current;
    //     }
    //     else
    //     {
    //         newData.next = current.next;
    //         current.next.previous = newData;
    //         newData.previous = current;
    //         current.next = newData;
    //     }
    // }

    public void update(T oldData,T newData)
    {
        DoublyNode<T> current=head;
        if (head.data.Equals(oldData))
        {
            head.data=oldData;
        }
        else{
            while (current.data.Equals(oldData))
            {
                current=current.next;
            }
            current. data=newData;
        }
    }

    public void delete(T data)
    {
        if (head.data.Equals(data))
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
            DoublyNode<T> current=head;
            while (!current.next.data.Equals(data))
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
            
            DoublyNode<T> current = head;
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
            DoublyNode<T> current=tail;
            while (current != null)
            {
                Console.Write("<---"+ current.data);
                current = current.previous;
            }
            Console.Write("<---null");
    }

    public IEnumerator<T> GetEnumerator()
        {
            DoublyNode<T> p = head;
            while (p != null)
            {
                yield return p.data;
                p = p.next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }


