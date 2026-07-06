namespace TFLDSA.Node;

public class Node
{
    public int data;
    public Node ?next;
    public Node ?previous;


    public Node(int data)
    {
        this.data=data;
        Node next=null;
        Node previous=null;
    }
}