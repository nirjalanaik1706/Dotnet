namespace StringLength;

public class Program
{
    public static void Main(string[] args)
    {

        string str = "Nirjala";   //if we add space , it also calculate the space
        int count = 0;

        foreach (char ch in str)
        {
            count++;
        }

        Console.WriteLine("Withouot Library Function: "+count);
        Console.WriteLine("With Library Function Length : "+str.Length);
    }
}