namespace RemoveExtraSpaces;

public class Program
{
    public static void Main(string[] args)
    {
        string str="  Nirjala  Dattatray      Naik  ";
        Console.WriteLine(string.Join(" ",str.Split(' ',StringSplitOptions.RemoveEmptyEntries)));
    }
}