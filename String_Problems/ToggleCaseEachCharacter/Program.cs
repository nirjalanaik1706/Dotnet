namespace ToggleEachCharacter;

public class Program
{
    public static void Main(string[] args)
    {
        string str="NirJala Naik";

        foreach(char ch in str)
        {
            if (char.IsUpper(ch))
            {
                Console.Write(char.ToLower(ch));
            }
            else
            {
                Console.Write(char.ToUpper(ch));
            }
        }
    }
}