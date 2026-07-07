namespace TFLDSA.Collections.CirculerList;

public class CirculerNode
{
    
    public int data;
    public CirculerNode next;

    public CirculerNode(int data)
    {
        this.data=data;
        this.next=null;
    }
}