namespace ReverseString;

public class Program
{
    public static void Main(string[] args)
    {
        string str = "Nirjala";
        string revStr = "";

        for (int i = str.Length - 1; i >= 0; i--)
        {
            revStr += str[i];
        }
        Console.WriteLine("Reverse string: " + revStr);

    }
}